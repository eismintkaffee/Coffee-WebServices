using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace OrderHistoryService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderHistory" in both code and config file together.
    [ServiceContract]
    public interface IOrderHistory
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/yourHistory/{d}")]
        OrderH yourHistory(string d);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/orderHistory/")]
        List<OrderH>setYourHistory();

        
    }

    [DataContract]
    public class OrderH
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int Calories { get; set; }

        [DataMember]
        public string date {get; set;}

        public OrderH()
        {
           

        }
    }
}
