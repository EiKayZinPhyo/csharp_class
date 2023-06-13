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
    public partial class ggez : Form
    {
        public ggez()
        {
            InitializeComponent();
        }

        int count = 0;
        private void btn_click_Click(object sender, EventArgs e)
        {
            string input_text = txt_text_box.Text;
            if(input_text == "gezz")
            {
                MessageBox.Show("Correct input");
            }
            else
            {
                count++;
                
             
            }
        }
    }
}
