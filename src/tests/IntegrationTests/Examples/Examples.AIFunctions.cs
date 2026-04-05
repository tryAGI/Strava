using tryAGI.Strava;

namespace Strava.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AIFunctions()
    {
        //// Use Strava tools with any MEAI-compatible AI provider
        using var client = new StravaClient(apiKey: "test");
        var tools = client.AsTools();
        tools.Count.Should().BeGreaterThan(0);
    }
}
