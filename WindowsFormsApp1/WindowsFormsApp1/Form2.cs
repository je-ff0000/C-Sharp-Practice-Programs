using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
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

            label1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
