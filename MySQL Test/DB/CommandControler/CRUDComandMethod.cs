using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MySQL_Test.DB
{
    public static class CRUDComandMethod 
    {
        public static async Task<List<object>> Select(string column, DbCommand command, DbConnection connect)
        {
            List<object> selectList = new List<object>();

            using (var commands = command)
            {
                commands.Connection = connect;

                connect.Open();

                var result = await commands.ExecuteReaderAsync();

                while (result.Read())
                {
                    selectList.Add(result[column]);
                }

                connect.Close();
            }
            return selectList;
        }

        public static async Task Command(DbCommand command, DbConnection connect)
        {
            using (var commands = command)
            {
                commands.Connection = connect;

                connect.Open();
                var result = await commands.ExecuteReaderAsync();
                connect.Close();
            }
        }
        public static user GetUser(string login)
        {
            if (login != "")
            {
                for (int phone = 1; phone <= DbModelComponent.selectUser.Count; phone++)
                {
                    var id = DbModelComponent.phoneContext.User.Find(phone);

                    if (id.username == login || id.email == login)
                    {
                        return DbModelComponent.user = id;
                    }
                }
            }
            return null;
        }
    }
    
}

