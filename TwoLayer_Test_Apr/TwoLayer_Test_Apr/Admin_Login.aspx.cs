using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwoLayer_Test_Apr
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = "select count(Id) from Admin_Reg where Username='" + TextBox1.Text + "' and Username='" + TextBox2.Text + "'";

            string cid = obj.Fn_Scalar(q);

            if (cid == "1")
            {
                Response.Redirect("Dept_Insert.aspx");
            }
            else
            {
                Label1.Text = "Invalid Username and Password";
            }
        }
    }
}