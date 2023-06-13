using MySqlX.XDevAPI.Common;
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
    public partial class frm_isUpper : Form
    {
        public frm_isUpper()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            string input_text = txt_input.Text;
            string output = "";

            foreach(char c in input_text)
            {
                if (char.IsUpper(c))
                {
                    output += c;
                }
            }

           //for(int i =0;i< input_text.Length;i++)
           // {
           //     if (char.IsUpper(input_text[i]))
           //     {
           //         output += input_text[i];
           //     }
           // }
            MessageBox.Show(output);
       
        }
    }
}
