using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registerLogin.ATM
{
    public partial class frm_function : Form
    {
        public frm_function()
        {
            InitializeComponent();
        }
        int count = 0;
        public bool strong_pwd()
        {
            string strong_password = txt_password.Text;
            string special_character = "!@#$%^&*|:?_";

            //isDigit
            if (strong_password.Length >= 6)
            {
                for (int i = 0; i < strong_password.Length; i++)
                {
                    if (char.IsDigit(strong_password[i]))
                    {
                        count += 1;
                        MessageBox.Show("Found Digit");
                        break;
                    }
                }

                //upper
                for (int i = 0; i < strong_password.Length; i++)
                {
                    if (char.IsUpper(strong_password[i]))
                    {
                        count += 1;
                        MessageBox.Show("Found Upper");
                        break;
                    }

                }

                //isLower
                for (int i = 0; i < strong_password.Length; i++)
                {
                    if (char.IsLower(strong_password[i]))
                    {
                        count += 1;
                        MessageBox.Show("Found Lower");
                        break;
                    }

                }


                for (int i = 0; i < special_character.Length; i++)
                {
                    for (int j = 0; j < strong_password.Length; j++)
                    {
                        if (special_character[i] == strong_password[j])
                        {
                            count += 1;
                            MessageBox.Show("Found special_character");
                            j = strong_password.Length;
                            i = special_character.Length;
                        }
                    }


                }
            }

            if (count == 4)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Reenter your password");
                txt_password.Clear();
               return false;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (strong_pwd())
            {
                MessageBox.Show("Registeration success");
            }


        }
    }

}
