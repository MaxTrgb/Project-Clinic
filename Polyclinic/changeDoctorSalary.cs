using Polyclinic.Controller;
using Polyclinic.Util;
using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class changeDoctorSalary : Form
    {
        private DoctorController doctorController = new DoctorController();
        public changeDoctorSalary()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal newDoctorSalary))
            {
                int id = Session.accountToChange.Id;
                doctorController.changeSalary(newDoctorSalary, id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid salary.");
            }
        }
    }
}
