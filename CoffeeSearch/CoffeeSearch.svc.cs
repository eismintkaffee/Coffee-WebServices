using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoffeeSearch
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CoffeeSearch" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CoffeeSearch.svc or CoffeeSearch.svc.cs at the Solution Explorer and start debugging.
    public class CoffeeSearch : ICoffeeSearch
    {
        public string theStringList(List<coffeeInfo> cList)      //create a list for the coffee menu, somehow display this
        {

            string stringList = " ";
            string name;
            double price;
            int cal;
            StringBuilder build = new StringBuilder();


            List<coffeeInfo> coffees = new List<coffeeInfo>(5);

            coffees = cList;

            foreach (coffeeInfo aCoffee in coffees)
            {
                name = aCoffee.Name;
                price = aCoffee.Price;
                cal = aCoffee.Calories;

                build.Append(name + "......"
                    + cal + "cal " + "......$" + price + "<br/>");

            }
            stringList = build.ToString();

            return stringList;
            //this.Name = name;

        }

        //create the menu by using a list
        public List<coffeeInfo> maketheList()   //should be private
        {
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

        public string coffeeSearch(string getSearch) {

            string result = " ";
            coffeeInfo coffee;
       
            maketheList();

            List<coffeeInfo> getCoffees = new List<coffeeInfo>();

            getCoffees = maketheList();

            foreach (coffeeInfo aCoffee in getCoffees) {
                if (getCoffees.Exists(x => x.Name.Equals(getSearch.ToUpper())) == true)
                {
                  coffee = getCoffees.Find(x => x.Name.Contains(getSearch.ToUpper()));
                  result = coffee.Name + "......" + coffee.Calories + "cal"+ "......$" + coffee.Price;
                }
                else {

                    result = "Coffee not found";
                }
            
            }

            return result;
        
        }
    }
}
