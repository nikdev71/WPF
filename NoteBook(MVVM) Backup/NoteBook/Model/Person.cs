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
        public int Phone { get; set; }

        public Person(string name, string adress, int phone)
        {
            Name = name;
            Adress = adress;
            Phone = phone;
        }
    }
}
