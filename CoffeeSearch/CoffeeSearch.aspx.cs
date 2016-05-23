﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeSearch
{
    public partial class CoffeeSearch1 : System.Web.UI.Page
    {
        coffeeSearch.CoffeeSearchClient myClient = new coffeeSearch.CoffeeSearchClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string list = " ";
            list = myClient.theList();
            Label1.Text = list + "\r\n";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string inputText;
            string displayText;

            inputText = this.TextBox1.Text;

            displayText = myClient.coffeeSearch(inputText);

            this.Label2.Text = displayText;
        }
    }
}