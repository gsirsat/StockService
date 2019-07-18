using System.ServiceModel;

namespace StockLibrary
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        void DisplayStockDetail(string stockeName);

    }
}
