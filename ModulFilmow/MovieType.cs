using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ModulFilmow;
using System.Data.OleDb;

namespace ClassLibrary
{
    public class MovieType
    {
        int id { get; set; }
        string name { get; set; } //nazwa gatunku


        public static List<MovieType> listMovieType = new List<MovieType>();

        public static Dictionary<int, MovieType> MovieTypeMap = new Dictionary<int, MovieType>();
        public static List<MovieType> ListMovieType
        {
            get
            {
                return listMovieType;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public override string ToString()
        {
            return name;
        }

        //public MovieType(string n)
        //{
        //    name = n;
        //}
        public string toString()
        {
            return this.name;
        }


        public static void getMovieType()
        {
            ListMovieType.Clear();

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
                    ListMovieType.Add(mt);
                    MovieTypeMap.Add(mt.Id, mt);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }
    }
}
