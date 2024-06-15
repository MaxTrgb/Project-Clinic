using Polyclinic.Controller;
using Polyclinic.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class QuickAppointment : Form
    {
        private DoctorController doctorController = new DoctorController();
        private AppointmentController appointmentController = new AppointmentController();
        private AccountController accountController = new AccountController();

        public QuickAppointment()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker1.MinDate = DateTime.Now;
            comboBox2.Enabled = false;

            List<Position> positions = doctorController.loadPositions().Obj;
            comboBox1.DataSource = positions;
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                comboBox2.Enabled = true;

                Position selectedPosition = (Position)comboBox1.SelectedItem;

                Response<List<Doctor>> response = doctorController.loadDoctorsByPosition(selectedPosition.Name);

                if (response.errorMessage != null)
                {
                    MessageBox.Show(response.errorMessage);
                    return;
                }

                List<Doctor> doctors = response.Obj;

                comboBox2.DataSource = doctors;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker1.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm");

            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = "passworNeedChange";

            Doctor selectedDoctor = comboBox2.SelectedItem as Doctor;

            Response<int> response = appointmentController.createAccountAndAppointment(formattedDateTime, 
                selectedDoctor.Id, selectedDoctor.Ward, name, email, password);

            if (response.errorMessage != null)
            {
                MessageBox.Show(response.errorMessage);
                return;
            }
            MessageBox.Show("Request successfully completed");


            Form form = new Form1();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Close();
        }
    }
}