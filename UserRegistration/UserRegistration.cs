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

        public bool FirstName(string Fname)
        {
            bool status;

            
            string firstname = "^[A-Z]{1}[a-z]{2}";
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(Fname))
            {
                status = true;

                Console.Write("Name is Valid \n");
            }
            else
            {
                status = false;

                Console.Write("Plase Enter First Letter Capital \n");
            }
            return status;

        }
        public bool LastName(string Lname)
        {
            bool status;

            string lastname = "^[A-Z]{1}[a-z]{2}";
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(Lname))
            {
                status = true;

                Console.Write("Name is Valid \n");
            }
            else
            {
                status = false;

                Console.Write("Plase Enter valid Last Name \n");
            }
            return status;


        }
        public bool Email(string email)
        {
            bool status;
            string emailID = "^[a-z]+(.[a-z])+@[A-Za-z]+.[a-z]{2,3}(.[a-z]{2})?$";
            Regex regex = new Regex(emailID);

            if (regex.IsMatch(email))
            {
                status = true;

                Console.Write("EmailID is Valid \n");
            }
            else
            {
                status = false;

                Console.Write("Plase Enter valid EmailID \n");
            }
            return status;



        }
        public bool MobileNumber(string Mnumber)
        {
            bool status;
            var mobilenumber = "^[0-9]{2}\\s[0-9]{10}$";

            Regex regex = new Regex(mobilenumber);

            if (regex.IsMatch(Mnumber))
            {
                status = true;

                Console.Write("Mobile Number is Valid \n");
            }
            else
            {
                status = false;

                Console.Write("Please Enter valid Mobile Number \n");
            }
            return status;


        }
        public bool Password(string Pass)
        {
            bool status;
            var password = "^[A-Za-z0-9]{8,}$";

            Regex regex = new Regex(password);

            if (regex.IsMatch(Pass))
            {
                status = true;

                Console.Write("Password is Valid \n");
            }
            else
            {
                status = false;

                Console.Write("Please Enter valid Password \n");
            }
            return status;


        }
        public bool PasswordRule2(string Pass2)
        {
            bool status;

            var passwordRule2 = "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$";

            Regex regex = new Regex(passwordRule2);

            if (regex.IsMatch(Pass2))
            {
                status = true;

                Console.Write("Password is Valid \n");
            }
            else
            {
                status = false;

                Console.Write("Please Enter valid Password \n");
            }
            return status;


        }
        public bool PasswordRule3(string Pass3)
        {
            bool status;
            var passwordRule3 = "^(?=.*[0-9])[A-Za-z0-9]{8,}$";

            Regex regex = new Regex(passwordRule3);

            if (regex.IsMatch(Pass3))
            {
                status = true;

                Console.Write("Password is Valid \n");
            }
            else
            {
                status = false;

                Console.Write("Please Enter valid Password \n");
            }
            return status;


        }
        public bool PasswordRule4(string Pass4)
        {
            bool status;

            var passwordRule4 = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";

            Regex regex = new Regex(passwordRule4);

            if (regex.IsMatch(Pass4))
            {
                status = true;

                Console.Write("Password is Valid \n");
            }
            else
            {
                status = false;

                Console.Write("Please Enter valid Password \n");
            }
            return status;


        }
    }
}
        
    

