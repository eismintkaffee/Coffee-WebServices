using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderHistoryService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderHistory" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderHistory.svc or OrderHistory.svc.cs at the Solution Explorer and start debugging.
    public class OrderHistory : IOrderHistory
    {
        public List<OrderH> setYourHistory()
        {
            List<OrderH> listHistory = new List<OrderH>();
            listHistory.Add(new OrderH { Name = "CAFE MOCHA", Price = 3.69, Calories = 370, date = "03-1-2016" });
            listHistory.Add(new OrderH { Name = "AMERICANO", Price = 2.49, Calories = 70, date = "03-5-2016" });
            listHistory.Add(new OrderH { Name = "AMERICANO", Price = 2.49, Calories = 70, date = "03-7-2016" });
            listHistory.Add(new OrderH { Name = "CAPPUCCINO", Price = 3.49, Calories = 178, date = "03-11-2016" });
            listHistory.Add(new OrderH { Name = "CAFE MOCHA", Price = 3.69, Calories = 370, date = "03-14-2016" });

            return listHistory;
        
        }


        public OrderH yourHistory(string d)
        {
            OrderH history = null;
            
           //maybe put in data contract constructor section

            setYourHistory();
            List<OrderH> theHistoryList = new List<OrderH>();

            theHistoryList = setYourHistory();

            foreach (OrderH aHistory in theHistoryList) {
                if (theHistoryList.Exists(x => x.date.Contains(d)) == true)
                {
                    history = theHistoryList.Find(x => x.date.Contains(d));
                    //return history;
                }
                else//**need to check if there is no date (maybe try catch statement)
                {
                    theHistoryList.Exists(x => x.date.Contains(d));
                    history = null;
                }
               
            }

            return history;

        }
    }
}
