using Polyclinic.Controller;
using Polyclinic.Entity;
using Polyclinic.Util;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Polyclinic
{
    public partial class Form1 : Form
    {
        private AccountController accountController = new AccountController();

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            Response<Account> responseAccount = accountController.logIn(email, password);

            if (responseAccount.errorMessage != null)
            {
                MessageBox.Show(responseAccount.errorMessage);
                return;
            }

            Account account = responseAccount.Obj;
            Session.account = account;

            if (account.role_id == 1)
            {
                Form form = new MainMenu();
                form.StartPosition = FormStartPosition.Manual;
                form.Height = this.Height;
                form.Width = this.Width;
                form.Location = this.Location;
                form.Show();
                this.Hide();
            }
            else
            {
                Form form = new AdminMenu();
                form.StartPosition = FormStartPosition.Manual;
                form.Height = this.Height;
                form.Width = this.Width;
                form.Location = this.Location;
                form.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new QuickAppointment();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
    }
}
