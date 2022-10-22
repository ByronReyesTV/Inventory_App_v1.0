using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("T");

            /*label9.Text = DateTime.Now.ToString("D");*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label2 = textBox1.Text;
            string label3 = comboBox1.Text;
            string label4 = dateTimePicker1.Text;
            string label5 = dateTimePicker2.Text;
            string label6 = textBox3.Text;
            string label7 = textBox4.Text;

            richTextBox1.Text = label2 + label3 + label4 + label5 + label6 + label7;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be Available in v2.0", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be Available in v2.0", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be Available in v2.0", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
