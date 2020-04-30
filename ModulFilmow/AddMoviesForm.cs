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

        int idmovie = 0;

        private static string Mode;
        public formAddMovies(String mode) //dodac id fimu
        {
            Mode = mode;
            //ustawic tytul formatki

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
                    if (numericUpDownMovieLength.Value != 0)
                    {
                        if (ListPersonToMovie.Count != 0)
                        {
                            Movie.addMovie(textBoxTitle.Text, richTextBoxDescription.Text, state, type, (int)numericUpDownMovieLength.Value, checkBoxVR.Checked, checkBox2D.Checked, checkBox3D.Checked);
                            DownloadMovieID();
                            foreach (MoviePerson mp in ListPersonToMovie)
                            {
                                MoviePerson.addMoviePerson(idmovie, mp.Person, mp.PersonType);

                            }
                        }

                    }
                    else { MessageBox.Show("Please fill in all the data in the form! chech"); }
                }
                else { MessageBox.Show("Please fill in all the data in the form! como"); }

            }
            else { MessageBox.Show("Please fill in all the data in the form! stringis null"); }

            

           


            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formManagementPeoplesAndRoles = new formManagementPeoplesAndRoles();
            formManagementPeoplesAndRoles.Show();
        }

        private void formAddMovies_Load(object sender, EventArgs e)
        {
            // if mode add 
            //PersonType.DownloadPersonTYPE();
            //Person.DownloadPerson();
            //MovieState.DownloadMovieState();
            //MovieType.DownloadMovieType();


            //edit movie
            // MessageBox.Show(Mode);

            refresh();
        }


        void refresh()
        {
            textBoxTitle.Text = "";
            numericUpDownMovieLength.Value = 0;

            foreach(PersonType pt in PersonType.ListPersonType)
            {
                comboBoxSelectRole.Items.Add(pt);
            }

            foreach (Person p in Person.ListPerson)
            {
                comboBoxSelectPerson.Items.Add(p);
            }

            foreach(MovieState ms in MovieState.ListMovieState)
            {
                comboBoxMovieState.Items.Add(ms);
            }

            foreach(MovieType mt in MovieType.ListMovieType)
            {
                comboBoxMovieType.Items.Add(mt);
            }

            

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

            MoviePerson mp = new MoviePerson();
            mp.Person = person;
            mp.PersonType = persontype;

            ListPersonToMovie.Add(mp);

            refreshpeoplebutton();

        }

        void refreshpeoplebutton()
        {
            dataGridViewPeopleList.Rows.Clear();

            foreach (MoviePerson mo in ListPersonToMovie)
            {
                int w = dataGridViewPeopleList.Rows.Add(mo.Person.ToString(), mo.PersonType.ToString());
                dataGridViewPeopleList.Rows[w].Tag = mo;
            }

        }


        void DownloadMovieID()
        {
            OleDbConnection conn = new OleDbConnection(MainForm.connectionString);

            try
            {
                conn.Open();
                String query = "SELECT TOP 1 * FROM Movie ORDER BY Movie_ID DESC";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                cmd.Connection = conn;
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                reader.Read();
                idmovie = (int)reader[0];
                conn.Close();

                MessageBox.Show(idmovie.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }


    }
}
