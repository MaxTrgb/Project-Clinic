using Polyclinic.Controller;
using Polyclinic.Util;
using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class changeDoctorName : Form
    {
        private DoctorController doctorController = new DoctorController();
        public static string newDoctorName;

        public changeDoctorName()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newDoctorName = textBox1.Text;

            int id = Session.accountToChange.Id; 

            doctorController.changeName(newDoctorName, id);

            this.Close();
        }
    }
}
