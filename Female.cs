using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Female : Person
    {
        public Female(string _firstName, string _lastName)
               : base(_firstName, _lastName)
        {

        }

        public override string GetName()
        {
            return "Miss. \t" + FirstName + "\t " + LastName;
        }
    }
}
