using MySql.Data.MySqlClient;
using MySQL_Test.DB;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class Form1 : Form
    {
        DBComponent dbComponent;

        public Form1()
        {
            InitializeComponent();
            DbModelComponent.table = "user";

            dbComponent = new DBComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private string CheckLogin(List<object> username, List<object> email)
        {
            var usernameSelect = from s in username
                             orderby s
                             select s;
            var emailSelect = from s in email
                             orderby s
                             select s;

            foreach (object login in usernameSelect)
            {
                if ((string)login == textBox1.Text)
                    return textBox2.Text += "User exist\r\n ";
            }
            foreach (object login in emailSelect)
            {
                if ((string)login == textBox1.Text)
                    return textBox2.Text += "User exist\r\n ";
            }
            return textBox2.Text += "User not exist\r\n ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DBComponent.MyConnect != null)
            {

                CheckLogin(DBComponent.Select("username", new MySqlCommand(dbComponent.selectCom, DBComponent.MyConnect), DBComponent.MyConnect),
                               DBComponent.Select("email", new MySqlCommand(dbComponent.selectCom, DBComponent.MyConnect), DBComponent.MyConnect));

            }
            else
            {

                CheckLogin(DBComponent.Select("username", new SQLiteCommand(dbComponent.selectCom, DBComponent.LiteConnect), DBComponent.LiteConnect),
                              DBComponent.Select("email", new SQLiteCommand(dbComponent.selectCom, DBComponent.LiteConnect), DBComponent.LiteConnect));

            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            if (DBComponent.MyConnect != null)
            {
                dlg.ShowDialog();
            }
            else
            {
                textBox2.Text += "Now we don`t signing up you, sorry";
            }
        }
    }
}
