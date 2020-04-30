using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulFilmow
{
    class MoviePerson
    {
        int id;

        Movie movie;
        Person person;
        PersonType personType;

        public Movie Movie
        {
            get
            {
                return movie;
            }

            set
            {
                movie = value;
            }
        }

        public Person Person
        {
            get
            {
                return person;
            }

            set
            {
                person = value;
            }
        }

        public PersonType PersonType
        {
            get
            {
                return personType;
            }

            set
            {
                personType = value;
            }
        }


        public MoviePerson(int id, Movie movie, Person person, PersonType personType)
        {
            this.id = id;
            this.movie = movie;
            this.person = person;
            this.personType = personType;
        }

        public MoviePerson(Person person, PersonType personType)
        {
            this.person = person;
            this.personType = personType;
        }


        //public static void addMoviePersons(List<MoviePerson> newListMoviePerson)
        //{
        //    foreach(MoviePerson mp in newListMoviePerson)
        //    {
        //        addMoviePerson(mp);
        //    }
        //}
        public static void addMoviePerson(int idmovie, Person person, PersonType personType)
        {


            OleDbConnection conn = new OleDbConnection(MainForm.connectionString);

            try
            {
                conn.Open();
                String query = "INSERT INTO MoviePerson(movie, person, role) VALUES('" + idmovie + "', '" + person.Id + "', '" + personType.Id + "')";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);

            }
            conn.Close();
        }

        public static List<MoviePerson> getMoviePerson(int idMovie)
        {
            List<MoviePerson> listMoviePerson = new List<MoviePerson>();

            string strSQL = "SELECT * FROM MoviePerson Where movie =" + idMovie;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);

            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MoviePerson mp = new MoviePerson((int)reader[0], Movie.MovieMap[(int)reader[1]], Person.PersonMap[(int)reader[2]], PersonType.MapPersonType[(int)reader[3]]);
                    listMoviePerson.Add(mp);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            return listMoviePerson;
        }

        public static void DeleteMoviePerson(int idMovie)
        {
            string strSQL = "DELETE * FROM MoviePerson Where movie=" + idMovie;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);

            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
    }
}