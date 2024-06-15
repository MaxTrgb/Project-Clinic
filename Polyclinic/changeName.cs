using Polyclinic.Controller;
using Polyclinic.Util;
using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class changeName : Form
    {
        private AccountController accountController = new AccountController();
        public static string newName;

        public changeName()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newName = textBox1.Text;
            int id = Session.account.Id; 
            accountController.changeName(newName, id);            
            Session.account.Name = newName;
            this.Close();
        }
    }
}