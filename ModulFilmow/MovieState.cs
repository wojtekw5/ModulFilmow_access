using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using ModulFilmow;

namespace ClassLibrary
{
    public class MovieState
    {
        int id { get; set; }

        public static List<MovieState> listMovieState = new List<MovieState>();

        public static Dictionary<int, MovieState> MovieStateMap = new Dictionary<int, MovieState>();
        public static List<MovieState> ListMovieState
        {
            get
            {
                return listMovieState;
            }
        }
        string name { get; set; } // rodzaj; upcoming itp
        //public MovieState(string n) // bylo w diagramie klas, ale nie wiem czy jest potrzebne,
        //                            // są trzy typy z ktorych sie wybiera (juz zapisane w bazie)
        //{
        //    name = n;
        //}
        public string toString()
        {
            return this.name;
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

        public static void DownloadMovieState()
        {
            ListMovieState.Clear();

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
                    ListMovieState.Add(ms);
                    MovieStateMap.Add(ms.Id, ms);

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
