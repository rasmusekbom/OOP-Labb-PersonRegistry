using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Male : Person
    {

        public Male(string _firstName, string _lastName)
               : base(_firstName, _lastName)
        {

        }

        public override string GetName()
        {
            return "Mr. \t" + FirstName + "\t " + LastName;
        }

        public static Person operator +(Female mom, Male dad)
        {
            Child child = new Child(mom.FirstName, dad.LastName);
            child.FirstName = mom.FirstName;
            child.LastName = dad.LastName;
            return child;
        }
    }
}
