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
            bool flge = true;
            RegexPrograms regex = new RegexPrograms();
            while (flge)
            {
                Console.WriteLine("Welcom to User Registration");
                Console.WriteLine("\n1.ValidFirstName,\n2.ValidLastName,\n3.ValidEmaiId,\n4.MoblieNumber,\n5.PasswordRule1,\n6.PasswordRule2,\n7.PasswordRule3,\n8.PasswordRule4,\n9.AllEmailSamples");
                Console.WriteLine("choose the option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //RegexPrograms regex = new RegexPrograms();
                        regex.ValidateFirstName("Prince");
                        break;
                    case 2:
                        regex.ValidateLastName("Kotadiya");
                        break;
                    case 3:
                        regex.ValidEmail("abc.xyz@bridglabz.co.in");
                        break;
                    case 4:
                        regex.PhoneNumber("91 6352129268");
                        break;
                    case 5:
                        regex.ValidatePasswordRule1("Princes7");
                        break;
                    case 6:
                        regex.ValidatePasswordRule2("PRINCES7");
                        break;
                    case 7:
                        regex.ValidatePasswordRule3("PK007PRINCE7");
                        break;
                    case 8:
                        regex.ValidatePasswordRule4("PRINCE07@");
                        break;
                    case 9:
                        regex.AllEmail("abc@yahoo.com");//"abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com"
                        break;
                    case 10:
                        flge = false;
                        break;
                }
            }
        }
    }
}
