using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_with_Listbox
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public User(string name,string surname,string email,string phone,DateTime birthdate)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            BirthDate = birthdate;
        }
        public User()
        {

        }
        public override string ToString()
        {
            return $"{Name},{Surname},{Email},{Phone},{BirthDate}";
        }
    }
}
