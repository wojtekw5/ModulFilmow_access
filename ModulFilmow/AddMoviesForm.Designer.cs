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
            this.numericUpDownMovieLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxVR = new System.Windows.Forms.CheckBox();
            this.checkBox3D = new System.Windows.Forms.CheckBox();
            this.checkBox2D = new System.Windows.Forms.CheckBox();
            this.dataGridViewPeopleList = new System.Windows.Forms.DataGridView();
            this.Name_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddPersonToMovie = new System.Windows.Forms.Button();
            this.comboBoxSelectRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSelectPerson = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonDeletePersonFromMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMovieLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(15, 34);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(154, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter description:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(15, 122);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(272, 214);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select movie type:";
            // 
            // comboBoxMovieType
            // 
            this.comboBoxMovieType.FormattingEnabled = true;
            this.comboBoxMovieType.Location = new System.Drawing.Point(179, 33);
            this.comboBoxMovieType.Name = "comboBoxMovieType";
            this.comboBoxMovieType.Size = new System.Drawing.Size(154, 21);
            this.comboBoxMovieType.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select movie state:";
            // 
            // comboBoxMovieState
            // 
            this.comboBoxMovieState.FormattingEnabled = true;
            this.comboBoxMovieState.Location = new System.Drawing.Point(15, 82);
            this.comboBoxMovieState.Name = "comboBoxMovieState";
            this.comboBoxMovieState.Size = new System.Drawing.Size(154, 21);
            this.comboBoxMovieState.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select movie length (minutes) :";
            // 
            // numericUpDownMovieLength
            // 
            this.numericUpDownMovieLength.Location = new System.Drawing.Point(179, 82);
            this.numericUpDownMovieLength.Name = "numericUpDownMovieLength";
            this.numericUpDownMovieLength.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownMovieLength.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxVR);
            this.groupBox1.Controls.Add(this.checkBox3D);
            this.groupBox1.Controls.Add(this.checkBox2D);
            this.groupBox1.Location = new System.Drawing.Point(694, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 88);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select format:";
            // 
            // checkBoxVR
            // 
            this.checkBoxVR.AutoSize = true;
            this.checkBoxVR.Location = new System.Drawing.Point(5, 65);
            this.checkBoxVR.Name = "checkBoxVR";
            this.checkBoxVR.Size = new System.Drawing.Size(41, 17);
            this.checkBoxVR.TabIndex = 18;
            this.checkBoxVR.Text = "VR";
            this.checkBoxVR.UseVisualStyleBackColor = true;
            // 
            // checkBox3D
            // 
            this.checkBox3D.AutoSize = true;
            this.checkBox3D.Location = new System.Drawing.Point(6, 42);
            this.checkBox3D.Name = "checkBox3D";
            this.checkBox3D.Size = new System.Drawing.Size(40, 17);
            this.checkBox3D.TabIndex = 17;
            this.checkBox3D.Text = "3D";
            this.checkBox3D.UseVisualStyleBackColor = true;
            // 
            // checkBox2D
            // 
            this.checkBox2D.AutoSize = true;
            this.checkBox2D.Location = new System.Drawing.Point(6, 19);
            this.checkBox2D.Name = "checkBox2D";
            this.checkBox2D.Size = new System.Drawing.Size(40, 17);
            this.checkBox2D.TabIndex = 16;
            this.checkBox2D.Text = "2D";
            this.checkBox2D.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPeopleList
            // 
            this.dataGridViewPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_lastname,
            this.Role});
            this.dataGridViewPeopleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeopleList.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPeopleList.Name = "dataGridViewPeopleList";
            this.dataGridViewPeopleList.Size = new System.Drawing.Size(343, 159);
            this.dataGridViewPeopleList.TabIndex = 13;
            // 
            // Name_lastname
            // 
            this.Name_lastname.HeaderText = "Name and lastname";
            this.Name_lastname.Name = "Name_lastname";
            this.Name_lastname.Width = 150;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddPersonToMovie);
            this.groupBox2.Controls.Add(this.comboBoxSelectRole);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxSelectPerson);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(339, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 88);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "People";
            // 
            // buttonAddPersonToMovie
            // 
            this.buttonAddPersonToMovie.Location = new System.Drawing.Point(259, 15);
            this.buttonAddPersonToMovie.Name = "buttonAddPersonToMovie";
            this.buttonAddPersonToMovie.Size = new System.Drawing.Size(75, 51);
            this.buttonAddPersonToMovie.TabIndex = 18;
            this.buttonAddPersonToMovie.Text = "Add person to this movie";
            this.buttonAddPersonToMovie.UseVisualStyleBackColor = true;
            this.buttonAddPersonToMovie.Click += new System.EventHandler(this.buttonAddPersonToMovie_Click);
            // 
            // comboBoxSelectRole
            // 
            this.comboBoxSelectRole.FormattingEnabled = true;
            this.comboBoxSelectRole.Location = new System.Drawing.Point(87, 45);
            this.comboBoxSelectRole.Name = "comboBoxSelectRole";
            this.comboBoxSelectRole.Size = new System.Drawing.Size(154, 21);
            this.comboBoxSelectRole.TabIndex = 17;
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
            // comboBoxSelectPerson
            // 
            this.comboBoxSelectPerson.FormattingEnabled = true;
            this.comboBoxSelectPerson.Location = new System.Drawing.Point(87, 15);
            this.comboBoxSelectPerson.Name = "comboBoxSelectPerson";
            this.comboBoxSelectPerson.Size = new System.Drawing.Size(154, 21);
            this.comboBoxSelectPerson.TabIndex = 15;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewPeopleList);
            this.groupBox3.Location = new System.Drawing.Point(293, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 178);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "People list of this movie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 214);
            this.button1.TabIndex = 16;
            this.button1.Text = "Manage people and roles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(15, 342);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(773, 40);
            this.buttonAddMovie.TabIndex = 17;
            this.buttonAddMovie.Text = "Add movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonDeletePersonFromMovie
            // 
            this.buttonDeletePersonFromMovie.Location = new System.Drawing.Point(293, 296);
            this.buttonDeletePersonFromMovie.Name = "buttonDeletePersonFromMovie";
            this.buttonDeletePersonFromMovie.Size = new System.Drawing.Size(346, 40);
            this.buttonDeletePersonFromMovie.TabIndex = 18;
            this.buttonDeletePersonFromMovie.Text = "Delete this person from movie";
            this.buttonDeletePersonFromMovie.UseVisualStyleBackColor = true;
            // 
            // formAddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.buttonDeletePersonFromMovie);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDownMovieLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMovieState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMovieType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "formAddMovies";
            this.Text = "Add movie";
            this.Load += new System.EventHandler(this.formAddMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMovieLength)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownMovieLength;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonDeletePersonFromMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}