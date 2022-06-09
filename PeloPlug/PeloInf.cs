using WorkOutDetailsNames;
using WorkOutEventNames;
using WorkOutListNames;
using WorkOutUserDetailsNames;

namespace WebAPIClient
{
    public interface IPelo
    {
        List<Datum> RideData { get; }

        public Task GetUserIDSession(string userName, string passWord);
        public Task<WorkOutEventClass> GetWorkoutEventDetails(Datum ride);
        public Task<WorkOutDetailsClass> GetWorkoutDetails(string id, int secondsPerObservation);
        public Task<WorkOutUserDetailsClass> GetWorkoutUserDetails(Datum ride);
        public Task<List<Datum>> GetWorkoutListAsync(int maxRides);
    }
}