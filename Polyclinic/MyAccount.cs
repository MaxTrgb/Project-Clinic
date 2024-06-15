using Polyclinic.Controller;
using Polyclinic.Entity;
using Polyclinic.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class MyAccount : Form
    {
        private AccountController accountController = new AccountController();
        public MyAccount()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            loadAccount();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new MainMenu();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form form = new changeName())
            {
                form.ShowDialog();
            }

            loadAccount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form form = new changeEmail())
            {
                form.ShowDialog();
            }

            loadAccount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form form = new changePassword())
            {
                form.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new MyAppointments();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void loadAccount()
        {
            int id = Session.account.Id;

            Account account = accountController.getAccountById(id).Obj;

            label1.Text = account.Id.ToString();
            label2.Text = account.Name;
            label3.Text = account.Email;
        }
    }
}