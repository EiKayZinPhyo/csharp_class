using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registerLogin.kattis
{
    public partial class month : Form
    {
        public month()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            String userinput= txt_user_input.Text;

            if(userinput == "1")
            {
                MessageBox.Show("January");
            }
            else if(userinput == "2") 
            {
                MessageBox.Show("February");
            }
            else if (userinput == "2")
            {
                MessageBox.Show("February");
            }
            else if (userinput == "3")
            {
                MessageBox.Show("March");
            }
            else if (userinput == "4")
            {
                MessageBox.Show("April");
            }
            else if (userinput == "5")
            {
                MessageBox.Show("May");
            }
            else if (userinput == "6")
            {
                MessageBox.Show("June");
            }
            else if (userinput == "7")
            {
                MessageBox.Show("July");
            }
            else if (userinput == "8")
            {
                MessageBox.Show("August");
            }
            else if (userinput == "9")
            {
                MessageBox.Show("September");
            }
            else if (userinput == "10")
            {
                MessageBox.Show("October");
            }
            else if (userinput == "11")
            {
                MessageBox.Show("November");
            }
            else if (userinput == "12")
            {
                MessageBox.Show("December");
            }
            else
            {
                MessageBox.Show("Invalid number.");
            }
        }
    }
}
