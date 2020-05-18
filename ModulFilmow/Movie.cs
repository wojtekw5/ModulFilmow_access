using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using ModulFilmow;

namespace ClassLibrary
{
    public class Movie
    {
        int id;
        string title;
        string description;
        MovieState movieState;
        MovieType movieType;
        TimeSpan movieTimeTS { get; set; }
        int movieTime;
        bool flgVR;
        bool flg2D;
        bool flg3D;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public MovieState MovieState { get => movieState; set => movieState = value; }
        public MovieType MovieType { get => movieType; set => movieType = value; }
        public TimeSpan MovieTimeTS { get => movieTimeTS; set => movieTimeTS = value; }

        public int MovieTime { get => movieTime; set => movieTime = value; }
        public bool FlgVR { get => flgVR; set => flgVR = value; }
        public bool Flg2D { get => flg2D; set => flg2D = value; }
        public bool Flg3D { get => flg3D; set => flg3D = value; }


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

        public Movie(String title, String description, int id)
        {
            this.title = title;
            this.description = description;
            this.id = id;
        }
        
        public static void addMovie(String Title, String Description, MovieState movieState, MovieType movieType, int MovieTime, bool FlgVR, bool Flg2D, bool Flg3D)
        {
            String query = "INSERT INTO Movie(Movie_title, Movie_description, Movie_movieState, Movie_movieType, Movie_movieTime, Movie_flgVR, Movie_flg2D, Movie_flg3D) VALUES('" + Title + "', '" + Description + "','" + movieState.Id + "','" + movieType.Id + "','" + MovieTime + "'," + FlgVR.ToString() + "," + Flg2D.ToString() + "," + Flg3D.ToString() + ")";

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

        public static void DeleteMovie(int idMovie)
        {

            string strSQL = "DELETE * FROM Movie Where Movie_ID=" + idMovie;

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

        public static void ModifyMovieInfo(int idMovie, String Title, String Description, MovieState movieState, MovieType movieType, int MovieTime, bool FlgVR, bool Flg2D, bool Flg3D)
        {
            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = connection.CreateCommand();

            command.CommandText = "UPDATE Movie SET Movie_title = @title, Movie_description = @decs, Movie_movieState = @ms, Movie_movieType = @mt, Movie_movieTime = @ml, Movie_flgVR = @vr, Movie_flg2D= @2d, Movie_flg3D = @3d Where Movie_ID= @id";
            
            command.Parameters.AddWithValue("@title", Title);
            command.Parameters.AddWithValue("@decs", Description);
            command.Parameters.AddWithValue("@ms", movieState.Id);
            command.Parameters.AddWithValue("@mt", movieType.Id);
            command.Parameters.AddWithValue("@ml", MovieTime);
            command.Parameters.AddWithValue("@vr", FlgVR);
            command.Parameters.AddWithValue("@2d", Flg2D);
            command.Parameters.AddWithValue("@3d", Flg3D);
            command.Parameters.AddWithValue("@id", idMovie);

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
