using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQL_Test.DB;

namespace MySQL_Test
{
    static class Program
    {
        public static MySqlConnection MyConnector;
        public static  SQLiteConnection LiteConnector;
        
        internal static PhoneContext phoneContext;

        internal static phone iphone = new phone();
        internal static user user = new user();

        internal static List<user> selectUser;
        internal static List<phone> selectPhone ;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                phoneContext = new PhoneContext();

                selectUser = phoneContext.User.ToList();
                selectPhone = phoneContext.Phones.ToList();

                MyConnector = new MySqlConnection("server = 127.0.0.1; user id = root; password=0013669;database=phones");
                LiteConnector = new SQLiteConnection("Data Source=C:/Users/1/source/repos/MySQL Test/MySQL Test/phones.db");
            }
            catch (InvalidOperationException)
            {
                LiteConnector = new SQLiteConnection("Data Source=C:/Users/1/source/repos/MySQL Test/MySQL Test/phones.db");
            }

            Application.Run(new Form1());
        }

        public static List<object> Select( string column, DbCommand command)
        {
            List<object> selectList = new List<object>();

            using (var commands = command)
            {
                MyConnector.Open();

                var result = command.ExecuteReader();

                while (result.Read())
                {
                    selectList.Add(result[column]);
                }

                MyConnector.Close();
            }
            return selectList;
        }

    }
}
