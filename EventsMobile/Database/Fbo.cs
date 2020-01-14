using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EventsMobile.Database
{
    public class Fbo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string SecondName { get; set; }

    }
}
