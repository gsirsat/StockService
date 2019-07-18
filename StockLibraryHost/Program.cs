using StockLibrary;
using System;
using System.ServiceModel;

namespace StockLibraryHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(StockService));
                   
            try
            {
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("**********************Live Stock Prices**************************");
                Console.WriteLine("*****************************************************************");

                host.Open();
                               
                Console.ReadLine();
                
                host.Close();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                host.Abort();
            }
        }
        
    }
}
