using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Texas")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Dallas");
                comboBox2.Items.Add("Houston");
                comboBox2.Items.Add("Austin");
            }
            else if ((string)comboBox1.SelectedItem == "California")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Los Angeles");
                comboBox2.Items.Add("San Francisco");
                comboBox2.Items.Add("San Diego");
            }
            else if ((string)comboBox1.SelectedItem == "                ")
            {
                comboBox2.Items.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 5;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(char.IsNumber(e.KeyChar) || e.KeyChar=='.')
             {

             }
            else
             {
                 e.Handled = e.KeyChar != (char)Keys.Back;
             }
        }
     }
}
