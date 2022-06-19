using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace Project1_webapp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                string strcon = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("splogin_new", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "SELECT");
                cmd.Parameters.AddWithValue("@UNAME", UserName.Text);
                cmd.Parameters.AddWithValue("@PWD", Password.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    //FormsAuthentication.SetAuthCookie(UserName.Text, false);
                    Session["uname"]=UserName.Text;
                    Response.Redirect("Product.aspx"); 

                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }


        }
    }
}