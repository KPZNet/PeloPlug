using PeloPlug;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeloPlugTest;

[TestClass]
public class UnitTestPeloPlug
{
    IPelo iPelo = null;

    [TestInitialize()]
    public void Startup()
    {
        iPelo = new PeloClient();
    }

    [TestCleanup()]
    public void Cleanup()
    {

    }


    [TestMethod]
    [Owner("Kenneth Ceglia")]
    [TestCategory("Authentication")]
    public async Task Authenticate_Success()
    {
        var b = await iPelo.GetUserIDSession("KenCeglia@hotmail.com", "Denver.12k");
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
        await iPelo.GetUserIDSession("KenCeglia@hotmail.com", "Denver.12k");
        var dataRet = await iPelo.GetWorkoutListAsync(3);
        Assert.IsTrue(dataRet.Count == 3);
    }
}