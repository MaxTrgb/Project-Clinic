using Polyclinic.Controller;
using Polyclinic.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class AccountManagment : Form
    {
        AccountController accountController = new AccountController();
        private List<Account> accounts = new List<Account>();

        public AccountManagment()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, 204, 212, 230);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            loadAccounts();
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
        private void setAsAdmnistratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Account> response = accountController.getAccountById(id);

                Account account = response.Obj;

                if (account != null)
                {
                    accountController.setAdmin(id);
                    MessageBox.Show("Account " + account.Name + " has administrator rights now!");
                    loadAccounts();
                }
                else
                {
                    MessageBox.Show("Account not found");
                }
            }
            else
            {
                MessageBox.Show("No account selected. Please select account ID.");
            }
        }

        private void removeAdministratorRightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Account> response = accountController.getAccountById(id);

                Account account = response.Obj;

                if (account != null)
                {
                    accountController.removeAdmin(id);
                    MessageBox.Show("Account " + account.Name + " doesnt have administrator rights now!");
                    loadAccounts();
                }
                else
                {
                    MessageBox.Show("Account not found");
                }

            }
            else
            {
                MessageBox.Show("No account selected. Please select account ID.");
            }
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                Response<Account> response = accountController.getAccountById(id);

                Account account = response.Obj;

                if (account != null)
                {
                    accountController.deleteAccount(id);
                    MessageBox.Show("Account " + account.Name + " deleted successfully!");

                    loadAccounts();
                }
                else
                {
                    MessageBox.Show("Account not found");
                }
            }
            else
            {
                MessageBox.Show("No account selected. Please select account ID.");
            }
        }
        private void loadAccounts()
        {
            Response<List<Account>> response = accountController.getAllAccounts();

            if (response.Obj != null)
            {
                dataGridView1.DataSource = response.Obj;
            }
            else
            {
                MessageBox.Show(response.errorMessage);
            }
        }
    }
}