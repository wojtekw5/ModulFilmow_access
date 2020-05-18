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
using System.Data.OleDb;

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
            var formAddMovies = new formAddMovies();
            formAddMovies.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            getMovies();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        public void getMovies()
        {

            string strSQL = "SELECT Movie_ID, Movie_title, Movie_description FROM Movie";

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Movie m = new Movie(reader[1].ToString(), reader[2].ToString(), (int)reader[0]);
                    int w = dataGridViewMovies.Rows.Add(m.Title.ToString(), m.Description.ToString(), m.Id);
                    dataGridViewMovies.Rows[w].Tag = m;

                }
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
