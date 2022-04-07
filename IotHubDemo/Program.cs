using Microsoft.Azure.Devices.Client;
using System.Text;
using System.Text.Json;

// Connection string of the device
const string connectionString = "<connection string>";

// Example message to send
var text = JsonSerializer.Serialize(new
{
    Message = "This is an example message"
});

using var client = DeviceClient.CreateFromConnectionString(connectionString);

using var message = new Message(Encoding.UTF8.GetBytes(text))
{
    ContentEncoding = "utf-8",
    ContentType = "application/json"
};

await client.SendEventAsync(message);