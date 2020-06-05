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

        public formMovieInfo(int id)
        {
            InitializeComponent();
            idMovie = id;
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
            MoviePerson.DeleteMoviePerson(idMovie);
            Movie.DeleteMovie(idMovie);
            this.Close();
        }

        public void getMovieInfo()
        {
            string strSQL = "SELECT Movie.Movie_title, Movie.Movie_description, MovieState.MovieState_NAME, MovieType.MovieType_NAME, Movie.Movie_movieTime, Movie.Movie_flgVR, Movie.Movie_flg2D, Movie.Movie_flg3D FROM MovieType INNER JOIN(MovieState INNER JOIN Movie ON MovieState.[MovieState_ID] = Movie.[Movie_movieState]) ON MovieType.[MovieType_ID] = Movie.[Movie_movieType] Where Movie_ID =" + idMovie;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                  
                    labelTitle.Text = reader[0].ToString();
                    richTextBoxDescription.Text = reader[1].ToString();
                    labelMovieState.Text = reader[2].ToString();
                    labelMovieType.Text = reader[3].ToString();
                    DateTime ml = (DateTime)reader[4];                    
                    labelMovieLength.Text = ml.ToString();

                    if ((bool)reader[5]) { labelVR.Text = "Yes"; }
                    if ((bool)reader[6]) { label2D.Text = "Yes"; }
                    if ((bool)reader[7]) { label3D.Text = "Yes"; }

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

    }
}
