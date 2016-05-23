using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CoffeeOrderService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CoffeeOrderService2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CoffeeOrderService2.svc or CoffeeOrderService2.svc.cs at the Solution Explorer and start debugging.
    public class CoffeeOrderService2 : ICoffeeOrderService2
    {

        public TextMessage welcome(string yourName)
        {
            TextMessage message = new TextMessage();
            message.Message = string.Format("Welcome to the coffee shop " + yourName);
            return message;
        }
        public List<coffeeInfo> GetCoffee()
        {
            List<coffeeInfo> coffees = new List<coffeeInfo>(5);
            coffees.Add(new coffeeInfo { Name = "AMERICANO", Price = 2.49, Calories = 70 });
            coffees.Add(new coffeeInfo { Name = "CAFE LATTE", Price = 2.69, Calories = 120 });
            coffees.Add(new coffeeInfo { Name = "CAPPUCCINO", Price = 3.49, Calories = 178 });
            coffees.Add(new coffeeInfo { Name = "BREVE", Price = 3.49, Calories = 476 });
            coffees.Add(new coffeeInfo { Name = "CAFE MOCHA", Price = 3.69, Calories = 370});

            return coffees;
        }

        public string yourOrder(string order)   //cannot return information from list in another method
        {
            
            string confirmOrder = " ";
            string test;
            test = order.ToUpper();

            List<coffeeInfo> coffees = new List<coffeeInfo>();
            coffees.Add(new coffeeInfo { Name = "AMERICANO", Price = 2.49, Calories = 70 });
            coffees.Add(new coffeeInfo { Name = "CAFE LATTE", Price = 2.69, Calories = 120 });
            coffees.Add(new coffeeInfo { Name = "CAPPUCCINO", Price = 3.49, Calories = 178 });
            coffees.Add(new coffeeInfo { Name = "BREVE", Price = 3.49, Calories = 476 });
            coffees.Add(new coffeeInfo { Name = "CAFE MOCHA", Price = 3.69, Calories = 370 });
            
            //still needs work
            foreach(coffeeInfo aCoffee in coffees) {

                if (coffees.Exists(x => x.Name.Equals(test)) == true)
                {
                    confirmOrder = "You have ordered a  an " + order + " at " + aCoffee.Price ; //"\nCost: " + coffees.Price + " " + coffees[i].Calories;
                    
                }
                else {
                    confirmOrder = "I'm sorry we do not have " + order;
                    
                }
            }
            return confirmOrder;
        }

       

        //public coffeeInfo[] menu()

        //{
        //    //list??
        //    coffeeInfo[] coffee = new coffeeInfo[5];
            
        //    //Coffee Data
        //    coffee[1].name = "Americano";
        //    coffee[1].price = 2.49;
        //    coffee[1].calories = 70;

        //    coffee[2].name = "Cafe Latte";
        //    coffee[2].price = 2.59;
        //    coffee[2].calories = 120;

        //    coffee[3].name = "Cappuccino";
        //    coffee[3].price = 3.49;
        //    coffee[3].calories = 178;

        //    coffee[4].name = "Breve";
        //    coffee[4].price = 3.49;
        //    coffee[4].calories = 478;

        //    coffee[5].name = "Mocha";
        //    coffee[5].price = 3.69;
        //    coffee[5].calories = 370;
           
        //    return coffee;
        //}
    }
}
