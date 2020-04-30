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
            refresh();
        }

        void refresh()
        {
            List<MoviePerson> listMoviePerson = MoviePerson.getMoviePerson(idMovie);

            foreach(Movie m in Movie.ListMovie)
            {
                if(m.Id == idMovie)
                {
                    labelTitle.Text = m.Title;
                    labelMovieType.Text = m.MovieType.ToString();
                    labelMovieState.Text = m.MovieState.ToString();
                    labelMovieLength.Text = m.MovieTime.ToString();

                    if(m.FlgVR) { labelVR.Text = "Yes"; }
                    if(m.Flg2D) { label2D.Text = "Yes"; }
                    if(m.Flg3D) { label3D.Text = "Yes"; }

                    richTextBoxDescription.Text = m.Description;

                    dataGridViewPeoplesInInformation.Rows.Clear();
                    foreach(MoviePerson mpp in listMoviePerson)
                    {
                        if(mpp.Movie.Id == idMovie)
                        {
                            int w = dataGridViewPeoplesInInformation.Rows.Add(mpp.Person.ToString(), mpp.PersonType.ToString());
                            dataGridViewPeoplesInInformation.Rows[w].Tag = mpp;
                        }
                    }

                }
            }
        }
    }
}
