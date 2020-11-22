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

namespace MySQL_Test.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            YourUsername.Text = DbModelComponent.user.username;
            YourEmail.Text = DbModelComponent.user.email;

            PhonesList.Items.Add( DbModelComponent.iphone.PhoneName);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
