using MySql.Data.MySqlClient;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class Form1 : Form
    {
        private MySqlCommand MyCommand;
        private SQLiteCommand LiteCommand;

        public Form1()
        {
            InitializeComponent();

            var selectCommand = $"SELECT * FROM user";

            MyCommand = new MySqlCommand(selectCommand, Program.MyConnector);
            LiteCommand = new SQLiteCommand(selectCommand, Program.LiteConnector);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CheckUsername(string username, string email)
        {
            if (textBox1.Text == username || textBox1.Text == email)
            {

                textBox2.Text += "exist \r\n";
            }
            else
            {
                textBox2.Text += "user not exist \r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.MyConnector != null)
            {
                for (int i = 0; i < Program.Select("id", MyCommand).Count; i++)
                {
                    CheckUsername((string)Program.Select("username", MyCommand)[i],
                                  (string)Program.Select("email", MyCommand)[i]);
                }
            }
            else
            {
                for (int i = 0; i < Program.Select("id", LiteCommand).Count; i++)
                {
                    CheckUsername((string)Program.Select("username", LiteCommand)[i],
                                  (string)Program.Select("email", LiteCommand)[i]);
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            if (Program.MyConnector != null)
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
