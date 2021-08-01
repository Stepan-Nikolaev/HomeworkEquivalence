using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEquivalence
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string DateBirth { get; set; }
        public string PlaceBirth { get; set; }
        public int PassportID { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Person))
            {
                return false;
            }

            Person currentPerson = (Person)obj;

            return PassportID == currentPerson.PassportID;
        }

        public override int GetHashCode()
        {
            return PassportID;
        }
    }
}
