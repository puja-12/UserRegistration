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
            Console.WriteLine("Welcome to User Registration Problem Using REGEX!");

            UserRegistration userRegistration = new UserRegistration();
            userRegistration.FirstName();
        }
    }
}