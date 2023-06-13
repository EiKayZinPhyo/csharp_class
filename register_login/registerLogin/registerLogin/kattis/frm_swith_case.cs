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
    public partial class frm_swith_case : Form
    {
        public frm_swith_case()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = txt_input.Text;
            switch(data)
            {
                case "1": MessageBox.Show("1 Statement");
                    break;
                case "2": MessageBox.Show("2 Statement");
                    break;
                case "5": 
                    for(int i = 1; i <= 13; i++)
                    {
                        richTextBox1.Text += $"{i} * 5 = {i * 5}\n";
                    }
                    break;
                default:MessageBox.Show("else block");
                    break;
            }
        }
    }
}
