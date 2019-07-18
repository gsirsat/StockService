using System;

namespace StockLibrary
{
    //Achieved Requirement 1.The project should be separated into Client module and Service module(Assemblies). 
    public class StockService : IStockService
    {

        //Achieved Requirement 2.	Prices should tick every second, and we would like to keep track of all the price ticks along with the time that the price changed within the client(in memory). No hard requirements in displaying the price ticks.
        //Achieved Requirement 3.	Client should only subscribe with a ticker i.e.Stock1, and the servie will keep publishing prices for that ticker for as long as it is subscribed.
        //Achieved Requirement 4.	Service module will act as a provider and publish prices based on the price logic to the client.
        public void DisplayStockDetail(string stockeName)
        {
            Random rnd = new Random();
            double Price;
            switch (stockeName)
            {
                case "Stock1":
                    Price = rnd.Next(240, 270);
                    Console.WriteLine(string.Format("Stock Name: {0}, Price: ${1:000.00}, Time: {2}", stockeName, Price, DateTime.Now));
                    break;
                case "Stock2":
                    Price = rnd.Next(180, 210);
                    Console.WriteLine(string.Format("Stock Name: {0}, Price: ${1:000.00}, Time: {2}", stockeName, Price, DateTime.Now));
                    break;
            }          
            
        }
    }
   
}
