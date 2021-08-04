// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}
// using System;
// using Microsoft.Azure.WebJobs;
// using Microsoft.Azure.WebJobs.Host;
// using Microsoft.Azure.EventGrid.Models;
// using Microsoft.Azure.WebJobs.Extensions.EventGrid;
// using Microsoft.Extensions.Logging;

// namespace My.Function
// {
//     public static class TwinsFunction
//     {
//         [FunctionName("TwinsFunction")]
//         public static void Run([EventGridTrigger]EventGridEvent eventGridEvent, ILogger log)
//         {
//             log.LogInformation(eventGridEvent.Data.ToString());
//         }
//     }
// }
using Azure;
using Azure.Core.Pipeline;
using Azure.DigitalTwins.Core;
using Azure.Identity;
using Microsoft.Azure.EventGrid.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace My.Function
{

    public class TwinsFunction
    {
        //Your Digital Twin URL is stored in an application setting in Azure Functions
        private static readonly string adtInstanceUrl = Environment.GetEnvironmentVariable("ADT_SERVICE_URL");
        private static readonly HttpClient httpClient = new HttpClient();

        [FunctionName("TwinsFunction")]
        public static async Task Run([EventGridTrigger] EventGridEvent eventGridEvent, ILogger log)
        
        {
            log.LogInformation(eventGridEvent.Data.ToString());
            if (adtInstanceUrl == null) log.LogError("Application setting \"ADT_SERVICE_URL\" not set");
            try
            {
                //Authenticate with Digital Twins
                ManagedIdentityCredential cred = new ManagedIdentityCredential("https://digitaltwins.azure.net");
                DigitalTwinsClient client = new DigitalTwinsClient(new Uri(adtInstanceUrl), cred, new DigitalTwinsClientOptions { Transport = new HttpClientTransport(httpClient) });
                log.LogInformation($"ADT service client connection created.");
                if (eventGridEvent != null && eventGridEvent.Data != null)
                {
                    log.LogInformation(eventGridEvent.Data.ToString());

                    // Reading deviceId and temperature for IoT Hub JSON
                    JObject deviceMessage = (JObject)JsonConvert.DeserializeObject(eventGridEvent.Data.ToString());
                    string deviceId = (string)deviceMessage["systemProperties"]["iothub-connection-device-id"];
                    string deviceType = (string)deviceMessage["body"]["DeviceType"];
                    log.LogInformation($"Device:{deviceId} DeviceType is:{deviceType}");
                     var updateTwinData = new JsonPatchDocument();
                    switch (deviceType){
                        case "FanningSensor":
                            updateTwinData.AppendAdd("/ChasisTemperature", deviceMessage["body"]["ChasisTemperature"].Value<double>());
                            updateTwinData.AppendAdd("/FanSpeed", deviceMessage["body"]["Force"].Value<double>());
                            updateTwinData.AppendAdd("/RoastingTime", deviceMessage["body"]["RoastingTime"].Value<int>());
                            updateTwinData.AppendAdd("/PowerUsage", deviceMessage["body"]["PowerUsage"].Value<double>());
                            await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
                        break;
                        case "GrindingSensor":
                            updateTwinData.AppendAdd("/ChasisTemperature", deviceMessage["body"]["ChasisTemperature"].Value<double>());
                            updateTwinData.AppendAdd("/Force", deviceMessage["body"]["Force"].Value<double>());
                            updateTwinData.AppendAdd("/PowerUsage", deviceMessage["body"]["PowerUsage"].Value<double>());
                            updateTwinData.AppendAdd("/Vibration", deviceMessage["body"]["Vibration"].Value<double>());
                            await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
                        break;
                        case "MouldingSensor":
                            updateTwinData.AppendAdd("/ChasisTemperature", deviceMessage["body"]["ChasisTemperature"].Value<double>());
                            updateTwinData.AppendAdd("/PowerUsage", deviceMessage["body"]["PowerUsage"].Value<double>());
                            await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                log.LogError(e.Message);
            }

        }
    }

}
