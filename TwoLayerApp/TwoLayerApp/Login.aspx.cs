using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TwoLayerApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ConnectionClass objcls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select count(Id) from TwoLayer where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = objcls.Fn_Scalar(s);

            if (cid == "1")
            {
                string strid = "select Id from TwoLayer where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string id = objcls.Fn_Scalar(strid);
                Session["uid"] = id;

                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
                Response.Redirect("UserProfile.aspx");
            }
            else
                Label1.Text = "Invalid Username or Password";
        }
    }
}