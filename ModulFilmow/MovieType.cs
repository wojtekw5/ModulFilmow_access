using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ModulFilmow;
using System.Data.OleDb;

namespace ClassLibrary
{
    public class MovieType
    {
        int id;
        string name;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }
       
        public override string ToString()
        {
            return name;
        }

    }
}
