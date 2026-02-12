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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = richTextBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = comboBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = listBox1.SelectedItem.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string g = "";
            if (radioButton1.Checked)
            {
                g = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                g = radioButton2.Text;
            }
            label6.Text = g;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 ob = new Form2();
            ob.Show();
            this.Hide();

        }
    }
}
