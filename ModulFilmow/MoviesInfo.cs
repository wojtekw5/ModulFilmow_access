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
            var formAddMovies = new formAddMovies("EditMode");
            formAddMovies.Show();
        }

        private void formMovieInfo_Load(object sender, EventArgs e)
        {

        }

        void refresh()
        {
            foreach(Movie m in Movie.ListMovie)
            {
                if(m.Id == idMovie)
                {
                    labelTitle.Text = m.Title;
                    labelMovieType.Text = m.MovieType.ToString();

                }
            }
        }
    }
}
