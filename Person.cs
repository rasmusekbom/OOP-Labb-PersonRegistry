using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Person : IComparable<Person>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract string GetName();

        public int CompareTo(Person other) //Sorterar namn i efternamnsordning, därefter förnamnsordning.
        {
            int result = LastName.CompareTo(other.LastName);
            if (result is 0)
            {
                result = FirstName.CompareTo(other.FirstName);
            }
            return result;
        }

        public override string ToString()
        {
            return GetName();
        }
    }
}
