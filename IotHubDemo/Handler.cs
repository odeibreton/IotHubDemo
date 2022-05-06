using Microsoft.Azure.Devices.Client;

namespace IotHubDemo;

public class Handler
{
    internal static Task<MethodResponse> DefaultHandler(MethodRequest methodRequest, object userContext)
    {
        Console.WriteLine("Method call received: {0}.", methodRequest.Name);
        Console.WriteLine(methodRequest.DataAsJson);
        var response = new MethodResponse(200);
        return Task.FromResult(response);
    }
}
