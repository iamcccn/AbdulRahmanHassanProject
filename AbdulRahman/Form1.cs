using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbdulRahman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            if (user == "AbdulRahman" && pass == "12345")
            {
                MessageBox.Show("Welcome AbdulRahman");

            }
            else
            {
                MessageBox.Show("inCorrect");

            }
        }
    }
}

