using IotHubDemo;
using Microsoft.Azure.Devices.Client;
using Microsoft.Extensions.Configuration;

// Connection string of the device
var configuration = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

var connectionString = configuration["ConnectionString"];

using var client = DeviceClient.CreateFromConnectionString(connectionString);

await client.SetMethodHandlerAsync("v1/activate", Handler.DefaultHandler, null);

while (true)
{
    await Task.Delay(1000);
}