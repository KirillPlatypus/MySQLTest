using MySql.Data.MySqlClient;
using MySQL_Test.DB;
using MySQL_Test.Forms;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class Form1 : Form
    {
        DBCommandString dbComponent  = new ConcreteUser("user");
        TableCommand userCommand1 ;

        public Form1()
        {
            InitializeComponent();
            userCommand1 = dbComponent.createTable();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private async Task<string> CheckLogin( Task<List<object>> username, Task<List<object>> email)
        {
            var usernameSelect = from s in await username
                             orderby s
                             select s;
            var emailSelect = from s in await email
                             orderby s
                             select s;


            var yourlogin = CRUDComandMethod.GetUser(textBox1.Text);
            Form3 form3;

            if (yourlogin != null)
            {
                textBox2.Text += "User exist\r\n";

                var yourPhone = DbModelComponent.iphone = DbModelComponent.phoneContext.Phones.Find(yourlogin.phone_id);

                foreach (object login in usernameSelect)
                {
                    if ((string)login == textBox1.Text)
                    {
                        form3 = new Form3();
                        form3.ShowDialog();

                        break;
                    }
                }
                foreach (object login in emailSelect)
                {
                    if ((string)login == textBox1.Text)
                    {
                        form3 = new Form3();
                        form3.ShowDialog();

                        break;
                    }
                }
            }
            Close();
            return textBox2.Text += "User not exist\r\n";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (DbModelComponent.MyConnect != null)
            {

                await CheckLogin(CRUDComandMethod.Select("username", new MySqlCommand(userCommand1.selectCom), DbModelComponent.MyConnect),
                           CRUDComandMethod.Select("email", new MySqlCommand(userCommand1.selectCom), DbModelComponent.MyConnect));

            }
            else
            {

                await CheckLogin(CRUDComandMethod.Select("username", new SQLiteCommand(userCommand1.selectCom), DbModelComponent.LiteConnect),
                           CRUDComandMethod.Select("email", new SQLiteCommand(userCommand1.selectCom), DbModelComponent.LiteConnect));

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            if (DbModelComponent.MyConnect != null)
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
