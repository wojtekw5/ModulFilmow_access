using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;
using ClassLibrary;
using System.Data.OleDb;

namespace ModulFilmow
{
    public partial class formMovieInfo : Form
    {
        private int idMovie;

        private int msID;
        private int mtID;

        public formMovieInfo(int id)
        {
            InitializeComponent();
            idMovie = id;
            msID = 0;
            mtID = 0;
        }

        private void buttonEditMovie_Click(object sender, EventArgs e)
        {
            var formAddMovies = new formAddMovies(idMovie);
            formAddMovies.Show();
        }

        private void formMovieInfo_Load(object sender, EventArgs e)
        {
            getMovieInfo();
            getMoviePerson();
        }


        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            Movie.DeleteMovie(idMovie);
            MoviePerson.DeleteMoviePerson(idMovie);
            this.Close();
        }

        public void getMovieInfo()
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
                  
                    labelTitle.Text = reader[1].ToString();
                    richTextBoxDescription.Text = reader[2].ToString();
                    msID = (int)reader[3];
                    mtID = (int)reader[4];
                    labelMovieLength.Text = reader[5].ToString();

                    if ((bool)reader[6]) { labelVR.Text = "Yes"; }
                    if ((bool)reader[7]) { label2D.Text = "Yes"; }
                    if ((bool)reader[8]) { label3D.Text = "Yes"; }

                    getMovieState();
                    getMovieType();

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

                    int w = dataGridViewPeoplesInInformation.Rows.Add(mp.Person.ToString(), mp.PersonType.ToString());
                    dataGridViewPeoplesInInformation.Rows[w].Tag = mp;

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
            string strSQL = "SELECT MovieState_NAME FROM MovieState Where MovieState_ID =" + msID;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    labelMovieState.Text = reader[0].ToString();
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
            string strSQL = "SELECT MovieType_NAME FROM MovieType Where MovieType_ID =" + mtID;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    labelMovieType.Text = reader[0].ToString();

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
