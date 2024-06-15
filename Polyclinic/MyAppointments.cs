using Polyclinic.Controller;
using Polyclinic.Entity;
using Polyclinic.Util;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class MyAppointments : Form
    {
        private AppointmentController appointmentController = new AppointmentController();

        private DoctorController doctorController = new DoctorController();

        private List<Appointment> appointments;

        public MyAppointments()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);

            int id = Session.account.Id;

            appointments = appointmentController.loadAppointmentsById(id).Obj;

            loadAppointments(appointments);
        }
        private void loadAppointments(List<Appointment> appointments)
        {
            int yPosition = 35;

            foreach (Appointment appointment in appointments)
            {
                ListBox appointmentsList = new ListBox();

                Response<Doctor> response = doctorController.getDoctorById(appointment.doctor_id);

                Doctor doctor = response.Obj;

                appointmentsList.Items.Add($"ID: {appointment.id}");
                appointmentsList.Items.Add($"Date: {appointment.date}");
                appointmentsList.Items.Add($"Doctor: {doctor.Name}");
                appointmentsList.Items.Add($"Ward: {appointment.ward}");

                panel1.Controls.Add(appointmentsList);

                appointmentsList.Font = new Font("Candara", 12);
                appointmentsList.ItemHeight = 20;
                appointmentsList.Location = new Point(10, yPosition);
                appointmentsList.Size = new Size(460, 80);
                appointmentsList.BackColor = Color.LightSteelBlue;
                yPosition += 85;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form form = new MyAccount();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Close();
        }
    }
}