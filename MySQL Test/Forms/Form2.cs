using MySQL_Test.DB;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class Form2 : Form
    {
        WrongFormat wrongFormat;
        DBCommandString userComponent = new ConcreteUser("user");
        TableCommand userCommand1;

        DBCommandString phoneComponent = new ConcretePhone("phone");
        TableCommand phoneCommand1;

        public Form2()
        {
            InitializeComponent();
        }

        private async void SignUp_Click(object sender, EventArgs e)
        {
            DbModelComponent.user.id = DbModelComponent.selectUser.Count + 1;
            DbModelComponent.user.username = EnterName.Text;
            DbModelComponent.user.email = EnterEmail.Text;

            FindPhoneId();

            if (DbModelComponent.user.phone_id == 0 )
            {
                DbModelComponent.iphone.id = DbModelComponent.selectPhone.Count + 1;
                DbModelComponent.user.phone_id = DbModelComponent.selectPhone.Count + 1;

                DbModelComponent.iphone.PhoneName = phoneEnterName.Text;

                phoneCommand1 = phoneComponent.createTable();

                DbModelComponent.phoneContext.Phones.Add(DbModelComponent.iphone);

                await CRUDComandMethod.Command(new SQLiteCommand(phoneCommand1.insertCom), DbModelComponent.LiteConnect);
            }

            userCommand1 = userComponent.createTable();

            DbModelComponent.phoneContext.User.Add(DbModelComponent.user);

            await CRUDComandMethod.Command(new SQLiteCommand(userCommand1.insertCom), DbModelComponent.LiteConnect);

            DbModelComponent.phoneContext.SaveChanges();

            Close();
        }

        private void FindPhoneId()
        {
            for (int phone = 1; phone <= DbModelComponent.selectPhone.Count; phone++)
            {
                var id = DbModelComponent.phoneContext.Phones.Find(phone);

                if (id.PhoneName == phoneEnterName.Text)
                {
                    DbModelComponent.user.phone_id = id.id;
                    break;
                }
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            wrongFormat = new WrongFormat(EnterName);

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
            wrongFormat = new WrongFormat(EnterEmail);

            if(WrongMassege(wrongFormat.TooALong(40), WrongEmail, "Too long email") &&

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

        private void phoneEnterName_TextChanged(object sender, EventArgs e)
        {
            wrongFormat = new WrongFormat(phoneEnterName);

            if (WrongMassege(wrongFormat.TooALong(40), WrongPhoneName, "Too long username") &&

            WrongMassege(wrongFormat.NotNull(), WrongPhoneName, "Username is not to be null"))
            {
                SignUp.Enabled = true;
            }
            else
            {
                SignUp.Enabled = false;
            }

        }
    }
}
