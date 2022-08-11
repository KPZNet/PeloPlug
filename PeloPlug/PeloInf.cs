using WorkOutDetailsNames;
using WorkOutEventNames;
using WorkOutListNames;
using WorkOutUserDetailsNames;

namespace PeloPlug;

public class RideList : List<Datum>
{
}

public interface IPelo
{
    RideList RideData { get; set; }

    public Task<bool> GetUserIDSession(string userName, string passWord);
    public Task<WorkOutEventClass> GetWorkoutEventDetails(string id);
    public Task<WorkOutDetailsClass> GetWorkoutDetails(string id, int secondsPerObservation);
    public Task<WorkOutUserDetailsClass> GetWorkoutUserDetails(string id);
    public Task<RideList> GetWorkoutListAsync(int maxRides);
    public Task<RideList> GetRides(int maxRides, int secondsPerObservation);
}