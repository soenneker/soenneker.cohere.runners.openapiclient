using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cohere.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CohereOpenApiClientRunnerTests : HostedUnitTest
{
    public CohereOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
