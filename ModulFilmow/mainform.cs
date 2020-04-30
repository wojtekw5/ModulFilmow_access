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
    public partial class MainForm : Form
    {

        public static string connectionString = @"Provider =Microsoft.ACE.OLEDB.12.0; Data source=danefilmy.accdb";

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            var formAddMovies = new formAddMovies("AddMode");
            formAddMovies.Show();




        }

        private void Main_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void refresh()
        {
            PersonType.getPersonTYPE();
            Person.getPerson();
            MovieState.getMovieState();
            MovieType.getMovieType();
            Movie.getMovies();

            dataGridViewMovies.Rows.Clear();

            foreach(Movie m in Movie.ListMovie)
            {       
                    int w = dataGridViewMovies.Rows.Add(m.Title.ToString(), m.Description.ToString(), m.Id);
                dataGridViewMovies.Rows[w].Tag = m;
            }
        }

        private void buttontech5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewMovies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridViewMovies.CurrentRow.Cells[2].Value;
            var formMovieInfo = new formMovieInfo(id);
            formMovieInfo.Show();
            

        }
    }
}
