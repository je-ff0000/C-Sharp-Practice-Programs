using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        ConnectionClass objcls = new ConnectionClass();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "select count(Id) from Reg_Tab where Username='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'";
            string cid = objcls.Fn_Scalar(s);

            if (cid == "1")
            {
                string s1 = "select Id from Reg_Tab where Username='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'";
                string id = objcls.Fn_Scalar(s1);
                A.P1 = Convert.ToInt32(id);
                Profile obp = new Profile();
                obp.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Incorrect Username or Password";
            }

        }

        public static class A
        {
            public static int P1
            {
                set; get;
            }
        }
    }
}
