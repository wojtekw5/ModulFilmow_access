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
    public partial class formAddMovies : Form
    {
        List<MoviePerson> ListPersonToMovie = new List<MoviePerson>();

        private int idMovie;

        private static string Mode;
        public formAddMovies()
        {
            Mode = "ADD";
            idMovie = 0;
            InitializeComponent();
        }
        public formAddMovies(int id)
        {
            Mode = "EDIT";
            idMovie = id; 
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {

            MovieState state = (MovieState)comboBoxMovieState.SelectedItem;
            MovieType type = (MovieType)comboBoxMovieType.SelectedItem;

            if (!String.IsNullOrEmpty(textBoxTitle.Text) && !String.IsNullOrEmpty(richTextBoxDescription.Text))
            {
                if (comboBoxMovieState.SelectedItem != null && comboBoxMovieType.SelectedItem != null)
                {
                        if (ListPersonToMovie.Count != 0)
                        {
                            if(Mode == "ADD")
                            {
                                DateTime d = dateTimePickerMovieLength.Value;
                                DateTime lenght = new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);

                                Movie.addMovie(textBoxTitle.Text, richTextBoxDescription.Text, state, type, lenght, checkBoxVR.Checked, checkBox2D.Checked, checkBox3D.Checked);
                                DownloadMovieID();
                                foreach (MoviePerson mp in ListPersonToMovie)
                                {
                                    MoviePerson.addMoviePerson(idMovie, mp.Person, mp.PersonType);

                                }

                            }

                            if (Mode == "EDIT")
                            {
                                DateTime d = dateTimePickerMovieLength.Value;
                                DateTime lenght = new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);

                                Movie.ModifyMovieInfo(idMovie, textBoxTitle.Text, richTextBoxDescription.Text, state, type, lenght, checkBoxVR.Checked, checkBox2D.Checked, checkBox3D.Checked);

                            }

                            this.Close();


                        }
                        else { MessageBox.Show("Please add people to this movie"); }

                    
                }
                else { MessageBox.Show("Please fill in all the data in the form! como"); }

            }
            else { MessageBox.Show("Please fill in all the data in the form! stringis null"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formManagementPeoplesAndRoles = new formManagementPeoplesAndRoles();
            formManagementPeoplesAndRoles.Show();
        }

        private void formAddMovies_Load(object sender, EventArgs e)
        {
            getPerson();
            getPersonTYPE();
            getMovieType();
            getMovieState();

            if(Mode == "EDIT")
            {
                buttonAddMovie.Text = "Edit Movie";
                this.Text = "Editing Movie";
                getMovieInfo(idMovie);
                getMoviePerson();
            }

            refreshpeoplebutton();


            dateTimePickerMovieLength.Format = DateTimePickerFormat.Custom;
            dateTimePickerMovieLength.CustomFormat = "HH:mm";
            dateTimePickerMovieLength.ShowUpDown = true;
            dateTimePickerMovieLength.MinDate = DateTime.Parse("0:00:00");
            dateTimePickerMovieLength.MaxDate = DateTime.Parse("5:00:00");
            dateTimePickerMovieLength.Value= DateTime.Parse("0:00:00");
        }

        private void buttontech2_Click(object sender, EventArgs e)
        {


        }

        private void buttontech3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPersonToMovie_Click(object sender, EventArgs e)
        {
            
                Person person = (Person)comboBoxSelectPerson.SelectedItem;
                PersonType persontype = (PersonType)comboBoxSelectRole.SelectedItem;


                if (ListPersonToMovie.Count == 0)
                {
                    MoviePerson mp = new MoviePerson(person, persontype);
                    ListPersonToMovie.Add(mp);
                    if (Mode == "EDIT")
                    {
                    MoviePerson.addMoviePerson(idMovie, mp.Person, mp.PersonType);
                }
                }
                else
                {
                    bool exist = false;

                    foreach (MoviePerson mpp in ListPersonToMovie)
                    {
                        if (mpp.Person.Id == person.Id)
                        {
                            exist = true;
                        }
                    }

                    if (exist)
                    {
                        MessageBox.Show("Cannot add this person again!");
                    }
                    else
                    {
                        MoviePerson mp = new MoviePerson(person, persontype);
                        ListPersonToMovie.Add(mp);
                    if (Mode == "EDIT")
                    {
                        MoviePerson.addMoviePerson(idMovie, mp.Person, mp.PersonType);
                    }
                }
                } 
            

            refreshpeoplebutton();

        }

        void refreshpeoplebutton()
        {
            dataGridViewPeopleList.Rows.Clear();

            foreach (MoviePerson mo in ListPersonToMovie)
            {
                int w = dataGridViewPeopleList.Rows.Add(mo.Person.ToString(), mo.PersonType.ToString(), mo.Person.Id.ToString());
                dataGridViewPeopleList.Rows[w].Tag = mo;
            }

        }

        void DownloadMovieID()
        {
            String query = "SELECT TOP 1 * FROM Movie ORDER BY Movie_ID DESC";

            OleDbConnection conn = new OleDbConnection(MainForm.connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);


            try
            {
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idMovie = (int)reader[0];
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();


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
                    comboBoxSelectPerson.Items.Add(p);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();

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
                    comboBoxSelectRole.Items.Add(pt);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();

        }

        public void getMovieType()
        {
            string strSQL = "SELECT * FROM MovieType";

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    MovieType mt = new MovieType();
                    mt.Id = (int)reader[0];
                    mt.Name = reader[1].ToString();
                    comboBoxMovieType.Items.Add(mt);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();

        }

        public void getMovieState()
        {
            string strSQL = "SELECT * FROM MovieState";

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    MovieState ms = new MovieState();
                    ms.Id = (int)reader[0];
                    ms.Name = reader[1].ToString();
                    comboBoxMovieState.Items.Add(ms);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();

        }

        public void getMovieInfo(int idMovie)
        {
            string strSQL = "SELECT * FROM Movie Where Movie_ID =" + idMovie;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    textBoxTitle.Text = reader[1].ToString();
                    richTextBoxDescription.Text = reader[2].ToString();

                    foreach(MovieState ms in comboBoxMovieState.Items)
                    {
                        if (ms.Id == (int)reader[3])
                        {
                            comboBoxMovieState.SelectedItem = ms;  
                        }
                    }

                    foreach (MovieType mt in comboBoxMovieType.Items)
                    {
                        if (mt.Id == (int)reader[4])
                        {
                            comboBoxMovieType.SelectedItem = mt;
                        }
                    }

                    dateTimePickerMovieLength.Value = (DateTime)reader[5];

                    if ((bool)reader[6]) { checkBoxVR.Checked = true; }
                    if ((bool)reader[7]) { checkBox2D.Checked = true; }
                    if ((bool)reader[8]) { checkBox3D.Checked = true; }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();
        }

        public void getMoviePerson()
        {
            string strSQL = "SELECT Person.firstNAME, Person.lastNAME, PersonTYPE.personTYPE_NAME, Person.person_ID, MoviePerson.movie FROM PersonTYPE INNER JOIN(Person INNER JOIN MoviePerson ON Person.[person_ID] = MoviePerson.[person]) ON PersonTYPE.[personTYPE_ID] = MoviePerson.[role] Where MoviePerson.movie = " + idMovie;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person p = new Person((int)reader[3], reader[0].ToString(), reader[1].ToString());
                    PersonType pt = new PersonType();
                    pt.Name = reader[2].ToString();
                    MoviePerson mp = new MoviePerson(p, pt);

                    ListPersonToMovie.Add(mp);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            connection.Close();
        }

        private void buttonDeletePersonFromMovie_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(dataGridViewPeopleList.CurrentRow.Cells[2].Value.ToString());
            int idrm = 0;

            if (Mode == "EDIT")
            {
                MoviePerson.DeleteMoviePersonEDIT(idMovie, id);
            }

            foreach (MoviePerson mp in ListPersonToMovie)
            {
                if (mp.Person.Id == id)
                {
                    idrm = ListPersonToMovie.IndexOf(mp);
                }
            }

            ListPersonToMovie.RemoveAt(idrm);

            refreshpeoplebutton();

        }

        private void dataGridViewPeopleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime d = dateTimePickerMovieLength.Value;
            DateTime t = dateTimePickerMovieLength.Value;
            DateTime lenght = new DateTime(d.Year, d.Month, d.Day, t.Hour, t.Minute, t.Second);

            
        }
    }
}
