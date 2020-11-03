using MySQL_Test.DB;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class Form2 : Form
    {
        WrongFormat wrongFormat;
        DBComponent dbComponent;
        
        public Form2()
        {
            InitializeComponent();
            DbModelComponent.table = "phone";
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            DbModelComponent.user.id = Program.selectUser.Count + 1;
            DbModelComponent.user.username = EnterName.Text;
            DbModelComponent.user.email = EnterEmail.Text;


            for (int phone = 1; phone < Program.selectUser.Count; phone++)
            {
                var id = Program.phoneContext.Phones.Find(phone);
                if (id.PhoneName == phoneEnterName.Text)
                {
                    DbModelComponent.user.phone_id = id.id;
                    break;
                }
            }

            if(DbModelComponent.user.phone_id == 0 )
            {
                DbModelComponent.user.phone_id = DbModelComponent.iphone.id = Program.selectPhone.Count + 1;
                DbModelComponent.iphone.PhoneName = phoneEnterName.Text;
            }
            dbComponent = new DBComponent();

            Program.phoneContext.User.Add(DbModelComponent.user);
            Program.phoneContext.Phones.Add(DbModelComponent.iphone);

            DBComponent.Command(new SQLiteCommand(dbComponent.insertComUser, DBComponent.LiteConnect), DBComponent.LiteConnect);
            DBComponent.Command(new SQLiteCommand(dbComponent.insertComPhone, DBComponent.LiteConnect), DBComponent.LiteConnect);

            Program.phoneContext.SaveChanges();

            Close();
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

        private void phoneEnterName_TextChanged(object sender, EventArgs e)
        {
            wrongFormat = new WrongFormat(phoneEnterName);

            if (WrongMassege(wrongFormat.TooALong(15), WrongPhoneName, "Too long username") &&

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
