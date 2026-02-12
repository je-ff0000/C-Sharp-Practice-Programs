using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BusLogicLayer;
namespace ThreeLayerApp
{
    public partial class UserLogin : System.Web.UI.Page
    {
        LoginClass objbll = new LoginClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cid = objbll.GetCountId(TextBox1.Text, TextBox2.Text);
            if (cid == "1")
            {
                string id = objbll.GetId(TextBox1.Text, TextBox2.Text);
                Session["uid"] = id;
                Response.Redirect("UserProfile.aspx");
            }

            else
            {
                Label1.Text = "Invalid username and password";
            }
        }
    }
}