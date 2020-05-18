using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ModulFilmow
{
    public partial class formManagementPeoplesAndRoles : Form
    {
        public formManagementPeoplesAndRoles()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void dataGridViewPeopleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void buttontech_Click(object sender, EventArgs e)
        {

        }

        private void formManagementPeoplesAndRoles_Load(object sender, EventArgs e)
        {
            refreshPeople();
            refreshRoles();

            dateTimePickerDateBorn.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateBorn.CustomFormat = "dd:MMMM:yyyy";
        }

        
        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxLastName.Text))
            {
                if (dateTimePickerDateBorn.Value < DateTime.Now)
                {
                    Person.addPerson(textBoxName.Text, textBoxLastName.Text, dateTimePickerDateBorn.Value);
                }

                else { MessageBox.Show("Please fill in all the data in the form!"); }
            }

            else { MessageBox.Show("Please fill in all the data in the form!"); }

            refreshPeople();
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxRoleName.Text))
            {
                PersonType.addPersonType(textBoxRoleName.Text);
                textBoxRoleName.Text = "";
            }

            else { MessageBox.Show("Please fill in the data in the form!"); }

            refreshRoles();

        }

        private void buttonDeleterole_Click(object sender, EventArgs e)
        {
            PersonType pt = (PersonType)listBoxRoles.SelectedItem;
            PersonType.DeletePersonTYPE(pt.Id);
            refreshRoles();

        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            int idperson = 0;
            idperson = (int)dataGridViewPeopleList.CurrentRow.Cells[3].Value;
            Person.DeletePerson(idperson);
            refreshPeople();

        }

        void refreshPeople()
        {
            dataGridViewPeopleList.Rows.Clear();
            textBoxName.Text = "";
            textBoxLastName.Text = "";
            getPerson();
        }
        void refreshRoles()
        {
            textBoxRoleName.Text = "";
            listBoxRoles.Items.Clear();
            getPersonTYPE();
        }

        public void getPersonTYPE()
        {

            string strSQL = "SELECT * FROM PersonTYPE";

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PersonType pt = new PersonType();
                    pt.Id = (int)reader[0];
                    pt.Name = reader[1].ToString();
                    listBoxRoles.Items.Add(pt);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();

        }

        public void getPerson()
        {
            string strSQL = "SELECT * FROM Person";

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person p = new Person((int)reader[0], reader[1].ToString(), reader[2].ToString(), (DateTime)reader[3]);
                    int w = dataGridViewPeopleList.Rows.Add(p.FirstName.ToString(), p.LastName.ToString(), p.BornDate.ToString("dd:MM:yyyy"), p.Id);
                    dataGridViewPeopleList.Rows[w].Tag = p;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();

        }

        
    }
}