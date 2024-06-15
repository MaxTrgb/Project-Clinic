using Polyclinic.Controller;
using Polyclinic.Util;
using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class changeDoctorWard : Form
    {
        private DoctorController doctorController = new DoctorController();

        public changeDoctorWard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newDoctorWard = textBox1.Text;

            if (string.IsNullOrWhiteSpace(newDoctorWard))
            {
                MessageBox.Show("Please enter a valid ward.");
                return;
            }

            int id = Session.accountToChange.Id;

            doctorController.changeWard(newDoctorWard, id);

            this.Close();
        }
    }
}
