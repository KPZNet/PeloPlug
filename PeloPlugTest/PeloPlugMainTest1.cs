using PeloPlug;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeloPlugTest;

[TestClass]
public class UnitTestPeloPlug
{
    [TestMethod]
    public async Task Authenticate_Success()
    {
        IPelo iPelo = new PeloClient();
        var b = await iPelo.GetUserIDSession("KenCeglia@hotmail.com", "Denver.12k");
        Assert.IsTrue(b);
    }
    [TestMethod]
    public async Task Authenticate_Fail()
    {
        IPelo iPelo = new PeloClient();
        var b = await iPelo.GetUserIDSession("XKenCeglia@hotmail.com", "Denver.12k");
        Assert.IsFalse(b);
    }
    [TestMethod]
    public async Task WorkOutList_Success()
    {
        IPelo iPelo = new PeloClient();
        var b = await iPelo.GetUserIDSession("KenCeglia@hotmail.com", "Denver.12k");
        Assert.IsTrue(b);
    }
}