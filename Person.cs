using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Person
    {
        private string name;
        private string surname;
        private string phoneNumber;

        public Person() { }
        public Person(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
