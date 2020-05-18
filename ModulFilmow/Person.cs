using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using ModulFilmow;

namespace ClassLibrary
{
    public class Person
    {
        int id;
        string firstName;
        string lastName;
        DateTime bornDate;

        public int Id { get => id; set => id = value; }

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public DateTime BornDate { get => bornDate; set => bornDate = value; }
        

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }


        public Person(int id, string firstName, string lastName, DateTime bornDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.bornDate = bornDate;
        }
        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public static void addPerson(String firstName, String lastName, DateTime bornDate)
        {
            String query = "INSERT INTO Person(firstNAME, lastNAME, bornDate) VALUES('" + firstName + "', '" + lastName + "', '" + bornDate + "')";

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

        public static void DeletePerson(int idPersonTYPE)
        {
            string strSQL = "DELETE * FROM Person Where person_ID=" + idPersonTYPE;

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
