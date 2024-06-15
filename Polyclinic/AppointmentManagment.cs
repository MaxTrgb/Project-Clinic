using Polyclinic.Controller;
using Polyclinic.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class AppointmentManagment : Form
    {
        private AppointmentController appointmentController = new AppointmentController();

        public AppointmentManagment()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadAppointments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AdminMenu();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Appointment> appointment = appointmentController.getAppointmentById(id);

                if (appointment != null)
                {
                    appointmentController.deleteAppointment(id);
                    MessageBox.Show("Appointment " + id + " deleted successfully!");
                    loadAppointments();
                }
                else
                {
                    MessageBox.Show("Appointment not found");
                }
            }
            else
            {
                MessageBox.Show("No Appointment selected. Please select Appointment ID.");
            }
        }
        private void loadAppointments()
        {
            List<Appointment> appointments = appointmentController.loadAppointments().Obj;
            dataGridView1.DataSource = appointments;
        }
    }
}