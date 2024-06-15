using Polyclinic.Controller;
using Polyclinic.Util;
using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class changePassword : Form
    {
        private AccountController accountController = new AccountController();

        public changePassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != Session.account.Password)
            {
                MessageBox.Show("Wrong password");
                return;
            }
            else
            {                
                int id = Session.account.Id;

                string newPass = textBox2.Text;

                accountController.changePass(newPass, id);

                Session.account.Password = newPass;

                MessageBox.Show("Password changed successfully");

                this.Close();
            }
        }
    }
}