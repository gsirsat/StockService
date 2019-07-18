using Client.StockService;
using System;
using System.Configuration;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Achieved Requirement 1.The project should be separated into Client module and Service module(Assemblies).  Client module could be WPF, WinForm or Console application and will display prices live ticking prices.
            //Achieved Requirement 5.Design the project in such a way that the client module can use different Service modules without changing the client code. {as we used Channel Factory, itnternally, it can use any service to display stock service }

            var channelFactory = new ChannelFactory<IStockService>("UDP_IStockService");
            var channel = channelFactory.CreateChannel();

            string stockName = ConfigurationManager.AppSettings["stockName"]; 
            Console.WriteLine("Now please check Client {0} price published on the service window", stockName);

            while (true)
            {   
                channel.DisplayStockDetail(stockName);
                System.Threading.Thread.Sleep(1000); //Requirement 2. Prices should tick every second
            }
        }
        
    }
}
