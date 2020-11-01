using MySQL_Test.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class Form2 : Form
    {
        WrongFormat wrongFormat;

        public Form2()
        {
            InitializeComponent();

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Program.user.id = Program.selectUser.Count + 1;
            Program.user.username = textBox1.Text;
            Program.user.email = textBox2.Text;
            Program.user.phone_id = 2;

            Program.phoneContext.User.Add(Program.user);

            Program.phoneContext.SaveChanges();

            UserCommand.Insert(Program.LiteConnector, Program.user);

            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            wrongFormat = new WrongFormat(textBox1);

            if (WrongMassege(wrongFormat.TooALong(15), WrongName, "Too long username") &&

            WrongMassege(wrongFormat.NotNull(), WrongName, "Username is not to be null"))
            {
                SignUp.Enabled = true;
            }
            else
            {
                SignUp.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            wrongFormat = new WrongFormat(textBox2);

            if(WrongMassege(wrongFormat.TooALong(25), WrongEmail, "Too long email") &&

            WrongMassege(wrongFormat.NotNull(), WrongEmail, "Email is not to be null"))
            {
                SignUp.Enabled = true;
            }
            else
            {
                SignUp.Enabled = false;
            }
        }

        private bool WrongMassege(bool wrongFormat, Label WrongMassegeBox, string Massege)
        {
            if (wrongFormat)
            {
                return true;
            }
            else
            {
                WrongMassegeBox.Text = Massege;
                return false;
            }

        }
    }
}
