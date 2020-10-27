using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySQL_Test.DB;
using MySqlConnector;

namespace MySQL_Test
{
    static class Program
    {
        //internal static  MySqlConnection connector = new MySqlConnection("server = 127.0.0.1; user id = root; password=0013669;database=phones");
        
        internal static PhoneContext phoneContext = new PhoneContext();
        internal static phone iphone = new phone();
        internal static List<phone> selectEF = phoneContext.Phones.ToList();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //phoneContext.Phones.Add(iphone);
            //phoneContext.SaveChanges();

            Application.Run(new Form1());
        }
    }
}
