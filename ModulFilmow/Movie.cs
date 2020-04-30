using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using ModulFilmow;

namespace ClassLibrary
{
    public class Movie
    {
        int id { get; set; }
        string title { get; set; }
        string description { get; set; }
        MovieState movieState { get; set; }
        MovieType movieType { get; set; }
        //TimeSpan movieTime { get; set; }
        int movieTime { get; set; }
        bool flgVR { get; set; }
        bool flg2D { get; set; }
        bool flg3D { get; set; }
        //List<PersonType> peoples;
        //public Movie(string t, string d, MovieState ms, MovieType mt, TimeSpan time,
        //            bool fv, bool f2, bool f3)
        //{
        //    title = t;
        //    description = d;
        //    movieState = ms;
        //    movieType = mt;
        //    movieTime = time;
        //    flgVR = fv;
        //    flg2D = f2;
        //    flg3D = f3;
        //    peoples = new List<PersonType>();
        //}

        //public void addPerson(PersonJob pj)
        //{
        //    peoples.Add(pj);
        //    //pj.movie = this;
        //}

        //public string toString()
        //{
        //    return "\"" + title + "\", " + description;
        //}

        public static List<Movie> listMovie = new List<Movie>();


        public static List<Movie> ListMovie
        {
            get
            {
                return listMovie;
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

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public MovieState MovieState
        {
            get
            {
                return movieState;
            }

            set
            {
                movieState = value;
            }
        }

        public MovieType MovieType
        {
            get
            {
                return movieType;
            }

            set
            {
                movieType = value;
            }
        }

        public int MovieTime
        {
            get
            {
                return movieTime;
            }

            set
            {
                movieTime = value;
            }
        }


        public bool FlgVR
        {
            get
            {
                return flgVR;
            }

            set
            {
                flgVR = value;
            }
        }

        public bool Flg2D
        {
            get
            {
                return flg2D;
            }

            set
            {
                flg2D = value;
            }
        }

        public bool Flg3D
        {
            get
            {
                return flg3D;
            }

            set
            {
                flg3D = value;
            }
        }


      

        public Movie(int id, String title, String description, MovieState movieState, MovieType movieType, int movieTime, bool flgVR, bool flg2D, bool flg3D)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.movieState = movieState;
            this.movieType = movieType;
            this.movieTime = movieTime;
            this.flgVR = flgVR;
            this.flg2D = flg2D;
            this.flg3D = flg3D;

        }

        


        public static void addMovie(String Title, String Description, MovieState movieState, MovieType movieType, int MovieTime, bool FlgVR, bool Flg2D, bool Flg3D)
        {


            OleDbConnection conn = new OleDbConnection(MainForm.connectionString);

            int idmovie = 0;

            try
            {
                conn.Open();
                String query = "INSERT INTO Movie(Movie_title, Movie_description, Movie_movieState, Movie_movieType, Movie_movieTime, Movie_flgVR, Movie_flg2D, Movie_flg3D) VALUES('" + Title + "', '" + Description + "','" + movieState.Id + "','" + movieType.Id + "','" + MovieTime + "',"+FlgVR.ToString()+ "," + Flg2D.ToString() + "," + Flg3D.ToString() + ")";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                //cmd = new OleDbCommand("SELECT TOP 1 * FROM Movie ORDER BY Movie_ID DESC");

                //cmd.Connection = conn;
                //conn.Open();
                //OleDbDataReader reader = cmd.ExecuteReader();

                //reader.Read();
                //idmovie = (int)reader[0];
                //conn.Close();

                //MessageBox.Show(idmovie.ToString());

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);

            }
            

        }


        public static void DownloadMovie()
        {
            ListMovie.Clear();

            string strSQL = "SELECT * FROM Movie";

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);

            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Movie m = new Movie((int)reader[0], reader[1].ToString(), reader[2].ToString(), MovieState.MovieStateMap[(int)reader[3]], MovieType.MovieTypeMap[(int)reader[4]], (int)reader[5], (bool)reader[6], (bool)reader[7], (bool)reader[8]);
                    ListMovie.Add(m);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        public static int DownloadMovieID()
        {
            OleDbConnection conn = new OleDbConnection(MainForm.connectionString);

            int idmovie = 0;

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
            return idmovie;
        }


    }
}
