namespace ModulFilmow
{
    partial class formEditingINFO
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
            this.buttonEditDeletePersonFromMovie = new System.Windows.Forms.Button();
            this.buttonSaveMovie = new System.Windows.Forms.Button();
            this.buttonEditManageForm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEditPeopleList = new System.Windows.Forms.DataGridView();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEditVR = new System.Windows.Forms.CheckBox();
            this.checkBoxEdit3D = new System.Windows.Forms.CheckBox();
            this.checkBoxEdit2D = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEditPersonToMovie = new System.Windows.Forms.Button();
            this.comboBoxEditSelectRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEditSelectPerson = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownEditMovieLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEditMovieState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEditMovieType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditTitle = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditPeopleList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditMovieLength)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditDeletePersonFromMovie
            // 
            this.buttonEditDeletePersonFromMovie.Location = new System.Drawing.Point(293, 287);
            this.buttonEditDeletePersonFromMovie.Name = "buttonEditDeletePersonFromMovie";
            this.buttonEditDeletePersonFromMovie.Size = new System.Drawing.Size(346, 40);
            this.buttonEditDeletePersonFromMovie.TabIndex = 34;
            this.buttonEditDeletePersonFromMovie.Text = "Delete this person from movie";
            this.buttonEditDeletePersonFromMovie.UseVisualStyleBackColor = true;
            // 
            // buttonSaveMovie
            // 
            this.buttonSaveMovie.Location = new System.Drawing.Point(15, 333);
            this.buttonSaveMovie.Name = "buttonSaveMovie";
            this.buttonSaveMovie.Size = new System.Drawing.Size(773, 40);
            this.buttonSaveMovie.TabIndex = 33;
            this.buttonSaveMovie.Text = "Save movie";
            this.buttonSaveMovie.UseVisualStyleBackColor = true;
            // 
            // buttonEditManageForm
            // 
            this.buttonEditManageForm.Location = new System.Drawing.Point(648, 113);
            this.buttonEditManageForm.Name = "buttonEditManageForm";
            this.buttonEditManageForm.Size = new System.Drawing.Size(140, 214);
            this.buttonEditManageForm.TabIndex = 32;
            this.buttonEditManageForm.Text = "Manage people and roles";
            this.buttonEditManageForm.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewEditPeopleList);
            this.groupBox3.Location = new System.Drawing.Point(293, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 178);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "People list of this movie";
            // 
            // dataGridViewEditPeopleList
            // 
            this.dataGridViewEditPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.Role});
            this.dataGridViewEditPeopleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEditPeopleList.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewEditPeopleList.Name = "dataGridViewEditPeopleList";
            this.dataGridViewEditPeopleList.Size = new System.Drawing.Size(343, 159);
            this.dataGridViewEditPeopleList.TabIndex = 13;
            // 
            // Person
            // 
            this.Person.HeaderText = "Person";
            this.Person.Name = "Person";
            this.Person.Width = 150;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEditVR);
            this.groupBox1.Controls.Add(this.checkBoxEdit3D);
            this.groupBox1.Controls.Add(this.checkBoxEdit2D);
            this.groupBox1.Location = new System.Drawing.Point(694, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 88);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select format:";
            // 
            // checkBoxEditVR
            // 
            this.checkBoxEditVR.AutoSize = true;
            this.checkBoxEditVR.Location = new System.Drawing.Point(5, 65);
            this.checkBoxEditVR.Name = "checkBoxEditVR";
            this.checkBoxEditVR.Size = new System.Drawing.Size(41, 17);
            this.checkBoxEditVR.TabIndex = 18;
            this.checkBoxEditVR.Text = "VR";
            this.checkBoxEditVR.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdit3D
            // 
            this.checkBoxEdit3D.AutoSize = true;
            this.checkBoxEdit3D.Location = new System.Drawing.Point(6, 42);
            this.checkBoxEdit3D.Name = "checkBoxEdit3D";
            this.checkBoxEdit3D.Size = new System.Drawing.Size(40, 17);
            this.checkBoxEdit3D.TabIndex = 17;
            this.checkBoxEdit3D.Text = "3D";
            this.checkBoxEdit3D.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdit2D
            // 
            this.checkBoxEdit2D.AutoSize = true;
            this.checkBoxEdit2D.Location = new System.Drawing.Point(6, 19);
            this.checkBoxEdit2D.Name = "checkBoxEdit2D";
            this.checkBoxEdit2D.Size = new System.Drawing.Size(40, 17);
            this.checkBoxEdit2D.TabIndex = 16;
            this.checkBoxEdit2D.Text = "2D";
            this.checkBoxEdit2D.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEditPersonToMovie);
            this.groupBox2.Controls.Add(this.comboBoxEditSelectRole);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxEditSelectPerson);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(339, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 88);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "People";
            // 
            // buttonEditPersonToMovie
            // 
            this.buttonEditPersonToMovie.Location = new System.Drawing.Point(259, 15);
            this.buttonEditPersonToMovie.Name = "buttonEditPersonToMovie";
            this.buttonEditPersonToMovie.Size = new System.Drawing.Size(75, 51);
            this.buttonEditPersonToMovie.TabIndex = 18;
            this.buttonEditPersonToMovie.Text = "Add person to this movie";
            this.buttonEditPersonToMovie.UseVisualStyleBackColor = true;
            // 
            // comboBoxEditSelectRole
            // 
            this.comboBoxEditSelectRole.FormattingEnabled = true;
            this.comboBoxEditSelectRole.Location = new System.Drawing.Point(87, 45);
            this.comboBoxEditSelectRole.Name = "comboBoxEditSelectRole";
            this.comboBoxEditSelectRole.Size = new System.Drawing.Size(154, 21);
            this.comboBoxEditSelectRole.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Select role:";
            // 
            // comboBoxEditSelectPerson
            // 
            this.comboBoxEditSelectPerson.FormattingEnabled = true;
            this.comboBoxEditSelectPerson.Location = new System.Drawing.Point(87, 15);
            this.comboBoxEditSelectPerson.Name = "comboBoxEditSelectPerson";
            this.comboBoxEditSelectPerson.Size = new System.Drawing.Size(154, 21);
            this.comboBoxEditSelectPerson.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select person:";
            // 
            // numericUpDownEditMovieLength
            // 
            this.numericUpDownEditMovieLength.Location = new System.Drawing.Point(179, 73);
            this.numericUpDownEditMovieLength.Name = "numericUpDownEditMovieLength";
            this.numericUpDownEditMovieLength.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownEditMovieLength.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Edit movie length (minutes) :";
            // 
            // comboBoxEditMovieState
            // 
            this.comboBoxEditMovieState.FormattingEnabled = true;
            this.comboBoxEditMovieState.Location = new System.Drawing.Point(15, 73);
            this.comboBoxEditMovieState.Name = "comboBoxEditMovieState";
            this.comboBoxEditMovieState.Size = new System.Drawing.Size(154, 21);
            this.comboBoxEditMovieState.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Edit movie state:";
            // 
            // comboBoxEditMovieType
            // 
            this.comboBoxEditMovieType.FormattingEnabled = true;
            this.comboBoxEditMovieType.Location = new System.Drawing.Point(179, 24);
            this.comboBoxEditMovieType.Name = "comboBoxEditMovieType";
            this.comboBoxEditMovieType.Size = new System.Drawing.Size(154, 21);
            this.comboBoxEditMovieType.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Edit movie type:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(15, 113);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(272, 214);
            this.richTextBoxDescription.TabIndex = 22;
            this.richTextBoxDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Edit description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Edit title:";
            // 
            // textBoxEditTitle
            // 
            this.textBoxEditTitle.Location = new System.Drawing.Point(15, 25);
            this.textBoxEditTitle.Name = "textBoxEditTitle";
            this.textBoxEditTitle.Size = new System.Drawing.Size(154, 20);
            this.textBoxEditTitle.TabIndex = 19;
            // 
            // formEditingINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.buttonEditDeletePersonFromMovie);
            this.Controls.Add(this.buttonSaveMovie);
            this.Controls.Add(this.buttonEditManageForm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDownEditMovieLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEditMovieState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEditMovieType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEditTitle);
            this.Name = "formEditingINFO";
            this.Text = "Editing movie\'s info";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditPeopleList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditMovieLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditDeletePersonFromMovie;
        private System.Windows.Forms.Button buttonSaveMovie;
        private System.Windows.Forms.Button buttonEditManageForm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewEditPeopleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEditVR;
        private System.Windows.Forms.CheckBox checkBoxEdit3D;
        private System.Windows.Forms.CheckBox checkBoxEdit2D;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEditPersonToMovie;
        private System.Windows.Forms.ComboBox comboBoxEditSelectRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxEditSelectPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownEditMovieLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEditMovieState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEditMovieType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEditTitle;
    }
}