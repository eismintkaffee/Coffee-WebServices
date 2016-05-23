using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeSort
{
    public partial class CoffeeSortForm : System.Web.UI.Page
    {
        Service1 myClient = new Service1();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string list = " ";
            list = myClient.theList();
            Label1.Text = list + "\r\n";
        }

        protected void Alpha_Click(object sender, EventArgs e)
        {
            string list = " ";
            list = myClient.sortListAlpha();
            Label1.Text = list + "\r\n";
        }

        protected void alphaZ_Click(object sender, EventArgs e)
        {
            string list = " ";
            list = myClient.sortListDesending();
            Label1.Text = list + "\r\n";
        }

        protected void priceLow_Click(object sender, EventArgs e)
        {
            string list = " ";
            list = myClient.sortListPriceLow();
            Label1.Text = list + "\r\n";
        }

        protected void priceHigh_Click(object sender, EventArgs e)
        {
            string list = " ";
            list = myClient.sortListPriceHigh();
            Label1.Text = list + "\r\n";
        }

        protected void calLow_Click(object sender, EventArgs e)
        {
            string list = " ";
            list = myClient.sortListCalLow();
            Label1.Text = list + "\r\n";
        }

        protected void calHigh_Click(object sender, EventArgs e)
        {
            string list = " ";
            list = myClient.sortListCalHigh();
            Label1.Text = list + "\r\n";
        }
    }
}