using Polyclinic.Controller;
using Polyclinic.Entity;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class OurDoctors : Form
    {
        private DoctorController doctorController = new DoctorController();
        private int yPosition = 35;

        public OurDoctors()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);

            comboBox1.DataSource = doctorController.loadPositions().Obj;
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form form = new MainMenu();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            clearList();

            yPosition = 35;

            Position selectedPosition = (Position)comboBox1.SelectedItem;

            Response<List<Doctor>> response = doctorController.loadDoctorsByPosition(selectedPosition.Name);

            if (response.errorMessage != null)
            {
                MessageBox.Show(response.errorMessage);
                return;
            }

            List<Doctor> doctors = response.Obj;

            displayDoctors(doctors, selectedPosition);
        }
        private void displayDoctors(List<Doctor> doctors, Position selectedPosition)
        {
            foreach (Doctor doctor in doctors)
            {
                ListBox doctorList = new ListBox();

                doctorList.Items.Add($"Name: {doctor.Name}");
                doctorList.Items.Add($"Position: {selectedPosition.Name}");
                doctorList.Items.Add($"Ward: {doctor.Ward}");
                doctorList.Items.Add($"About doctor: Lorem ipsum dolor sit amet...");

                panel1.Controls.Add(doctorList);

                doctorList.Font = new Font("Candara", 12);
                doctorList.ItemHeight = 20;
                doctorList.Location = new Point(10, yPosition);
                doctorList.Size = new Size(460, 80);
                doctorList.BackColor = Color.LightSteelBlue;
                yPosition += 85;
            }
        }
        private void clearList()
        {
            var listBoxesToRemove = new List<Control>();

            foreach (Control control in panel1.Controls)
            {
                if (control is ListBox)
                {
                    listBoxesToRemove.Add(control);
                }
            }
            foreach (var control in listBoxesToRemove)
            {
                panel1.Controls.Remove(control);
            }

        }
    }
}