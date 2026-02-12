using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Profile : Form
    {
        ConnectionClass obj = new ConnectionClass();
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Login.A.P1);

            string sel = "select * from Reg_Tab where id =" + id + "";
            SqlDataReader dr = obj.Fn_SqlReader(sel);

            while (dr.Read())
            {
                label6.Text = dr["Name"].ToString();
                label7.Text = dr["Address"].ToString();
                label8.Text = dr["Gender"].ToString();
                label9.Text = dr["State"].ToString();
                DateTime date = Convert.ToDateTime(dr["Date"].ToString());
                label10.Text = date.ToShortDateString();
            }

            DataSet ds = obj.Fun_exeAdapter(sel);
            dataGridView1.DataSource = ds.Tables[0];

            DataTable dt = obj.Fn_Exedatatable(sel);
            dataGridView1.DataSource = dt;
        }
    }
}
