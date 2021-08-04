// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Microsoft.Azure.EventHubs;
// using Microsoft.Azure.WebJobs;
// using Microsoft.Extensions.Logging;

// namespace My.Function
// {
//     public static class ProcessDTUpdatetoTSI
//     {
//         [FunctionName("ProcessDTUpdatetoTSI")]
//         public static async Task Run([EventHubTrigger("twins-event-hub", Connection = "adtholeh001_EHPolicy_EVENTHUB")] EventData[] events, ILogger log)
//         {
//             var exceptions = new List<Exception>();

//             foreach (EventData eventData in events)
//             {
//                 try
//                 {
//                     string messageBody = Encoding.UTF8.GetString(eventData.Body.Array, eventData.Body.Offset, eventData.Body.Count);

//                     // Replace these two lines with your processing logic.
//                     log.LogInformation($"C# Event Hub trigger function processed a message: {messageBody}");
//                     await Task.Yield();
//                 }
//                 catch (Exception e)
//                 {
//                     // We need to keep processing the rest of the batch - capture this exception and continue.
//                     // Also, consider capturing details of the message that failed processing so it can be processed again later.
//                     exceptions.Add(e);
//                 }
//             }

//             // Once processing of the batch is complete, if any messages in the batch failed processing throw an exception so that there is a record of the failure.

//             if (exceptions.Count > 1)
//                 throw new AggregateException(exceptions);

//             if (exceptions.Count == 1)
//                 throw exceptions.Single();
//         }
//     }
// }
using Microsoft.Azure.EventHubs;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;

namespace My.Function
{
    public static class ProcessDTUpdatetoTSI
    { 
        [FunctionName("ProcessDTUpdatetoTSI")]
        public static async Task Run(
            [EventHubTrigger("twins-event-hub", Connection = "EventHubAppSetting-Twins")]EventData myEventHubMessage, 
            [EventHub("tsi-event-hub", Connection = "EventHubAppSetting-TSI")]IAsyncCollector<string> outputEvents, 
            ILogger log)
        {
            JObject message = (JObject)JsonConvert.DeserializeObject(Encoding.UTF8.GetString(myEventHubMessage.Body));
            log.LogInformation("Reading event:" + message.ToString());

            // Read values that are replaced or added
            Dictionary<string, object> tsiUpdate = new Dictionary<string, object>();
            foreach (var operation in message["patch"]) {
                if (operation["op"].ToString() == "replace" || operation["op"].ToString() == "add")
                {
                    //Convert from JSON patch path to a flattened property for TSI
                    //Example input: /Front/Temperature
                    //        output: Front.Temperature
                    string path = operation["path"].ToString().Substring(1);                    
                    path = path.Replace("/", ".");                    
                    tsiUpdate.Add(path, operation["value"]);
                }
            }
            //Send an update if updates exist
            if (tsiUpdate.Count>0){
                tsiUpdate.Add("$dtId", myEventHubMessage.Properties["cloudEvents:subject"]);
                await outputEvents.AddAsync(JsonConvert.SerializeObject(tsiUpdate));
            }
        }
    }
}

