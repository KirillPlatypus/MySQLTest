using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MySQL_Test.DB;

namespace MySQL_Test
{


    public class UserCommand
    {
        public static void Insert(SQLiteConnection connect, user user)
        {
            using (SQLiteCommand command = new SQLiteCommand($"INSERT INTO user (id, username, email, phone_id)" +
                                                            $" VALUES ('{user.id}', '{user.username}', '{user.email}', '{user.phone_id}') ",
                                                            connect))
            {
                OpenClose(connect, command);
            }
        }

        public static void Update(SQLiteConnection connect, user user, int id)
        {
            using (SQLiteCommand command = new SQLiteCommand($"UPDATE user SET (id = {user.id}," +
                $" username = {user.username}," +
                $" email = {user.email}," +
                $" phone_id = {user.phone_id}) WHERE id = {id}", connect))
            {
                OpenClose(connect, command);
            }
        }

        public static void Delete(SQLiteConnection connect, int id)
        {
            using (SQLiteCommand command = new SQLiteCommand($"DELETE FROM user WHERE id = {id}", connect))
            {
                OpenClose(connect, command);
            }
        }

        internal static void OpenClose(SQLiteConnection connect, SQLiteCommand command)
        {
            connect.Open();
            var result = command.ExecuteReader();
            connect.Close();
        }

    }



    public static class PhonesCommand 
    {
        public static void Insert(SQLiteConnection connect, phone phone)
        {
            using (SQLiteCommand command = new SQLiteCommand($"INSERT INTO phone (id, PhoneName)" +
                                                             $" VALUES ('{phone.id}', '{phone.PhoneName}') ",
                                                            connect))
            {
                OpenClose(connect, command);
            }
        }

        public static void Update(SQLiteConnection connect, phone phone, int id)
        {
            using (SQLiteCommand command = new SQLiteCommand($"UPDATE user SET (id = {phone.id}," +
                $" username = {phone.PhoneName}," +
                $" WHERE id = {id}", connect))
            {
                OpenClose(connect, command);
            }
        }

        public static void Delete(SQLiteConnection connect, int id)
        {
            using (SQLiteCommand command = new SQLiteCommand($"DELETE FROM phone WHERE id = {id}", connect))
            {
                OpenClose(connect, command);
            }
        }

        internal static void OpenClose(SQLiteConnection connect, SQLiteCommand command)
        {
            connect.Open();
            var result = command.ExecuteReader();
            connect.Close();
        }

    }


}
