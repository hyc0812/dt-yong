using System;
using Azure.DigitalTwins.Core;
using Azure.Identity;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using Azure;


namespace dt_yong
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string adtInstanceUrl = "https://instance-yong.api.wcus.digitaltwins.azure.net"; 
            var credential = new DefaultAzureCredential();
            var client = new DigitalTwinsClient(new Uri(adtInstanceUrl), credential);
            Console.WriteLine($"Service client created – ready to go");
            Console.WriteLine();
            Console.WriteLine($"Upload a model");
            string dtdl = File.ReadAllText("SampleModel.json");
            var models = new List<string> { dtdl };
            // Upload the model to the service
            await client.CreateModelsAsync(models);
        }
    }
}
