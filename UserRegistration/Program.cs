// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace UserRegistration
{
    public class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please choose the option :\n1)Validating FirstName\n2)Validating LastName\n3)validate Email\n4)Mobile number Validation\n5)Password Validation");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserRegistration userRegistration = new UserRegistration();
                        userRegistration.FirstName();
                        break;
                    case 2:
                        UserRegistration userRegistration1 = new UserRegistration();
                        userRegistration1.LastName();
                        break;
                    case 3:
                        UserRegistration user = new UserRegistration();
                        user.Email();
                        break;
                    case 4:
                        UserRegistration Mobile = new UserRegistration();
                        Mobile.MobileNumber();
                        break;
                    case 5:
                        UserRegistration Pas = new UserRegistration();
                        Pas.Password();
                        break;
                }
            }
        }
    }
}