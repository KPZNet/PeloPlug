using PeloPlug;

namespace PeloPlugTest;
using System.Text.Json;
using System.Text.Json.Serialization;

[TestClass]
public class UnitTestPeloPlug
{
    private IPelo iPelo;

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
        var dataRet = await iPelo.GetWorkoutListAsync(3);
        Assert.IsTrue(dataRet.Count == 3);
    }

    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("PeloData")]
    public async Task WorkOutEventDetails_Success()
    {
        var dataRet = await iPelo.GetWorkoutListAsync(20);
        var eventDetails = await iPelo.GetWorkoutEventDetails(dataRet[0]);
        Assert.IsTrue(eventDetails != null);
        Assert.IsTrue(eventDetails.ride.id != null);

    }

    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("PeloData")]
    public async Task WorkOutDetails_Success()
    {
        var dataRet = await iPelo.GetWorkoutListAsync(3);
        var workOutDetails = await iPelo.GetWorkoutDetails(dataRet[0].id, 60);
        Assert.IsTrue(workOutDetails != null);
    }

    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("PeloData")]
    public async Task WorkOutUserDetails_Success()
    {
        var dataRet = await iPelo.GetWorkoutListAsync(20);
        var workOutUserDetails = await iPelo.GetWorkoutUserDetails(dataRet[10]);
        Assert.IsTrue(workOutUserDetails != null);
    }
}