using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusLogicLayer;
using System.Data.SqlClient;
using System.Data;

namespace ThreeLayerApp
{
    public partial class UserProfile : System.Web.UI.Page
    {
        ProfileClass objbll = new ProfileClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = objbll.fn_GetData(Convert.ToInt32(Session["uid"]));
            while (dr.Read())
            {
                Label1.Text = dr["Name"].ToString();
                Label2.Text = dr["Age"].ToString();
                Label3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }

            DataSet ds = objbll.fn_GetDataSet(Convert.ToInt32(Session["uid"]));
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = objbll.fn_GetDataTable(Convert.ToInt32(Session["uid"]));
            GridView2.DataSource = dt;
            GridView1.DataBind();
        }
    }
}