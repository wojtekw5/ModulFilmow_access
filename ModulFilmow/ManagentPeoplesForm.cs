using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxRoleName.Text))
            {
                PersonType.addPersonType(textBoxRoleName.Text);
                textBoxRoleName.Text = "";
            }

            else { MessageBox.Show("Please fill in the data in the form!");  }

            PersonType.DownloadPersonTYPE();
            Person.DownloadPerson();

            refresh();
        }

        private void formManagementPeoplesAndRoles_Load(object sender, EventArgs e)
        {
           
            refresh();

            dateTimePickerDateBorn.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateBorn.CustomFormat = "dd:MMMM:yyyy";

            
        }

        void refresh()
        {
            listBoxRoles.Items.Clear();
            PersonType.DownloadPersonTYPE();
            Person.DownloadPerson();

            foreach (PersonType pt in PersonType.listPersonType)
            {
                listBoxRoles.Items.Add(pt);
            }

            dataGridViewPeopleList.Rows.Clear();

            foreach (Person p in Person.ListPerson)
            {
                int w = dataGridViewPeopleList.Rows.Add(p.FirstName.ToString(), p.LastName.ToString(), p.BornDate.ToString("dd:MM:yyyy"), p.Id);
                dataGridViewPeopleList.Rows[w].Tag = p;
            }

            textBoxName.Text = "";
            textBoxLastName.Text = "";

        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxLastName.Text) )
            {
                if(dateTimePickerDateBorn.Value < DateTime.Now)
                {
                    Person.addPerson(textBoxName.Text, textBoxLastName.Text, dateTimePickerDateBorn.Value);
                }

                else { MessageBox.Show("Please fill in all the data in the form!");  }
            }

            else { MessageBox.Show("Please fill in all the data in the form!"); }

            refresh();
        }

        private void buttontech_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDeleterole_Click(object sender, EventArgs e)
        {
            PersonType pt = (PersonType)listBoxRoles.SelectedItem;
            PersonType.DeletePersonTYPE(pt.Id);
            refresh();

        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            int idperson = 0;
            idperson = (int)dataGridViewPeopleList.CurrentRow.Cells[3].Value;
            Person.DeletePerson(idperson);
            refresh();
            
        }
    }
}
