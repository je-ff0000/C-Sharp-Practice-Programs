using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TwoLayerApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ConnectionClass objCls = new ConnectionClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string strinsert = "insert into TwoLayer values ('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + path + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = objCls.Fn_NonQuery(strinsert);
            if(i == 1)
            {
                Label1.Text = "Inserted";
            }
        }
    }
}