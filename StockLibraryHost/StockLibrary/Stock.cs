using System.Runtime.Serialization;
using System;

namespace StockLibrary
{
    [DataContract]
    public class Stock
    {
        [DataMember]
        public string Name;

        [DataMember]
        public double Price;

        [DataMember]
        public DateTime CurrentDate;
    }
}
