using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Test.DB
{
    public static class DbModelComponent
    {
        internal static phone iphone = new phone();
        internal static user user = new user();

        public static string table;

        public static int Id;

    }

    public class DBComponent
    {
        public static MySqlConnection MyConnect;
        public static SQLiteConnection LiteConnect;

        public readonly string selectCom = $"SELECT * FROM {DbModelComponent.table};";

        public readonly string updateComUser = $"UPDATE user SET (id = {DbModelComponent.iphone.id}," +
                                                  $" PhoneName = {DbModelComponent.iphone.PhoneName}," +
                                                  $" WHERE id = {DbModelComponent.Id};";

        public readonly string insertComUser = $"INSERT INTO user(id, username, email, phone_id)" +
                                                  $" VALUES ('{DbModelComponent.user.id}', '{DbModelComponent.user.username}', '{DbModelComponent.user.email}', '{DbModelComponent.user.phone_id}');";

        public readonly string insertComPhone = $"INSERT INTO phone(id, PhoneName)" +
                                                  $" VALUES ('{DbModelComponent.iphone.id}', '{DbModelComponent.iphone.PhoneName}');";

        public readonly string deleteCom = $"DELETE FROM {DbModelComponent.table} WHERE id = {DbModelComponent.Id};";


        public static List<object> Select(string column, DbCommand command, DbConnection connect)
        {
            List<object> selectList = new List<object>();

            using (var commands = command)
            {
                connect.Open();

                var result = commands.ExecuteReader();

                while (result.Read())
                {
                    selectList.Add(result[column]);
                }

                connect.Close();
            }
            return selectList;
        }
        public static void Command(DbCommand command, DbConnection connect, int id)
        {
            DbModelComponent.Id = id;
            using (var commands = command)
            {
                connect.Open();
                var result = commands.ExecuteReader();
                connect.Close();
            }
        }
        public static void Command(DbCommand command, DbConnection connect)
        {
            using (var commands = command)
            {
                connect.Open();
                var result = commands.ExecuteReader();
                connect.Close();
            }
        }
    }
}
