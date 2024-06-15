using Polyclinic.Controller;
using Polyclinic.Entity;
using Polyclinic.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class DoctorsManagment : Form
    {
        private DoctorController doctorController = new DoctorController();

        private List<Doctor> doctors = new List<Doctor>();

        public DoctorsManagment()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doctors = doctorController.loadDoctors().Obj;
            dataGridView1.DataSource = doctors;
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
        private void changeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Doctor> response = doctorController.getDoctorById(id);

                if (response.errorMessage != null)
                {
                    MessageBox.Show(response.errorMessage);
                    return;
                }

                Session.accountToChange = response.Obj;

                Form form = new changeDoctorName();
                form.ShowDialog();

                RefreshDoctorData();
            }
            else
            {
                MessageBox.Show("No doctor selected. Please select a doctor.");
            }
        }
        private void changePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Doctor> response = doctorController.getDoctorById(id);

                if (response.errorMessage != null)
                {
                    MessageBox.Show(response.errorMessage);
                    return;
                }

                Session.accountToChange = response.Obj;

                Form form = new changeDoctorPosition();
                form.ShowDialog();

                RefreshDoctorData();
            }
            else
            {
                MessageBox.Show("No account selected. Please select account ID.");
            }
        }

        private void changeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Doctor> response = doctorController.getDoctorById(id);

                if (response.errorMessage != null)
                {
                    MessageBox.Show(response.errorMessage);
                    return;
                }

                Session.accountToChange = response.Obj;

                Form form = new changeDoctorSalary();
                form.ShowDialog();

                RefreshDoctorData();
            }
            else
            {
                MessageBox.Show("No account selected. Please select account ID.");
            }
        }
        private void RefreshDoctorData()
        {
            var response = doctorController.loadDoctors();
            if (response.errorMessage != null)
            {
                MessageBox.Show(response.errorMessage);
                return;
            }

            var doctors = response.Obj;
            if (doctors == null || doctors.Count == 0)
            {
                MessageBox.Show("No doctors found.");
                return;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctors;
        }

        private void changeWardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Doctor> response = doctorController.getDoctorById(id);

                if (response.errorMessage != null)
                {
                    MessageBox.Show(response.errorMessage);
                    return;
                }

                Session.accountToChange = response.Obj;

                Form form = new changeDoctorWard();
                form.ShowDialog();

                RefreshDoctorData();
            }
            else
            {
                MessageBox.Show("No account selected. Please select account ID.");
            }
        }

        private void removeDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Doctor> response = doctorController.deleteDoctor(id);

                if (response.Obj == null)
                {
                    MessageBox.Show("Doctor " + id + " removed!");
                }
                else
                {
                    MessageBox.Show(response.errorMessage);
                }

                RefreshDoctorData();
            }
            else
            {
                MessageBox.Show("No account selected. Please select account ID.");
            }

        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AddDoctor();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Close();

            RefreshDoctorData();
        }
    }
}