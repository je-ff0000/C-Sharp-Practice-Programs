using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multi_User_Reg_Login
{
    public partial class Login_Page : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            string str = "select count(Reg_Id) from Login_Details where Username = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'";
            string cid = obj.Fn_Scalar(str);
            int cid1 = Convert.ToInt32(cid);

            if (cid1 == 1)
            {
                string str1 = "select Reg_Id from Login_Details where Username = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'";
                string regid = obj.Fn_Scalar(str1);
                Session["userid"] = regid;

                string str2 = "select Log_Type from Login_Details where Username = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'";
                string logtype = obj.Fn_Scalar(str2);
                if (logtype == "admin")
                {
                    Label1.Text = "Admin";
                }

                else if (logtype == "user")
                {
                    Label1.Text = "User";
                }

                else
                {
                    Label1.Text = "Invalid Username and Password";
                }
            }
        }
    }
}