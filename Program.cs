using System;
using Azure.DigitalTwins.Core;
using Azure.Identity;


namespace dt_yong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string adtInstanceUrl = "https://instance-yong.api.wcus.digitaltwins.azure.net"; 
            var credential = new DefaultAzureCredential();
            var client = new DigitalTwinsClient(new Uri(adtInstanceUrl), credential);
            Console.WriteLine($"Service client created – ready to go");
        }
    }
}
