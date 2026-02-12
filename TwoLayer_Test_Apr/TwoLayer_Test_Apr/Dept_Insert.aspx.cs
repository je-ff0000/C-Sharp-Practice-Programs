using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TwoLayer_Test_Apr
{
    public partial class Dept_Insert : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string q1 = "select Id, Name from Dept_Tab";
                DataSet ds = obj.Fun_Adapter(q1);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "-select-");
            }
            
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
            string q = "insert into Dept_Tab values(" + reg_id + "'" + TextBox1.Text + "')";
            int i = obj.Fn_NonQuery(q);

            if (i == 1)
            {
                Label1.Text = "Inserted";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept = DropDownList1.SelectedItem.Text;
            string q2 = "select Name, Age, Department, Photo from Doctor_Reg where Department ='" + dept + "'";

            DataSet ds = obj.Fun_Adapter(q2);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}