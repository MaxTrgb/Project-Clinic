namespace Polyclinic
{
    partial class AppointmentManagment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentManagment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorsexaminationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.my_databaseDataSet = new Polyclinic.my_databaseDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsexaminationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsexaminationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new Polyclinic.my_databaseDataSetTableAdapters.appointmentTableAdapter();
            this.mydatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctors_examinationsTableAdapter = new Polyclinic.my_databaseDataSetTableAdapters.doctors_examinationsTableAdapter();
            this.mydatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.my_databaseDataSet1 = new Polyclinic.my_databaseDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsexaminationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_databaseDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsexaminationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsexaminationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydatabaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(150, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 400);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 370);
            this.dataGridView1.TabIndex = 2;
            // 
            // doctorsexaminationsBindingSource2
            // 
            this.doctorsexaminationsBindingSource2.DataMember = "doctors_examinations";
            this.doctorsexaminationsBindingSource2.DataSource = this.my_databaseDataSet;
            // 
            // my_databaseDataSet
            // 
            this.my_databaseDataSet.DataSetName = "my_databaseDataSet";
            this.my_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(427, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointmentToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.tableToolStripMenuItem.Text = "Appointment";
            // 
            // addAppointmentToolStripMenuItem
            // 
            this.addAppointmentToolStripMenuItem.Name = "addAppointmentToolStripMenuItem";
            this.addAppointmentToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addAppointmentToolStripMenuItem.Text = "Delete appointment";
            this.addAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentToolStripMenuItem_Click);
            // 
            // doctorsexaminationsBindingSource1
            // 
            this.doctorsexaminationsBindingSource1.DataMember = "doctors_examinations";
            this.doctorsexaminationsBindingSource1.DataSource = this.my_databaseDataSet;
            // 
            // doctorsexaminationsBindingSource
            // 
            this.doctorsexaminationsBindingSource.DataMember = "doctors_examinations";
            this.doctorsexaminationsBindingSource.DataSource = this.my_databaseDataSet;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.my_databaseDataSet;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // mydatabaseDataSetBindingSource
            // 
            this.mydatabaseDataSetBindingSource.DataSource = this.my_databaseDataSet;
            this.mydatabaseDataSetBindingSource.Position = 0;
            // 
            // doctors_examinationsTableAdapter
            // 
            this.doctors_examinationsTableAdapter.ClearBeforeFill = true;
            // 
            // mydatabaseDataSetBindingSource1
            // 
            this.mydatabaseDataSetBindingSource1.DataSource = this.my_databaseDataSet;
            this.mydatabaseDataSetBindingSource1.Position = 0;
            // 
            // my_databaseDataSet1
            // 
            this.my_databaseDataSet1.DataSetName = "my_databaseDataSet";
            this.my_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AppointmentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AppointmentManagment";
            this.Text = "AppointmentManagment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsexaminationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_databaseDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsexaminationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsexaminationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydatabaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private my_databaseDataSet my_databaseDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private my_databaseDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentToolStripMenuItem;
        private System.Windows.Forms.BindingSource mydatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource doctorsexaminationsBindingSource;
        private my_databaseDataSetTableAdapters.doctors_examinationsTableAdapter doctors_examinationsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsexaminationsBindingSource1;
        private System.Windows.Forms.BindingSource mydatabaseDataSetBindingSource1;
        private my_databaseDataSet my_databaseDataSet1;
        private System.Windows.Forms.BindingSource doctorsexaminationsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}