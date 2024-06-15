using Polyclinic.Controller;
using Polyclinic.Entity;
using Polyclinic.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class MakeAppointment : Form
    {
        private DoctorController doctorController = new DoctorController();
        private AppointmentController appointmentController = new AppointmentController();


        public MakeAppointment()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker1.MinDate = DateTime.Now;

            textBox1.Text = Session.account.Name;
            textBox2.Text = Session.account.Email;

            List<Position> positions = doctorController.loadPositions().Obj;

            comboBox1.DataSource = positions;
            comboBox1.DisplayMember = "Name";

            comboBox2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
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
            DateTime selectedDateTime = dateTimePicker1.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm");

            Doctor selectedDoctor = comboBox2.SelectedItem as Doctor;

            if (selectedDoctor != null)
            {
                appointmentController.makeAppointment(formattedDateTime, selectedDoctor.Id, selectedDoctor.Ward, Session.account.Id);

                MessageBox.Show("Your appointment is scheduled!");
            }
            else
            {
                MessageBox.Show("Please select a valid doctor.");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}