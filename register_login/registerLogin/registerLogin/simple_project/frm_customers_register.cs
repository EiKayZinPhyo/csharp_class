using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using MySql.Data.MySqlClient;

namespace registerLogin.simple_project
{
    public partial class frm_customers_register : Form
    {
        public frm_customers_register()
        {
            InitializeComponent();
        }

        Connect connect = new Connect();
        MySqlCommand cmd = new MySqlCommand();


        //function
        //1.keyword(public,private,protected) 2. datatype(void,return(int,string,char,float....))
        //3. function name

        /* public bool special_character(string password)
       {
           bool check = false;
           string special_char = "!@#$%^&*|;_-";
           //              0 < 13
           for (int i = 0; i < special_char.Length; i++)
           {
               //              1 < 4
               for (int j = 0; j < password.Length; j++)
               {
                   //                ! == 2
                   if (special_char[i] == password[j])
                   {
                       check  = true;
                       //MessageBox.Show($"found it{password[j]}");
                       i = special_char.Length;
                       j = password.Length;
                   }
                   else
                   {
                       check = false;
                   }
               }
           }

           return check;
       }

       public bool upper_case(string password)
       {
           bool check = false;
           for (int i = 0; i < password.Length; i++)
           {
               //       true
               if (char.IsUpper(password[i]))
               {
                   check = true;
                   break;
               }
               //false
               else
               {
                   check = false;
                   MessageBox.Show("not found");
               }
           }
           return check;

       }

       public bool lower_case(string password)
       {
           bool check = false;
           for (int i = 0; i <  password.Length; i++)
           {
               //       true
               if (char.IsLower(password[i]))
               {
                   check = true;
                   break;
               }
               //false
               else
               {
                   check = false;
                   MessageBox.Show("not found");
               }
           }
           return check;

       }

       public bool digit(string password)
       {
           bool check = false;
           for (int i = 0; i < password.Length; i++)
           {
               //       true
               if (char.IsDigit(password[i]))
               {
                   check = true;
                   break;
               }
               //false
               else
               {
                   check = false;
                   MessageBox.Show("not found");
               }
           }
           return check;

       }*/



        public bool strong_password(string password)
        {

            int count = 0;
            string special_char = "!@#$%^&*~|;_-";

            //password length
          //if(password.Length >= 6)
          //  {
          //      count += 1;
          //  }

            //upper case
            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (password.Length >= 6)
                {
                    count += 1;
                    break;
                }
            }

            //  special_character            0 < 13
            for (int i = 0; i < special_char.Length; i++)
            {
                //              1 < 4
                for (int j = 0; j < password.Length; j++)
                {
                    //                ! == 2
                    if (special_char[i] == password[j])
                    {
                        count += 1;
                        //MessageBox.Show($"found it{password[j]}");
                        i = special_char.Length;
                        j = password.Length;
                    }

                }
            }

          

                //upper case
                for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsUpper(password[i]))
                {
                    count += 1;
                    break;
                }
            }

            //lower case

            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsLower(password[i]))
                {
                    count += 1;
                    break;
                }
            }

            // digit
            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsDigit(password[i]))
                {
                    count += 1;
                    break;
                }
            }

            if(count == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    
    

      

        public static string name, email, password, confirm_password;

        private void frm_customers_register_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            frm_customers_login login = new frm_customers_login();
            login.Show();
           
          
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
           
            name = txt_username.Text;
            email = txt_email.Text;
            password = txt_password.Text;
            confirm_password = txt_confirm_password.Text;
            

            // modified function call in signup button
     
            //MessageBox.Show($"{strong_password(password)}");

            if (name == "" || email == "" || password == "" || confirm_password == "")
            {
                MessageBox.Show("please enter name and password");
            }
            else
            {
                if (password == confirm_password &&  strong_password(password)
)
                {
                    cmd = connect.conn.CreateCommand();
                    cmd.CommandText = "insert into user_info(name,email,password,confirm_password)" +
                        "values('"+name+"' ,'"+email+"' ,'"+password+"' ,'"+confirm_password+"')";

                    cmd.ExecuteNonQuery();
                    connect.conn.Close();
                    this.Hide();
                    frm_customers_login fcl = new frm_customers_login();
                    fcl.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password must be the same");
                }
               
            }
        }
    }
}
