﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1_webapp
{
    public partial class Mainmaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButton2_Click(object sender,EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
        protected void LinkButton3_Click(object sender,EventArgs e)
        {
            Response.Redirect("Regipage.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Final_page.aspx");
        }
    }
}