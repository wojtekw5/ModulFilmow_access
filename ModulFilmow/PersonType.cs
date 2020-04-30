using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using ModulFilmow;
namespace ClassLibrary
{
    public class PersonType
    {
        int id { get; set; }
        private string name { get; set; } //nazwa wykonywanej roli w filmie, aktor itp

        public static List<PersonType> listPersonType = new List<PersonType>();

        public static Dictionary<int, PersonType> MapPersonType = new Dictionary<int, PersonType>();

        //public PersonType(string n)
        //{
        //    name = n;
        //}

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

        public static List<PersonType> ListPersonType
        {
            get
            {
                return listPersonType;
            }
        }

        public string toString()
        {
            return this.name;
        }

        public override string ToString()
        {
            return name;
        }


        public static void addPersonType(String name)
        {


            OleDbConnection conn = new OleDbConnection(MainForm.connectionString);

            try
            {
                conn.Open();
                String query = "INSERT INTO PersonType(personTYPE_NAME) VALUES('" + name + "')";

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

        public static void DownloadPersonTYPE()
        {
            listPersonType.Clear();

            string strSQL = "SELECT * FROM PersonTYPE";

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);

            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PersonType pt = new PersonType();
                    pt.id = (int)reader[0];
                    pt.name = reader[1].ToString();
                    ListPersonType.Add(pt);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }




        }

        public static void DeletePersonTYPE(int idPersonTYPE)
        {
            listPersonType.Clear();

            string strSQL = "DELETE * FROM PersonTYPE Where personTYPE_ID=" + idPersonTYPE;

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);

            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }



        }

    }
}
