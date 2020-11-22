using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SQLite;

namespace MySQL_Test.DB
{
    public static class DbModelComponent
    {

        public static MySqlConnection MyConnect;
        public static SQLiteConnection LiteConnect;

        internal static PhoneContext phoneContext;

        internal static List<user> selectUser;
        internal static List<phone> selectPhone;

        internal static phone iphone = new phone();
        internal static user user = new user();

    }



    public abstract class DBCommandString
    {

        public abstract string table { get; set; }

        public DBCommandString(string table)
        {
            this.table = table;
        }
        public abstract TableCommand createTable();

    }
    public abstract class DBUnioneCommandString
    {

        public abstract string table { get; set; }

        public DBUnioneCommandString(string table)
        {
            this.table = table;
        }
        public abstract UnioneTableCommand createUnioneTable();

    }

    public class ConcreteUser: DBCommandString
    {
        public override string table { get; set; }

        public ConcreteUser(string table) :base(table)
        {
            this.table = table;
        }

        public override TableCommand createTable()
        {
            return new UserCommand();
        }
    }

    public class ConcretePhone : DBCommandString
    {
        public override string table { get; set; }

        public ConcretePhone(string table) : base(table)
        {
            this.table = table;
        }

        public override TableCommand createTable()
        {
            return new PhoneCommand();
        }
    }

    public interface TableCommand
    {
          string selectCom { get; }

          string updateCom { get; }

          string insertCom { get; }

          string deleteCom { get; }

    }
    public interface UnioneTableCommand
    {
          string joinUserPhone { get; }
    }

    public class UserCommand : TableCommand
    {

        public string selectCom { get; } = $"SELECT * FROM user;";

        public string insertCom { get; } = $"INSERT INTO user(id, username, email, phone_id)" +
                                                    $" VALUES ('{DbModelComponent.user.id}', '{DbModelComponent.user.username}', '{DbModelComponent.user.email}', '{DbModelComponent.user.phone_id}');";

        public string updateCom {get;} = $"UPDATE user SET (id = {DbModelComponent.iphone.id}," +
                                                  $" PhoneName = {DbModelComponent.iphone.PhoneName}," +
                                                  $" WHERE id = {DbModelComponent.user.id};";

        public string deleteCom {get; } = $"DELETE FROM user WHERE id = {DbModelComponent.user.id};";

    }
    public class PhoneCommand : TableCommand
    {

        public string selectCom { get; } = $"SELECT * FROM phone;";

        public string insertCom { get; } = $"INSERT INTO phone(id, PhoneName)" +
                                                   $" VALUES ('{DbModelComponent.iphone.id}', '{DbModelComponent.iphone.PhoneName}');";

        public string updateCom { get; } = $"UPDATE phone SET (id = {DbModelComponent.iphone.id}," +
                                                    $" PhoneName = {DbModelComponent.iphone.PhoneName}," +
                                                    $" WHERE id = {DbModelComponent.iphone.id};";

        public string deleteCom{ get; } = $"DELETE FROM phone WHERE id = {DbModelComponent.iphone.id};";

    }
    public class UniteTableCommand : UnioneTableCommand
    {
        public string joinUserPhone { get; } = "select u.id,u.username, u.email, ph.PhoneName from phones.user u " +
                                               "left join phones.phone ph on u.phone_id = ph.id; ";
    }
}
