using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace UI_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string gender = null;
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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
               {
                  
               }
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                gender = "Male";
            }
            if(radioButton2.Checked == false)
            {
                gender = "Female";
            }
            string foreignLanguage;
            if(checkBox1.Checked == true)
            {
                foreignLanguage = "Yes";
            }
            else
            {
                foreignLanguage = "No";
            }
            //NOT WORKING
            string formInfo = "First Name: " + textBox2.Text + "\r\nLast Name: " + textBox3.Text + "\r\nDOB: " + textBox4.Text + "\r\nGender: " + gender + "\r\nSpeak a foreign language " + foreignLanguage + "\r\nState: " + comboBox1.SelectedItem + "\r\nCity: " + comboBox2.SelectedItem + "\r\nAddress: " + textBox1.Text + "\r\nZip Code: " + textBox5.Text;
            string fileName = "C:\\" +textBox2.Text + "_" + textBox3 + "_" + ".txt";
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\");
            file.WriteLine(formInfo);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

       
        
     }
}
