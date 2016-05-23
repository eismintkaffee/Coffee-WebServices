using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoffeeSearch
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICoffeeSearch" in both code and config file together.
    [ServiceContract]
    public interface ICoffeeSearch
    {
        [OperationContract]
        string coffeeSearch(string getSearch);

        [OperationContract]
        string theStringList(List<coffeeInfo> cList);

        [OperationContract]
        string theList();

        [OperationContract]
        List<coffeeInfo> maketheList();
    }

    [DataContract]
    public class coffeeInfo
    {
        string name;
        int calories;
        double price;

        [DataMember]
        public string Name
        {
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
        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        public coffeeInfo()
        {
            //this.Name = name;

        }
    }

}
