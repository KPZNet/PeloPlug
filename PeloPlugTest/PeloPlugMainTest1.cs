using PeloPlug;

namespace PeloPlugTest;
[TestClass]
public class UnitTestPeloPlug
{
    private IPelo iPelo;
    private int numRides = 5;
    private int rideCheck = 0;

    [TestInitialize]
    public async Task StartupAsync()
    {
        iPelo = new PeloClient();
        await iPelo.GetUserIDSession("KenCeglia@hotmail.com", "Denver.12k");
    }

    [TestCleanup]
    public void Cleanup()
    {
    }


    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("Authentication")]
    public async Task Authenticate_Success()
    {
        var iPeloA = new PeloClient();
        var b = await iPeloA.GetUserIDSession("KenCeglia@hotmail.com", "Denver.12k");
        Assert.IsTrue(b);
    }

    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("PeloData")]
    public async Task Authenticate_Fail()
    {
        var iPeloF = new PeloClient();
        var b = await iPeloF.GetUserIDSession("KenCeglia@hotmail.com", "");
        Assert.IsFalse(b);
    }

    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("PeloData")]
    public async Task WorkOutList_Success()
    {
        var dataRet = await iPelo.GetWorkoutListAsync(numRides);
        int count = dataRet.Count(x => x.id != null);
        Assert.IsTrue(count == numRides);
    }

    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("PeloData")]
    public async Task WorkOutEventDetails_Success()
    {
        var dataRet = await iPelo.GetWorkoutListAsync(numRides);
        var eventDetails = await iPelo.GetWorkoutEventDetails(dataRet[rideCheck].ride.id);
        Assert.IsTrue(eventDetails != null);
        Assert.IsTrue(eventDetails.ride.id != null);

    }

    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("PeloData")]
    public async Task WorkOutDetails_Success()
    {
        var dataRet = await iPelo.GetWorkoutListAsync(numRides);
        var workOutDetails = await iPelo.GetWorkoutDetails(dataRet[rideCheck].id, 60);
        Assert.IsTrue(workOutDetails != null);
    }

    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("PeloData")]
    public async Task WorkOutUserDetails_Success()
    {
        var dataRet = await iPelo.GetWorkoutListAsync(numRides);
        var workOutUserDetails = await iPelo.GetWorkoutUserDetails(dataRet[rideCheck].id);
        Assert.IsTrue(workOutUserDetails != null);
    }
}