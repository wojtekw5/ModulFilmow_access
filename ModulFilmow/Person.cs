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
         int id { get; set; }
         string firstName { get; set; }
         string lastName { get; set; }
         DateTime bornDate { get; set; }

        //public Person(string f, string l, DateTime b)
        //{
        //    firstName = f;
        //    lastName = l;
        //    bornDate = b;
        //}

        public static List<Person> listPerson = new List<Person>();

        public static Dictionary<int, Person> PersonMap = new Dictionary<int, Person>();
        public static List<Person> ListPerson
        {
            get
            {
                return listPerson;
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
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }


        public DateTime BornDate
        {
            get
            {
                return bornDate;
            }

            set
            {
                bornDate = value;
            }
        }

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

        public string toString()
        {
            return this.firstName + " " + this.lastName;
        }

        public static void addPerson(String firstName, String lastName, DateTime bornDate)
        {


            OleDbConnection conn = new OleDbConnection(MainForm.connectionString);

            try
            {
                conn.Open();
                String query = "INSERT INTO Person(firstNAME, lastNAME, bornDate) VALUES('" + firstName + "', '" + lastName + "', '" + bornDate + "')";

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

        public static void getPerson()
        {
            listPerson.Clear();

            string strSQL = "SELECT * FROM Person";

            OleDbConnection connection = new OleDbConnection(MainForm.connectionString);

            OleDbCommand command = new OleDbCommand(strSQL, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    Person p = new Person((int)reader[0], reader[1].ToString(), reader[2].ToString(), (DateTime)reader[3]);
                    ListPerson.Add(p);
                    PersonMap.Add(p.id, p);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        public static void DeletePerson(int idPersonTYPE)
        {
            listPerson.Clear();

            string strSQL = "DELETE * FROM Person Where person_ID=" + idPersonTYPE;

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
