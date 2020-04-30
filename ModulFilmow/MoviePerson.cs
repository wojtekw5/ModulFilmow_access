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


        //public static void addMoviePersons(List<MoviePerson> newListMoviePerson)
        //{
        //    foreach(MoviePerson mp in newListMoviePerson)
        //    {
        //        addMoviePerson(mp);
        //    }
        //}
        public static void addMoviePerson(int idmovie, Person person, PersonType personType )
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

        

    }
}
