using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;
using WorkOutDetailsNames;
using WorkOutEventNames;
using WorkOutListNames;
using WorkOutUserDetailsNames;

namespace PeloPlug;

public class PeloClient : IPelo
{
    private readonly AuthenticationIDS authIDs = new();
    private readonly HttpClient client = new();

    private int pageSize { get; } = 20;
    private int ThrottleMilliseconds { get; } = 250;

    public RideList RideData { get; set; } = new();

    public void WriteJSON(String fileName, object jsn)
    {
        string jsonString = JsonConvert.SerializeObject(jsn);
        File.WriteAllText(fileName, jsonString);
    }

    public async Task<bool> GetUserIDSession(string userName, string passWord)
    {
        var bReturn = false;
        var person = new Person();
        person.username_or_email = userName;
        person.password = passWord;

        var json = JsonConvert.SerializeObject(person);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var url = "https://api.onepeloton.com/auth/login";

        var response = await client.PostAsync(url, data);
        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.ReadAsStringAsync().Result;
            var pdx = JsonConvert.DeserializeObject<UserSession>(result);
            authIDs.userID = pdx.user_id;
            authIDs.sessionID = pdx.session_id;
            bReturn = true;
        }

        return bReturn;
    }

    public async Task<WorkOutEventClass> GetWorkoutEventDetails(string id)
    {
        WorkOutEventClass eventDetails = null;
        var url = $"https://api.onepeloton.com/api/ride/{id}/details";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");

        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                var result = response.Content.ReadAsStringAsync().Result;
                eventDetails = JsonConvert.DeserializeObject<WorkOutEventClass>(result, settings);

            }
            catch (Exception e)
            {
            }
        }
        WriteJSON("EventDetails.json", eventDetails);
        return eventDetails;
    }

    public async Task<WorkOutDetailsClass> GetWorkoutDetails(string id, int secondsPerObservation = 1)
    {
        WorkOutDetailsClass workOutDetails = null;
        var url = $"https://api.onepeloton.com/api/workout/{id}/performance_graph?every_n={secondsPerObservation}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");

        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            var result = response.Content.ReadAsStringAsync().Result;
            workOutDetails = JsonConvert.DeserializeObject<WorkOutDetailsClass>(result, settings);
        }
        WriteJSON("WorkoutDetails.json", workOutDetails);
        return workOutDetails;
    }

    public async Task<WorkOutUserDetailsClass> GetWorkoutUserDetails(string id)
    {
        WorkOutUserDetailsClass workOutUserDetails = null;
        var url = $"https://api.onepeloton.com/api/workout/{id}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");

        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            var result = response.Content.ReadAsStringAsync().Result;
            workOutUserDetails = JsonConvert.DeserializeObject<WorkOutUserDetailsClass>(result, settings);
        }
        WriteJSON("UserWorkoutrDetails.json", workOutUserDetails);
        return workOutUserDetails;
    }

    public async Task<RideList> GetWorkoutListAsync(int maxRides = 1000000)
    {
        var cookie = $"peloton_session_id={authIDs.sessionID}";
        var pageNum = 0;
        var totRidesSoFar = 0;

        RideData.Clear();
        var bContinueQuery = true;

        var pageLimit = pageSize;
        if (maxRides < pageLimit) pageLimit = maxRides;

        while (bContinueQuery)
        {
            var url =
                $"https://api.onepeloton.com/api/user/{authIDs.userID}/workouts?joins=ride&limit={pageLimit}&page={pageNum}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            request.Headers.Add("Cookie", cookie);
            request.Headers.Add("accept", "application/json");
            request.Headers.Add("origin", "https://members.onepeloton.com");
            request.Headers.Add("accept-language", "en-US,en;q=0.9");
            request.Headers.Add("user-agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36");
            request.Headers.Add("referer", "https://members.onepeloton.com/profile/workouts");
            request.Headers.Add("authority", "api.onepeloton.com");
            request.Headers.Add("x-requested-with", "XmlHttpRequest");
            request.Headers.Add("peloton-platform", "web");

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                var result = response.Content.ReadAsStringAsync().Result;
                var workOutList = JsonConvert.DeserializeObject<WorkOutListClass>(result, settings);
                RideData.AddRange(workOutList.data);

                totRidesSoFar += workOutList.count;
                pageNum++;

                if (workOutList.show_next == false || totRidesSoFar >= maxRides)
                    bContinueQuery = false;
                else
                    await Throttle();
            }
            else
            {
                bContinueQuery = false;
                RideData.Clear();
            }
        }
        WriteJSON("RideList.json", RideData);
        return RideData;
    }

    public async Task<RideList> GetRides(int maxRides = 1000000, int secondsPerObservation = 1)
    {
        var rideList = await GetWorkoutListAsync(maxRides);
        int count = rideList.Count(x => x.id != null);

        foreach(var ride in rideList)
        {
            ride.workoutEventDetails = await GetWorkoutEventDetails(ride.ride.id);
            ride.workoutDetails = await GetWorkoutDetails(ride.id, 60);
            ride.workoutUserDetails = await GetWorkoutUserDetails(ride.id);
        }
        WriteJSON("Rides.json", rideList);
        return rideList;
    }

    private async Task Throttle()
    {
        await Task.Delay(ThrottleMilliseconds);
    }

    internal class Person
    {
        public string username_or_email { get; set; }
        public string password { get; set; }
    }

    internal class UserSession
    {
        [JsonPropertyName("user_id")] public string user_id { get; set; }
        [JsonPropertyName("session_id")] public string session_id { get; set; }
    }

    internal class AuthenticationIDS
    {
        public string userID { get; set; }
        public string sessionID { get; set; }
    }
}