using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WorkOutDetailsNames;
using WorkOutEventNames;
using WorkOutListNames;
using WorkOutUserDetailsNames;

namespace WebAPIClient;

public class PeloClient : IPelo
{
    private readonly AuthenticationIDS authIDs = new();
    private readonly HttpClient client = new();

    private int pageSize { get; } = 20;
    private int ThrottleMilliseconds { get; } = 250;

    public List<Datum> RideData { get; } = new();

    public async Task GetUserIDSession(string userName, string passWord)
    {
        var person = new Person();
        person.username_or_email = userName;
        person.password = passWord;

        var json = JsonConvert.SerializeObject(person);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var url = "https://api.onepeloton.com/auth/login";

        var response = await client.PostAsync(url, data);
        var result = response.Content.ReadAsStringAsync().Result;

        var pdx = JsonConvert.DeserializeObject<UserSession>(result);

        authIDs.userID = pdx.user_id;
        authIDs.sessionID = pdx.session_id;
    }


    public async Task<WorkOutEventClass> GetWorkoutEventDetails(Datum ride)
    {
        var url = $"https://api.onepeloton.com/api/ride/{ride.ride.id}/details";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");

        var response = await client.SendAsync(request);
        var result = response.Content.ReadAsStringAsync().Result;

        var eventDetails = JsonConvert.DeserializeObject<WorkOutEventClass>(result);

        return eventDetails;
    }

    public async Task<WorkOutDetailsClass> GetWorkoutDetails(string id, int secondsPerObservation = 1)
    {
        var url = $"https://api.onepeloton.com/api/workout/{id}/performance_graph?every_n={secondsPerObservation}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");

        var response = await client.SendAsync(request);
        var result = response.Content.ReadAsStringAsync().Result;

        var workOutDetails = JsonConvert.DeserializeObject<WorkOutDetailsClass>(result);

        return workOutDetails;
    }

    public async Task<WorkOutUserDetailsClass> GetWorkoutUserDetails(Datum ride)
    {
        var url = $"https://api.onepeloton.com/api/workout/{ride.id}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");

        var response = await client.SendAsync(request);
        var result = response.Content.ReadAsStringAsync().Result;

        var workOutUserDetails = JsonConvert.DeserializeObject<WorkOutUserDetailsClass>(result);
        return workOutUserDetails;
    }

    public async Task<List<Datum>> GetWorkoutListAsync(int maxRides = 1000000)
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
            var result = response.Content.ReadAsStringAsync().Result;

            var workOutList = JsonConvert.DeserializeObject<WorkOutListClass>(result);
            RideData.AddRange(workOutList.data);

            totRidesSoFar += workOutList.count;
            pageNum++;

            if (workOutList.show_next == false || totRidesSoFar >= maxRides)
                bContinueQuery = false;
            else
                await Throttle();
        }

        return RideData;
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