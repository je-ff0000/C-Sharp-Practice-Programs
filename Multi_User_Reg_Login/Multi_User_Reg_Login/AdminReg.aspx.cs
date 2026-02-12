using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multi_User_Reg_Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConnectionClass objcls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Login_Details";
            string maxregid = objcls.Fn_Scalar(sel);
            int reg_id = 0;
            if(maxregid == "")
            {
                reg_id = 1;
            }

            else
            {
                int newregid = Convert.ToInt32(maxregid);
                reg_id = newregid + 1;
            }

            string ins = "insert into Admin_Reg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = objcls.Fn_NonQuery(ins);

            if (i == 1)
            {
                string inslog = "insert into Login_Details values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','admin','active')";
                int j = objcls.Fn_NonQuery(inslog);
                Label1.Text = "Inserted";
            }

        }
    }
}