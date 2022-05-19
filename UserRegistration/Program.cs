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
                Console.WriteLine("Please choose the option :\n1)Validating FirstName\n2)Validating LastName\n3)validate Email\n4)Mobile number Validation\n5)Password Validation\n6)passwrd with atleast one upper case\n7)password with atleast one numeric value\n8)password with atleast one special Character\n9)email pattern Validation");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string Firstname = Console.ReadLine();
                        UserRegistration userRegistration = new UserRegistration();
                        userRegistration.FirstName(Firstname);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string Lastname = Console.ReadLine();
                        UserRegistration userRegistration1 = new UserRegistration();
                        userRegistration1.LastName(Lastname);
                        break;
                    case 3:
                        Console.WriteLine("Enter EmailID");
                        string EmailID = Console.ReadLine();
                        UserRegistration user = new UserRegistration();
                        user.Email(EmailID);
                        break;
                    case 4:
                        Console.WriteLine("Enter MobileNumber");
                        var MobileNumber = (Console.ReadLine());
                        UserRegistration Mobile = new UserRegistration();
                        Mobile.MobileNumber(MobileNumber);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        var Password = (Console.ReadLine());
                        UserRegistration Pas = new UserRegistration();
                        Pas.Password(Password);
                        break;
                    case 6:
                        Console.WriteLine("Enter Password");
                        var Password2 = (Console.ReadLine());
                        UserRegistration Pas1 = new UserRegistration();
                        Pas1.PasswordRule2(Password2);
                        break;
                    case 7:
                        Console.WriteLine("Enter Password");
                        var Password3 = (Console.ReadLine());
                        UserRegistration Pas2 = new UserRegistration();
                        Pas2.PasswordRule3(Password3);
                        break;
                    case 8:
                        Console.WriteLine("Enter Password");
                        var Password4 = (Console.ReadLine());
                        UserRegistration Pas3 = new UserRegistration();
                        Pas3.PasswordRule4(Password4);
                        break;
                    case 9:
                        EmailValidation emailValidation = new EmailValidation();
                        emailValidation.EmailID();
                        break;
                }
            }
        }
    }
}