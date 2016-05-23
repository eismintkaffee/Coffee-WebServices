using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CoffeeSort
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IcoffeeSortService
    {
        [OperationContract]
        string theStringList(List<coffeeInfo> cList);

        [OperationContract]
        string theList();

        [OperationContract]
        List<coffeeInfo> maketheList();

        [OperationContract]
        string sortListAlpha();

        [OperationContract]
        string sortListDesending();

        [OperationContract]
        string sortListPriceLow();

        [OperationContract]
        string sortListPriceHigh();

        [OperationContract]
        string sortListCalLow();

        [OperationContract]
        string sortListCalHigh();
 

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class coffeeInfo
    {
        string name;
        int calories;
        double price;

        [DataMember]
        public string Name {
            get { return name; }
            set { name = value; } 
        }

        [DataMember]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        
        [DataMember]
        public int Calories { 
            get { return calories; }
            set { calories = value; } 
        }
        public coffeeInfo()
        {
            //this.Name = name;

        }
    }
}
