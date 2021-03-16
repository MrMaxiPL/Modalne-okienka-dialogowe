using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modalne_okna_dialogowe
{
    class Person
    {
        public Person(string name, string surname, string birthYear, string town)
        {
            Name = name;
            Surname = surname;
            BirthYear = birthYear;
            Town = town;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthYear { get; set; }
        public string Town { get; set; }

    }
}
