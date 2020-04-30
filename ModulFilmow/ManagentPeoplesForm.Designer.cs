namespace ModulFilmow
{
    partial class formManagementPeoplesAndRoles
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleterole = new System.Windows.Forms.Button();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPeopleList = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDateBorn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnborndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perosnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleterole);
            this.groupBox2.Controls.Add(this.listBoxRoles);
            this.groupBox2.Controls.Add(this.buttonAddRole);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxRoleName);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles";
            // 
            // buttonDeleterole
            // 
            this.buttonDeleterole.Location = new System.Drawing.Point(9, 277);
            this.buttonDeleterole.Name = "buttonDeleterole";
            this.buttonDeleterole.Size = new System.Drawing.Size(185, 23);
            this.buttonDeleterole.TabIndex = 7;
            this.buttonDeleterole.Text = "Delete role";
            this.buttonDeleterole.UseVisualStyleBackColor = true;
            this.buttonDeleterole.Click += new System.EventHandler(this.buttonDeleterole_Click);
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.Location = new System.Drawing.Point(9, 98);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(185, 173);
            this.listBoxRoles.TabIndex = 6;
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Location = new System.Drawing.Point(9, 68);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(185, 23);
            this.buttonAddRole.TabIndex = 4;
            this.buttonAddRole.Text = "Add role";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter name of role";
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Location = new System.Drawing.Point(9, 41);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(185, 20);
            this.textBoxRoleName.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(9, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(109, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter name";
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(9, 67);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(374, 23);
            this.buttonAddPerson.TabIndex = 3;
            this.buttonAddPerson.Text = "Add person";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.Location = new System.Drawing.Point(9, 277);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(374, 23);
            this.buttonDeletePerson.TabIndex = 5;
            this.buttonDeletePerson.Text = "Delete person";
            this.buttonDeletePerson.UseVisualStyleBackColor = true;
            this.buttonDeletePerson.Click += new System.EventHandler(this.buttonDeletePerson_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(124, 41);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(109, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter lastname";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPeopleList);
            this.groupBox1.Controls.Add(this.dateTimePickerDateBorn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.buttonDeletePerson);
            this.groupBox1.Controls.Add(this.buttonAddPerson);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peoples";
            // 
            // dataGridViewPeopleList
            // 
            this.dataGridViewPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnlastname,
            this.columnborndate,
            this.perosnid});
            this.dataGridViewPeopleList.Location = new System.Drawing.Point(9, 96);
            this.dataGridViewPeopleList.Name = "dataGridViewPeopleList";
            this.dataGridViewPeopleList.Size = new System.Drawing.Size(374, 175);
            this.dataGridViewPeopleList.TabIndex = 10;
            this.dataGridViewPeopleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeopleList_CellContentClick);
            // 
            // dateTimePickerDateBorn
            // 
            this.dateTimePickerDateBorn.Location = new System.Drawing.Point(239, 41);
            this.dateTimePickerDateBorn.Name = "dateTimePickerDateBorn";
            this.dateTimePickerDateBorn.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerDateBorn.TabIndex = 9;
            this.dateTimePickerDateBorn.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter born date";
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnlastname
            // 
            this.columnlastname.FillWeight = 150F;
            this.columnlastname.HeaderText = "Last name";
            this.columnlastname.Name = "columnlastname";
            this.columnlastname.ReadOnly = true;
            this.columnlastname.Width = 130;
            // 
            // columnborndate
            // 
            this.columnborndate.FillWeight = 180F;
            this.columnborndate.HeaderText = "Born date";
            this.columnborndate.Name = "columnborndate";
            this.columnborndate.ReadOnly = true;
            // 
            // perosnid
            // 
            this.perosnid.HeaderText = "ID";
            this.perosnid.Name = "perosnid";
            this.perosnid.ReadOnly = true;
            this.perosnid.Visible = false;
            // 
            // formManagementPeoplesAndRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formManagementPeoplesAndRoles";
            this.Text = "People and roles management";
            this.Load += new System.EventHandler(this.formManagementPeoplesAndRoles_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoleName;
        private System.Windows.Forms.Button buttonDeleterole;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.Button buttonAddRole;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button buttonDeletePerson;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBorn;
        private System.Windows.Forms.DataGridView dataGridViewPeopleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnborndate;
        private System.Windows.Forms.DataGridViewTextBoxColumn perosnid;
    }
}