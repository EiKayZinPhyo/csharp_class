using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registerLogin
{
    public class Connect
    {
        public MySqlConnection conn;
        public Connect()
        {
            string db_info = "server=localhost;port=3307;uid=root;pwd=;database=csharp;SslMode=none;convert zero datetime=True";
            conn = new MySqlConnection(db_info);
            conn.Open();
            MessageBox.Show("open");
        }
    }
}
