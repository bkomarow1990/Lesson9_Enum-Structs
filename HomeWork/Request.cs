using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    struct Request : ICloneable
    {
        public int Code { get; set; }
        public Client AClient { get; set; }
        public DateTime OrderTime { get; set; }
        public List<RequestItem> Items { get; set; }
        public readonly double GetItemSum
        {
            get { 
                double sum=0;
                foreach (var item in Items)
                {
                    sum+= item.Count * item.Article_.Price;
                }
                return sum;
            }
        }
        public Request(int code ,Client client, DateTime order_time, List<RequestItem> items)
        {
            Code = code;
            AClient = client;
            OrderTime = order_time;
            Items = items;
            AClient.CountOrders -= items.Count;
            AClient.SummOrders += GetItemSum;
        }
        public override string ToString()
        {
            return $"========================================================================================================\nRequest\nCode: {Code}, {AClient}, \nOrderTime: {OrderTime}, Items:{String.Join('\n', Items)}\n=============================================================================================================="; 
        }

        public object Clone()
        {
            return new Request(Code, new Client(AClient.Code, AClient.Name, AClient.Adress, AClient.Phone, AClient.CountOrders), OrderTime, new List<RequestItem>(Items));
        }
    }

}
