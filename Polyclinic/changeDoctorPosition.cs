using Polyclinic.Controller;
using Polyclinic.Entity;
using Polyclinic.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class changeDoctorPosition : Form
    {
        private DoctorController doctorController = new DoctorController();

        public changeDoctorPosition()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadPositions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Position newDoctorPosition = comboBox1.SelectedItem as Position;

            if (newDoctorPosition == null)
            {
                MessageBox.Show("Please select a valid position.");
                return;
            }

            int newPositionId = newDoctorPosition.Id;
            int docId = Session.accountToChange.Id;

            Response<Doctor> response = doctorController.changePosition(newPositionId, docId);

            if (response.errorMessage != null)
            {
                MessageBox.Show(response.errorMessage);
            }
            else
            {
                MessageBox.Show("Position changed successfully!");
                this.Close();
            }
        }


        private void loadPositions()
        {
            Response<List<Position>> response = doctorController.loadPositions();

            if (response.errorMessage != null)
            {
                MessageBox.Show(response.errorMessage);
                return;
            }

            comboBox1.DataSource = response.Obj;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }
    }
}