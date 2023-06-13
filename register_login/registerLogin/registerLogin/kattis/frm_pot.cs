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
    public partial class frm_pot : Form
    {
        public frm_pot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            string number2 = textBox2.Text;
            int last_index1 = number1.Length - 1;
            int last_index2= number2.Length - 1;

           int power1 = int.Parse(number1[last_index1].ToString());
            int power2 = int.Parse(number2[last_index2].ToString());
            //MessageBox.Show($"{power1}{power2}");

            string base1 = "", base2 = "";
            int c_base1,c_base2;
            for(int i = 0; i <= last_index1; i++)
            {
                base1 += number1[i];
            }
            for (int i = 0; i <= last_index2; i++)
            {
                base2 += number2[i];
            }
            c_base1 = int.Parse(base1);
            c_base2 = int.Parse(base2);
           int firstNum = (int) Math.Pow(c_base1, power1);
           int secondNum = (int)  Math.Pow(c_base2, power2);
            int sum = firstNum + secondNum;
            MessageBox.Show($"{sum}");


            //essageBox.Show($"{number1[num1_index]}");
            //ssageBox.Show($"{number2[num2_index]}");

            //int power1 = int.Parse(number1[num1_index].ToString());
            //int power2 = number2[num2_index];
            //string base1 = "",base2 = "";

            //for (int i = 0; i < number1.Length - 1; i++){
            //   base1 += $"{number1[i]}";

            //}
            //sum += (int)Math.Pow(int.Parse(base1), power1);

            //for (int i = 0; i < number2.Length - 1; i++)
            //{
            //    base2 += $"{number1[i]}";

            //}




            //MessageBox.Show($"base 1 = {base1} , = , base2 = {base2}");
            //int c_base1 = int.Parse(base1);
            //int c_base2 = int.Parse(base2);

            //int num1 = Convert.ToInt16(Math.Pow(c_base1, power1));
            //int num2 = Convert.ToInt16(Math.Pow(c_base2, power2));
            // MessageBox.Show($"{ num1 +num2 }");

        }
    }
}
