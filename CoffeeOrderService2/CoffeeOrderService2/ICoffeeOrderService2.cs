using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace CoffeeOrderService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICoffeeOrderService2" in both code and config file together.
    [ServiceContract]
    public interface ICoffeeOrderService2
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/welcome/{yourName}")]
        TextMessage welcome(string yourName);
        
        ////for ordering coffee
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/yourorder/{n}")]
        string yourOrder(string n);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "menu")]
        List<coffeeInfo> GetCoffee();
        
      
       
    }


    //test service with a welcome prompt
    [DataContract]
    public class TextMessage
    {
        [DataMember]
        public string Message { get; set; }
    }

    //Create data for coffee


    [DataContract]
    public class coffeeInfo
    {
        [DataMember]
        public string Name{ get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int Calories { get; set; }

        public coffeeInfo()
        {
            //this.Name = name;
            
        }
    }
 
}
