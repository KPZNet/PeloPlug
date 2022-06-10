using WebAPIClient;

namespace PeloPlugTest;

public class Tests
{
    private IPelo iPelo;

    [SetUp]
    public void Setup()
    {
        iPelo = new PeloClient();
    }

    [Test]
    public async Task Test1()
    {
        await iPelo.GetUserIDSession("kenceglia@hotmail.com", "Denver.12k");
        var d = await iPelo.GetWorkoutListAsync(3);
    }
}