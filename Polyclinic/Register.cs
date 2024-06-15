using Polyclinic.Controller;
using Polyclinic.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class Register : Form
    {
        private AccountController accountController = new AccountController();

        public Register()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);

            this.Load += new EventHandler(MouseHoverEvent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasEmptyFields = false;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.BackColor = Color.Red;
                hasEmptyFields = true;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.BackColor = Color.Red;
                hasEmptyFields = true;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.BackColor = Color.Red;
                hasEmptyFields = true;
            }

            if (hasEmptyFields)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                string name = textBox1.Text;
                string email = textBox2.Text;
                string password = textBox3.Text;

                Response<Account> response = accountController.createNewAccount(name, email, password);


                if (response.errorMessage != null)
                {
                    MessageBox.Show(response.errorMessage);
                }
                else
                {
                    MessageBox.Show("Account successfully created!");
                    Form form = new Form1();
                    form.StartPosition = FormStartPosition.Manual;
                    form.Height = this.Height;
                    form.Width = this.Width;
                    form.Location = this.Location;
                    form.Show();
                    this.Hide();
                }
            }
        }
        public void textBox_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.BackColor == Color.Red)
            {
                textBox.BackColor = SystemColors.Window;
            }
        }

        private void MouseHoverEvent(object sender, EventArgs e)
        {
            textBox1.MouseHover += textBox_MouseHover;
            textBox2.MouseHover += textBox_MouseHover;
            textBox3.MouseHover += textBox_MouseHover;
        }
    }
}