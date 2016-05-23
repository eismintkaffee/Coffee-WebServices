using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CoffeeSort
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IcoffeeSortService
    {
         public string theStringList(List<coffeeInfo> cList)      //create a list for the coffee menu, somehow display this
        {

            string stringList  = " ";
            string name;
            double price;
            int cal;
            StringBuilder build = new StringBuilder();


            List<coffeeInfo> coffees = new List<coffeeInfo>(5);

            coffees = cList;

            foreach (coffeeInfo aCoffee in coffees) {
                name = aCoffee.Name;
                price = aCoffee.Price;
                cal = aCoffee.Calories;

                build.Append(name + "......"
                    + cal +"cal " +  "......$" + price + "<br/>" ); 

            }
            stringList = build.ToString();

            return stringList;    
            //this.Name = name;

        }

        //create the menu by using a list
       public List<coffeeInfo> maketheList(){
             List<coffeeInfo> coffees = new List<coffeeInfo>(5);

             coffees.Add(new coffeeInfo { Name = "AMERICANO", Price = 2.49, Calories = 70 });
             coffees.Add(new coffeeInfo { Name = "CAFE LATTE", Price = 2.69, Calories = 120 });
             coffees.Add(new coffeeInfo { Name = "CAPPUCCINO", Price = 3.49, Calories = 178 });
             coffees.Add(new coffeeInfo { Name = "BREVE", Price = 3.49, Calories = 476 });
             coffees.Add(new coffeeInfo { Name = "CAFE MOCHA", Price = 3.69, Calories = 370 });

             return coffees;
         }

        public string theList()      //create a list for the coffee menu, somehow display this
         {

             string coffeeList;
             coffeeList = theStringList(maketheList());

             return coffeeList;
             //this.Name = name;

         }

        public string sortListAlpha()
        {
            string sortedList;

            maketheList();  //get the coffee list
            List<coffeeInfo> cList;
            
            cList = maketheList();  //make the list equal the cList param ??? do we need this though???
            
            List<coffeeInfo> sortThisList = new List<coffeeInfo>(5);    //create a new list
            sortThisList = cList.OrderBy(o => o.Name).ToList(); // this sorts the list alphabetically using OrderBy...should we use an algorithm though

           sortedList = theStringList(sortThisList);

            return sortedList;
        }

        public string sortListDesending()
        {
            string sortedList;

            maketheList();  //get the coffee list
            List<coffeeInfo> cList;

            cList = maketheList();  
            List<coffeeInfo> sortThisList = new List<coffeeInfo>(5);    
            sortThisList = cList.OrderByDescending(o => o.Name).ToList();
            sortedList = theStringList(sortThisList);

            return sortedList;
           
        }

        public string sortListPriceLow()
        {
            string sortedList;

            maketheList();  //get the coffee list
            List<coffeeInfo> cList;

            cList = maketheList();  
            List<coffeeInfo> sortThisList = new List<coffeeInfo>(5);    
            sortThisList = cList.OrderBy(o => o.Price).ToList();

            sortedList = theStringList(sortThisList);

            return sortedList;
        
        }

        public string sortListPriceHigh()
        {
            string sortedList;

            maketheList();  //get the coffee list
            List<coffeeInfo> cList;

            cList = maketheList();
            List<coffeeInfo> sortThisList = new List<coffeeInfo>(5);
            sortThisList = cList.OrderByDescending(o => o.Price).ToList();

            sortedList = theStringList(sortThisList);

            return sortedList;

           
        }

        public string sortListCalLow()
        {
            string sortedList;

            maketheList();  //get the coffee list
            List<coffeeInfo> cList;

            cList = maketheList();
            List<coffeeInfo> sortThisList = new List<coffeeInfo>(5);
            sortThisList = cList.OrderBy(o => o.Calories).ToList();

            sortedList = theStringList(sortThisList);

            return sortedList;

        }

        public string sortListCalHigh()
        {
            string sortedList;

            maketheList();  //get the coffee list
            List<coffeeInfo> cList;

            cList = maketheList();
            List<coffeeInfo> sortThisList = new List<coffeeInfo>(5);
            sortThisList = cList.OrderByDescending(o => o.Calories).ToList();

            sortedList = theStringList(sortThisList);

            return sortedList;

        }

        //public coffeeInfo GetDataUsingDataContract(coffeeInfo coffee)
        //{
        //    if (coffee == null)
        //    {
        //        throw new ArgumentNullException("coffee");
        //    }
        //    if (coffee.Name != " ")
        //    {
        //        coffee.Name += this;
        //    }
        //    if (coffee.Calories != 0)
        //    {
        //        coffee.Calories = this.ToString;
        //    }
        //    if (coffee.Price != 0.0)
        //    {
        //        coffee.Price += this.theList();
        //    }
        //    return coffee;
        //}
    }
}
