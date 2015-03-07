using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countGames = 0;
            string inputString = txtInput.Text;
            int position = 0;
            string result = "";

            //My games
            for(int i = 0; i < inputString.Length; i++)
            {
                position = inputString.IndexOf("games", i);
                if(position == 0)
                {
                    break;
                }
                else
                {
                    countGames += 1;
                    i = position + 5;
                }
                
            }

            result = string.Format("There are {0} games in the whole string", countGames);
            txtCount.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputString = txtInput.Text;
            string result = inputString.Replace("each day", "EACH DAY");
            txtInput.Text = result;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
