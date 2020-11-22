using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQL_Test.DB;

namespace MySQL_Test
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                DbModelComponent.phoneContext = new PhoneContext();

                DbModelComponent.selectUser = DbModelComponent.phoneContext.User.ToList();
                DbModelComponent.selectPhone = DbModelComponent.phoneContext.Phones.ToList();

                DbModelComponent.MyConnect = new MySqlConnection("server = 127.0.0.1; user id = root; password=0013669;database=phones");
                DbModelComponent.LiteConnect = new SQLiteConnection("Data Source=C:/Users/1/source/repos/MySQL Test/MySQL Test/phones.db");
            }
            catch (Exception)
            {
                DbModelComponent.LiteConnect = new SQLiteConnection("Data Source=C:/Users/1/source/repos/MySQL Test/MySQL Test/phones.db");
            }

            Application.Run(new Form1());
        }
    }
}
