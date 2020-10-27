using System;
using System.Windows.Forms;
using MySQL_Test.DB;

namespace MySQL_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (phone phone in Program.selectEF)
            {

                textBox1.Text += $"{phone.id} " +
                    $"{phone.PhoneName} " +
                    $"\r\n";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
