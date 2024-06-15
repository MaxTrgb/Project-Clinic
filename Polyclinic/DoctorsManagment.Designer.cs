namespace Polyclinic
{
    partial class DoctorsManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsManagment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.my_databaseDataSet = new Polyclinic.my_databaseDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new Polyclinic.my_databaseDataSetTableAdapters.doctorsTableAdapter();
            this.doctorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.my_databaseDataSet1 = new Polyclinic.my_databaseDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_databaseDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button5);
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
            this.dataGridView1.Size = new System.Drawing.Size(494, 370);
            this.dataGridView1.TabIndex = 5;
            // 
            // doctorsBindingSource3
            // 
            this.doctorsBindingSource3.DataMember = "doctors";
            this.doctorsBindingSource3.DataSource = this.my_databaseDataSet;
            // 
            // my_databaseDataSet
            // 
            this.my_databaseDataSet.DataSetName = "my_databaseDataSet";
            this.my_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(427, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 21);
            this.button5.TabIndex = 4;
            this.button5.Text = "Return";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.editDoctorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeDoctorToolStripMenuItem,
            this.addDoctorToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.tableToolStripMenuItem.Text = "Table";
            // 
            // removeDoctorToolStripMenuItem
            // 
            this.removeDoctorToolStripMenuItem.Name = "removeDoctorToolStripMenuItem";
            this.removeDoctorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.removeDoctorToolStripMenuItem.Text = "Remove doctor";
            this.removeDoctorToolStripMenuItem.Click += new System.EventHandler(this.removeDoctorToolStripMenuItem_Click);
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addDoctorToolStripMenuItem.Text = "Add doctor";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addDoctorToolStripMenuItem_Click);
            // 
            // editDoctorToolStripMenuItem
            // 
            this.editDoctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNameToolStripMenuItem,
            this.changePositionToolStripMenuItem,
            this.changeSalaryToolStripMenuItem,
            this.changeWardToolStripMenuItem});
            this.editDoctorToolStripMenuItem.Name = "editDoctorToolStripMenuItem";
            this.editDoctorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editDoctorToolStripMenuItem.Text = "Doctor";
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changeNameToolStripMenuItem.Text = "Change name";
            this.changeNameToolStripMenuItem.Click += new System.EventHandler(this.changeNameToolStripMenuItem_Click);
            // 
            // changePositionToolStripMenuItem
            // 
            this.changePositionToolStripMenuItem.Name = "changePositionToolStripMenuItem";
            this.changePositionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changePositionToolStripMenuItem.Text = "Change position";
            this.changePositionToolStripMenuItem.Click += new System.EventHandler(this.changePositionToolStripMenuItem_Click);
            // 
            // changeSalaryToolStripMenuItem
            // 
            this.changeSalaryToolStripMenuItem.Name = "changeSalaryToolStripMenuItem";
            this.changeSalaryToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changeSalaryToolStripMenuItem.Text = "Change salary";
            this.changeSalaryToolStripMenuItem.Click += new System.EventHandler(this.changeSalaryToolStripMenuItem_Click);
            // 
            // changeWardToolStripMenuItem
            // 
            this.changeWardToolStripMenuItem.Name = "changeWardToolStripMenuItem";
            this.changeWardToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changeWardToolStripMenuItem.Text = "Change ward";
            this.changeWardToolStripMenuItem.Click += new System.EventHandler(this.changeWardToolStripMenuItem_Click);
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "doctors";
            this.doctorsBindingSource1.DataSource = this.my_databaseDataSet;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.my_databaseDataSet;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsBindingSource2
            // 
            this.doctorsBindingSource2.DataMember = "doctors";
            this.doctorsBindingSource2.DataSource = this.my_databaseDataSet;
            // 
            // my_databaseDataSet1
            // 
            this.my_databaseDataSet1.DataSetName = "my_databaseDataSet";
            this.my_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DoctorsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorsManagment";
            this.Text = "DoctorsManagment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_databaseDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private my_databaseDataSet my_databaseDataSet;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private my_databaseDataSetTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private System.Windows.Forms.BindingSource doctorsBindingSource2;
        private my_databaseDataSet my_databaseDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource doctorsBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWardToolStripMenuItem;
    }
}