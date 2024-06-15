using Polyclinic.Controller;
using Polyclinic.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class AddDoctor : Form
    {
        private DoctorController doctorController = new DoctorController();
        private List<Position> positions = new List<Position>();

        public AddDoctor()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            this.Load += new EventHandler(MouseHoverEvent);

            Response<List<Position>> response = doctorController.loadPositions();

            comboBox1.DataSource = response.Obj;
            comboBox1.DisplayMember = "Name";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool hasEmptyFields = checkEpmtyFields();

            if (hasEmptyFields)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                string name = textBox1.Text;

                Position selectedPosition = comboBox1.SelectedItem as Position;

                if (selectedPosition == null)
                {
                    MessageBox.Show("Please select a valid position.");
                    return;
                }

                int position_id = selectedPosition.Id;

                string salary = textBox3.Text;

                string ward = textBox4.Text;

                Response<Doctor> response = doctorController.addDoctor(name, position_id, salary, ward);

                if (response.errorMessage != null)
                {
                    MessageBox.Show(response.errorMessage);
                }
                else
                {
                    MessageBox.Show("Doctor successfully created!");
                    textBox1.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new DoctorsManagment();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
        private void MouseHoverEvent(object sender, EventArgs e)
        {
            textBox1.MouseHover += textBox_MouseHover;
            textBox3.MouseHover += textBox_MouseHover;
            textBox4.MouseHover += textBox_MouseHover;
        }
        public void textBox_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.BackColor == Color.Red)
            {
                textBox.BackColor = SystemColors.Window;
            }
        }

        private bool checkEpmtyFields()
        {
            bool hasEmptyFields = false;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.BackColor = Color.Red;
                hasEmptyFields = true;
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.BackColor = Color.Red;
                hasEmptyFields = true;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.BackColor = Color.Red;
                hasEmptyFields = true;
            }

            return hasEmptyFields;
        }
    }
}