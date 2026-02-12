using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwoLayer_Test_Apr
{
    public partial class Admin_Reg : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select max(Reg_Id) from Login_Details";
            string maxregid = obj.Fn_Scalar(s);
            int reg_id = 0;
            if (maxregid == "")
            {
                reg_id = 1;
            }

            else
            {
                int newregid = Convert.ToInt32(maxregid);
                reg_id = newregid + 1;
            }
            string q = "insert into Admin_Reg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = obj.Fn_NonQuery(q);

            if (i == 1)
            {
                string inslog = "insert into Login_Details values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','Admin','active')";
                int j = obj.Fn_NonQuery(inslog);
                if (j == 1)
                {
                    Label1.Text = "Inserted";
                }
                else
                {
                    Label1.Text = "Error";
                }
               
            }
        }
    }
}