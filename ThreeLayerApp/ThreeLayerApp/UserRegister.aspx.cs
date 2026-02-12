using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusLogicLayer;

namespace ThreeLayerApp
{
    public partial class UserRegister : System.Web.UI.Page
    {
        InsertClass objbll = new InsertClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));
            int i = objbll.InsertDB(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, s, TextBox4.Text, TextBox5.Text);

            if (i == 1)
            {
                Label1.Text = "Inserted";
            }

        }
    }
}