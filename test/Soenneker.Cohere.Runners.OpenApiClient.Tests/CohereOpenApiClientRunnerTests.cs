using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Cohere.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class CohereOpenApiClientRunnerTests : FixturedUnitTest
{
    public CohereOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
