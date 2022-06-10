using Microsoft.VisualStudio.TestTools.UnitTesting;

using PeloPlug;

namespace PeloPlugTest;

[TestClass]
public class Tests
{
    private IPelo iPelo;

    [SetUp]
    public void Setup()
    {
        iPelo = new PeloClient();
    }

    [Test]
    public async Task AuthenticateTest_Success()
    {
        await iPelo.GetUserIDSession("kenceglia@hotmail.com", "Denver.12k");
        var d = await iPelo.GetWorkoutListAsync(3);
    }
}