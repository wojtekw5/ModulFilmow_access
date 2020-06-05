namespace ModulFilmow
{
    partial class formAddMovies
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMovieType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMovieState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxVR = new System.Windows.Forms.CheckBox();
            this.checkBox3D = new System.Windows.Forms.CheckBox();
            this.checkBox2D = new System.Windows.Forms.CheckBox();
            this.dataGridViewPeopleList = new System.Windows.Forms.DataGridView();
            this.Name_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peronfilmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddPersonToMovie = new System.Windows.Forms.Button();
            this.comboBoxSelectRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSelectPerson = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonManagementOpen = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonDeletePersonFromMovie = new System.Windows.Forms.Button();
            this.dateTimePickerMovieLength = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(22, 52);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(229, 26);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter description:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(22, 188);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(406, 327);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select movie type:";
            // 
            // comboBoxMovieType
            // 
            this.comboBoxMovieType.FormattingEnabled = true;
            this.comboBoxMovieType.Location = new System.Drawing.Point(268, 51);
            this.comboBoxMovieType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMovieType.Name = "comboBoxMovieType";
            this.comboBoxMovieType.Size = new System.Drawing.Size(229, 28);
            this.comboBoxMovieType.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select movie state:";
            // 
            // comboBoxMovieState
            // 
            this.comboBoxMovieState.FormattingEnabled = true;
            this.comboBoxMovieState.Location = new System.Drawing.Point(22, 126);
            this.comboBoxMovieState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMovieState.Name = "comboBoxMovieState";
            this.comboBoxMovieState.Size = new System.Drawing.Size(229, 28);
            this.comboBoxMovieState.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select movie length:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxVR);
            this.groupBox1.Controls.Add(this.checkBox3D);
            this.groupBox1.Controls.Add(this.checkBox2D);
            this.groupBox1.Location = new System.Drawing.Point(1041, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(141, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select format:";
            // 
            // checkBoxVR
            // 
            this.checkBoxVR.AutoSize = true;
            this.checkBoxVR.Location = new System.Drawing.Point(8, 100);
            this.checkBoxVR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxVR.Name = "checkBoxVR";
            this.checkBoxVR.Size = new System.Drawing.Size(58, 24);
            this.checkBoxVR.TabIndex = 18;
            this.checkBoxVR.Text = "VR";
            this.checkBoxVR.UseVisualStyleBackColor = true;
            // 
            // checkBox3D
            // 
            this.checkBox3D.AutoSize = true;
            this.checkBox3D.Location = new System.Drawing.Point(9, 65);
            this.checkBox3D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3D.Name = "checkBox3D";
            this.checkBox3D.Size = new System.Drawing.Size(56, 24);
            this.checkBox3D.TabIndex = 17;
            this.checkBox3D.Text = "3D";
            this.checkBox3D.UseVisualStyleBackColor = true;
            // 
            // checkBox2D
            // 
            this.checkBox2D.AutoSize = true;
            this.checkBox2D.Location = new System.Drawing.Point(9, 29);
            this.checkBox2D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2D.Name = "checkBox2D";
            this.checkBox2D.Size = new System.Drawing.Size(56, 24);
            this.checkBox2D.TabIndex = 16;
            this.checkBox2D.Text = "2D";
            this.checkBox2D.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPeopleList
            // 
            this.dataGridViewPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_lastname,
            this.Role,
            this.peronfilmid});
            this.dataGridViewPeopleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeopleList.Location = new System.Drawing.Point(4, 24);
            this.dataGridViewPeopleList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPeopleList.Name = "dataGridViewPeopleList";
            this.dataGridViewPeopleList.RowHeadersWidth = 62;
            this.dataGridViewPeopleList.Size = new System.Drawing.Size(516, 245);
            this.dataGridViewPeopleList.TabIndex = 13;
            this.dataGridViewPeopleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeopleList_CellContentClick);
            // 
            // Name_lastname
            // 
            this.Name_lastname.HeaderText = "Name and lastname";
            this.Name_lastname.MinimumWidth = 8;
            this.Name_lastname.Name = "Name_lastname";
            this.Name_lastname.Width = 150;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            this.Role.Width = 150;
            // 
            // peronfilmid
            // 
            this.peronfilmid.HeaderText = "idperson";
            this.peronfilmid.MinimumWidth = 8;
            this.peronfilmid.Name = "peronfilmid";
            this.peronfilmid.Visible = false;
            this.peronfilmid.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddPersonToMovie);
            this.groupBox2.Controls.Add(this.comboBoxSelectRole);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxSelectPerson);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(508, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(522, 135);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "People";
            // 
            // buttonAddPersonToMovie
            // 
            this.buttonAddPersonToMovie.Location = new System.Drawing.Point(388, 23);
            this.buttonAddPersonToMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddPersonToMovie.Name = "buttonAddPersonToMovie";
            this.buttonAddPersonToMovie.Size = new System.Drawing.Size(112, 78);
            this.buttonAddPersonToMovie.TabIndex = 18;
            this.buttonAddPersonToMovie.Text = "Add person to this movie";
            this.buttonAddPersonToMovie.UseVisualStyleBackColor = true;
            this.buttonAddPersonToMovie.Click += new System.EventHandler(this.buttonAddPersonToMovie_Click);
            // 
            // comboBoxSelectRole
            // 
            this.comboBoxSelectRole.FormattingEnabled = true;
            this.comboBoxSelectRole.Location = new System.Drawing.Point(130, 69);
            this.comboBoxSelectRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSelectRole.Name = "comboBoxSelectRole";
            this.comboBoxSelectRole.Size = new System.Drawing.Size(229, 28);
            this.comboBoxSelectRole.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Select role:";
            // 
            // comboBoxSelectPerson
            // 
            this.comboBoxSelectPerson.FormattingEnabled = true;
            this.comboBoxSelectPerson.Location = new System.Drawing.Point(130, 23);
            this.comboBoxSelectPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSelectPerson.Name = "comboBoxSelectPerson";
            this.comboBoxSelectPerson.Size = new System.Drawing.Size(229, 28);
            this.comboBoxSelectPerson.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select person:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewPeopleList);
            this.groupBox3.Location = new System.Drawing.Point(440, 172);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(524, 274);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "People list of this movie";
            // 
            // buttonManagementOpen
            // 
            this.buttonManagementOpen.Location = new System.Drawing.Point(972, 188);
            this.buttonManagementOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonManagementOpen.Name = "buttonManagementOpen";
            this.buttonManagementOpen.Size = new System.Drawing.Size(210, 329);
            this.buttonManagementOpen.TabIndex = 16;
            this.buttonManagementOpen.Text = "Manage people and roles";
            this.buttonManagementOpen.UseVisualStyleBackColor = true;
            this.buttonManagementOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(22, 526);
            this.buttonAddMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(1160, 62);
            this.buttonAddMovie.TabIndex = 17;
            this.buttonAddMovie.Text = "Add movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonDeletePersonFromMovie
            // 
            this.buttonDeletePersonFromMovie.Location = new System.Drawing.Point(440, 455);
            this.buttonDeletePersonFromMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeletePersonFromMovie.Name = "buttonDeletePersonFromMovie";
            this.buttonDeletePersonFromMovie.Size = new System.Drawing.Size(519, 62);
            this.buttonDeletePersonFromMovie.TabIndex = 18;
            this.buttonDeletePersonFromMovie.Text = "Delete this person from movie";
            this.buttonDeletePersonFromMovie.UseVisualStyleBackColor = true;
            this.buttonDeletePersonFromMovie.Click += new System.EventHandler(this.buttonDeletePersonFromMovie_Click);
            // 
            // dateTimePickerMovieLength
            // 
            this.dateTimePickerMovieLength.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerMovieLength.Location = new System.Drawing.Point(268, 128);
            this.dateTimePickerMovieLength.Name = "dateTimePickerMovieLength";
            this.dateTimePickerMovieLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerMovieLength.Size = new System.Drawing.Size(229, 26);
            this.dateTimePickerMovieLength.TabIndex = 19;
            // 
            // formAddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 599);
            this.Controls.Add(this.dateTimePickerMovieLength);
            this.Controls.Add(this.buttonDeletePersonFromMovie);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonManagementOpen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMovieState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMovieType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formAddMovies";
            this.Load += new System.EventHandler(this.formAddMovies_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMovieType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMovieState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxVR;
        private System.Windows.Forms.CheckBox checkBox3D;
        private System.Windows.Forms.CheckBox checkBox2D;
        private System.Windows.Forms.DataGridView dataGridViewPeopleList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddPersonToMovie;
        private System.Windows.Forms.ComboBox comboBoxSelectRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSelectPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonManagementOpen;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonDeletePersonFromMovie;
        private System.Windows.Forms.DateTimePicker dateTimePickerMovieLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn peronfilmid;
    }
}