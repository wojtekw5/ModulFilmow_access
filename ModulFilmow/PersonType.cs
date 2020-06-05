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
        int id;
        string name;

        public int Id { get => id; set => id = value; }
        
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return name;
        }


        public static void addPersonType(String name)
        {
            String query = "INSERT INTO PersonType(personTYPE_NAME) VALUES('" + name + "')";

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
                Console.WriteLine(ex.Message);
                conn.Close();

            }
            conn.Close();
        }

        public static void DeletePersonTYPE(int idPersonTYPE)
        {
            string strSQL = "DELETE * FROM PersonTYPE Where personTYPE_ID=" + idPersonTYPE;

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
