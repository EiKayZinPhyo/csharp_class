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
    public partial class frm_D_O_B : Form
    {
        public frm_D_O_B()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            //array
            int[] array_variable = { 12, 13, 14, 15 };
            //index
            MessageBox.Show(array_variable[2].ToString());


            //current day, month, year
            int c_day = DateTime.Now.Day;
            int c_month = DateTime.Now.Month;
            int c_year = DateTime.Now.Year;

            //my birthday
            string [] dob = txt_dob.Text.Split('.');
            int my_age;

            if(int.Parse(dob[2]) < c_year)
            {
                my_age = c_year - int.Parse(dob[2])-1;
            }
            else
            {
                my_age = c_year - int.Parse(dob[2]);
            }

            MessageBox.Show($"{my_age}");

         

        }
    }
}
