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
    public Task<WorkOutEventClass> GetWorkoutEventDetails(Datum ride);
    public Task<WorkOutDetailsClass> GetWorkoutDetails(string id, int secondsPerObservation);
    public Task<WorkOutUserDetailsClass> GetWorkoutUserDetails(Datum ride);
    public Task<RideList> GetWorkoutListAsync(int maxRides);
}