using Polyclinic.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            if(Session.account.role_id == 2)
            {
                button5.Visible = true;               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new MyAccount();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new OurDoctors();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new MakeAppointment();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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
}
