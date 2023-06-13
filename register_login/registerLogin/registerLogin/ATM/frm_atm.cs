using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registerLogin.ATM1
{
    public partial class frm_atm : Form
    {
        public frm_atm()
        {
            InitializeComponent();
        }

        int count = 0;
        public Account account = new Account();

        private void btn7_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "6";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "3";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "1";
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_input.Text += "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txt_input.Text == "")
            {
                this.Close();
            }
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_atm_Load(object sender, EventArgs e)
        {

        }
        public string pin, amount;
        private void cmd_balance_Click(object sender, EventArgs e)
        {
            count = 0;
            account.acc1_setter("2222", "1000");
            account.acc2_setter("1111", "3000");

            if (txt_input.Text == account.acc1_pin_getter())
            {
                pin = txt_input.Text;
                amount = account.acc1_amount_getter();
                MessageBox.Show(account.acc1_amount_getter());
            }
            else if (txt_input.Text == account.acc2_pin_getter())
            {
                pin = txt_input.Text;
                amount = account.acc2_amount_getter();
                MessageBox.Show(account.acc2_amount_getter());
            }
            else
            {
                MessageBox.Show("enter pin");
            }
            txt_input.Text = "";
        }

        private void cmd_deny_Click(object sender, EventArgs e)
        {
            txt_input.Text = "";
        }

        private void cmd_withdraw_Click(object sender, EventArgs e)
        {
            float current_amount = float.Parse(txt_input.Text);

            if(current_amount <= float.Parse(amount))
            {
                amount  = $"{ float.Parse(amount) - current_amount}";
                MessageBox.Show($"Withdraw amount : {current_amount}\nTotal Balance : {amount}");
            }
            else
            {
                MessageBox.Show("Balance not enough");
            }
           
        }
    }

}

