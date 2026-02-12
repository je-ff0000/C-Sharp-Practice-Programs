using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TwoLayerApp
{
    public partial class UserProfile : System.Web.UI.Page
    {
        ConnectionClass objcls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string q = "select Name, Age, Address, Photo from TwoLayer where Id=" + Session["uid"] + "";
            SqlDataReader dr = objcls.Fn_SqlReader(q);

            while (dr.Read())
            {
                Label1.Text = dr["Name"].ToString();
                Label2.Text = dr["Age"].ToString();
                Label3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }

            DataSet ds = objcls.Fun_exeAdapter(q);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = objcls.Fn_Exedatatable(q);
            DataList1.DataSource = dt;
            DataList1.DataBind();

        }
    }
}