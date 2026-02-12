using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace FormsAuth
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-FJ6P97JK\SQLEXPRESS;database=ASP_Example;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string s = "select count(Id) from User_Register where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(s, con);

            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();

            if (cid == "1")
            {
                string strid = "select Id from User_Register where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                SqlCommand cmdid = new SqlCommand(strid, con);
                con.Open();
                string id = cmdid.ExecuteScalar().ToString();
                con.Close();
                Session["uid"] = id;

                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
                Response.Redirect("Redirect_Page.aspx");
            }
            else
                Label1.Text = "Invalid Username or Password";
        }
    }
}