using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class RegexPrograms
    {
        public void ValidateFirstName(string name)
        {
            //Prince
            string firstName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, firstName))
            {
                Console.WriteLine("First name is matching with Regex");
            }
            else
            {
                Console.WriteLine("First name is not matcging with Regex");
            }
        }
        public void ValidateLastName(string name)
        {
            string LastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, LastName))
            {
                Console.WriteLine("Last name is matching with Regex");
            }
            else
            {
                Console.WriteLine("Last name is not matcging with Regex");
            }
        }
    }
}
