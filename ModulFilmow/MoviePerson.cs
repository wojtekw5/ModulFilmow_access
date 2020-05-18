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

        public int Id { get => id; set => id = value; }
        public Movie Movie { get => movie; set => movie = value; }
        public Person Person { get => person; set => person = value; }
        public PersonType PersonType { get => personType; set => personType = value; }   

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

        public static void addMoviePerson(int idmovie, Person person, PersonType personType)
        {
            String query = "INSERT INTO MoviePerson(movie, person, role) VALUES('" + idmovie + "', '" + person.Id + "', '" + personType.Id + "')";

            OleDbConnection conn = new OleDbConnection(MainForm.connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();

            }
            conn.Close();
        }
        public static void DeleteMoviePerson(int idMovie)
        {
            string strSQL = "DELETE * FROM MoviePerson Where movie=" + idMovie;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
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