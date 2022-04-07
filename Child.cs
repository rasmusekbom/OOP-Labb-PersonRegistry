using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Child : Person
    {
        public Child(string _firstName, string _lastName)
               : base(_firstName, _lastName)
        {

        }

        public override string GetName()
        {
            return "Child. \t" + FirstName + "\t " + LastName;
        }
    }
}
