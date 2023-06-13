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
    public partial class frm_trik : Form
    {
        public frm_trik()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = 3;
           

            string input_text = txt_input.Text;

            for(int i =0;i< input_text.Length; i++)
            {
                if (input_text[i] == 1)
                {
                   
                }
            }
        }
    }
}
