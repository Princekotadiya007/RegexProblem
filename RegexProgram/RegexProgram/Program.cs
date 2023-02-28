using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegexPrograms regex = new RegexPrograms();
            regex.ValidateFirstName("Prince");
            Console.ReadLine();
        }
    }
}
