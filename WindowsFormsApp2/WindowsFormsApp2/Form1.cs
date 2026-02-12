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
    public partial class Form1 : Form
    {
        ConnectionClass objcls = new ConnectionClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (string item in checkedListBox1.CheckedItems)
            {
                s = s + item + ",";
            }

            string g = "";
            if (radioButton1.Checked)
            {
                g = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                g = radioButton2.Text;
            }

            string newdt = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()).ToString("yyyy-MM-dd");

            string str = "insert into Reg_Tab values('" + textBox1.Text + "','" + richTextBox1.Text + "','" + g + "','" + comboBox1.SelectedItem.ToString() + "','" + newdt + "','" + s + "','" + textBox2.Text + "','" + textBox3.Text + "')";

            int i = objcls.Fn_NonQuery(str);
            if (i == 1)
            {
                label9.Text = "Inserted";
            }
        }
    }
}
