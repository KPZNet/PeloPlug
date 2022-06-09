using WebAPIClient;

namespace PeloPlugTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        var peloPlug = new PeloClient();
        await peloPlug.GetUserIDSession("kenceglia@hotmail.com", "Denver.12k");

        var d = await peloPlug.GetWorkoutListAsync(maxRides: 3);
        
    }
}