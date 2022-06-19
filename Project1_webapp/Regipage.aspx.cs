using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project1_webapp
{
    public partial class Regipage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                TxtCity.SelectedIndex = 0;
                var city = new List<string>
                {
                    "Chennai","Bangalore","Mumbai","Pune"
                };
                city.Sort();
                TxtCity.DataSource = city;
                TxtCity.DataBind();
            }

        }
        protected void Submit_click(object sender,EventArgs e)
        {
            //adding gender 
            string gender=string.Empty;
            if(TxtGender1.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            SqlConnection con = new SqlConnection(@"Data Source=NIDARSHAN\SQLEXPRESS;Initial Catalog=proj1;Integrated Security=True");
            con.Open();
            //SqlCommand cmd = new SqlCommand("Insert into login values(@uname,@pwd,@city,@gender)",con);
            SqlCommand cmd = new SqlCommand("splogin_NEW", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ACTION", "INSERT");
            cmd.Parameters.AddWithValue("@UNAME",TxtUname.Text);
            cmd.Parameters.AddWithValue("@PWD",Txtcpwd.Text);
            cmd.Parameters.AddWithValue("@CITY",TxtCity.Text);
            cmd.Parameters.AddWithValue("@GENDER",gender);
           
            int res=cmd.ExecuteNonQuery();
            con.Close();
            if(res >0)
            {
                Response.Write("<script>alert('registered Successfully');</script>");

            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand("splogin_NEW", con);
            cmd1.CommandType= CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Action", "SELECT");
            SqlDataReader rdr = cmd1.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
            Cleartextboxes(this);

        }
        public void Cleartextboxes(Control parent)
        {
            foreach(Control c in parent.Controls)
            {
                if((c.GetType()==typeof(TextBox)))
                {
                    ((TextBox)(c)).Text = " ";
                }
                if(c.HasControls())
                {
                    Cleartextboxes(c);
                }
                    
            }
        }
    }
}