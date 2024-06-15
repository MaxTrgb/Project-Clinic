using Polyclinic.Controller;
using Polyclinic.Util;
using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class changeEmail : Form
    {
        private AccountController accountController = new AccountController();

        public changeEmail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Session.account.Id;

            string newEmail = textBox1.Text;

            accountController.changeEmail(newEmail, id);

            Session.account.Email = newEmail;

            this.Close();
        }
    }
}