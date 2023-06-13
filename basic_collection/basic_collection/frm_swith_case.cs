using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
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
                case "1": MessageBox.Show("1 statement");
                    break;

                case "2": MessageBox.Show("2 Statement");
                    break;
                default: MessageBox.Show("else block");
                    break;
            }
        }
    }
}
