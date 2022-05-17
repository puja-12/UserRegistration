using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace UserRegistration
{
    public class UserRegistration
    {

        public void FirstName()
        {
            ;
            Console.WriteLine("Enter Name Starting from Capital Letter and has Min 3 character");
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            string firstname = "^[A-Z]{1}[a-z]{2}";
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(Firstname))
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Plase Enter First Letter Capital \n");
            }

        }
        public void LastName()
        {
            Console.WriteLine("Enter Last Number Starting from Capital Letter and has Min 3 character");
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            string lasttname = "^[A-Z]{1}[a-z]{2}";
            Regex regex = new Regex(lasttname);

            if (regex.IsMatch(Lastname))
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Plase Enter valid Last Name \n");
            }

        }
        public void Email()
        {
            Console.WriteLine("Enter Email should be format of E.g. abc.xyz@bl.co.in");
            Console.WriteLine("Enter EmailID");
            string EmailID = Console.ReadLine();
            string emailID = "^[a-z]+(.[a-z])+@[A-Za-z]+.[a-z]{2,3}(.[a-z]{2})?$";
            Regex regex = new Regex(emailID);

            if (regex.IsMatch(EmailID))
            {
                Console.Write("EmailID is Valid \n");
            }
            else
            {
                Console.Write("Plase Enter valid EmailID \n");
            }


        }
        public void MobileNumber()
        {
            Console.WriteLine("Enter MobileNumber");
            var MobileNumber = (Console.ReadLine());
            var mobilenumber = "^[0-9]{2}\\s[0-9]{10}$";

            Regex regex = new Regex(mobilenumber);

            if (regex.IsMatch(MobileNumber))
            {
                Console.Write("Mobile Number is Valid \n");
            }
            else
            {
                Console.Write("Please Enter valid Mobile Number \n");
            }

        }
        public void Password()
        {
            Console.WriteLine("Enter Password");
            var Password = (Console.ReadLine());
            var password = "^[A-Za-z0-9]{8}$";

            Regex regex = new Regex(password);

            if (regex.IsMatch(Password))
            {
                Console.Write("Password is Valid \n");
            }
            else
            {
                Console.Write("Please Enter valid Password \n");
            }

        }
        public void PasswordRule2()
        {
            Console.WriteLine("Enter Password");
            var PasswordRule2 = (Console.ReadLine());
            var passwordRule2 = "^[A-Z]{1}[0-9a-zA-Z]{7,}$";

            Regex regex = new Regex(passwordRule2);

            if (regex.IsMatch(PasswordRule2))
            {
                Console.Write("Password is Valid \n");
            }
            else
            {
                Console.Write("Please Enter valid Password \n");
            }

        }
    }
}

        
    

