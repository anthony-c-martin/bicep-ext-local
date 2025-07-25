using System.Text.Json;
using System.Text.Json.Nodes;
using Bicep.Extension.Local;
using Bicep.Local.Extension.Host.Handlers;

namespace Bicep.Extension.Local.Handlers;

public class AssertHandler : TypedResourceHandler<AssertResource, AssertResourceIdentifiers>
{
    protected override async Task<ResourceResponse> Preview(ResourceRequest request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return GetResponse(request);
    }

    protected override async Task<ResourceResponse> CreateOrUpdate(ResourceRequest request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        if (!request.Properties.Condition)
        {
            throw new ResourceErrorException("AssertionFailed", $"Assertion '{request.Properties.Name}' failed!");
        }

        return GetResponse(request);
    }

    protected override AssertResourceIdentifiers GetIdentifiers(AssertResource properties)
        => new()
        {
            Name = properties.Name
        };
}
