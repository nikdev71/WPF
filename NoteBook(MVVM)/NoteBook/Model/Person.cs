using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Model
{
    internal class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            return string.Concat(Name, " ", Adress, " ",Phone);
        }
    }
}
