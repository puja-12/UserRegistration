using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration.Tests
{
    [TestClass()]
    public class UserRegistrationTests
    {
        [TestMethod()]
        public void FirstNameTest()
        {

            UserRegistration UR1 = new UserRegistration();
            UR1.FirstName("Pooja");
            Assert.AreEqual(true, UR1.FirstName("Pooja"));
        }



        [TestMethod()]
        public void LastNameTest()
        {
            UserRegistration UR2 = new UserRegistration();
            UR2.LastName("Rana");
            Assert.AreEqual(true, UR2.LastName("Rana"));
        }

        [TestMethod()]
        public void EmailTest()
        {
            UserRegistration UR3 = new UserRegistration();
            UR3.Email("abc.xyz@bl.co.in");
            Assert.AreEqual(true, UR3.Email("abc.xyz@bl.co.in"));
        }

        [TestMethod()]
        public void MobileNumberTest()
        {
            UserRegistration UR4 = new UserRegistration();
            UR4.MobileNumber("91 9919819801");
            Assert.AreEqual(true, UR4.MobileNumber("91 9919819801"));
        }

        [TestMethod()]
        public void PasswordTest()
        {
            UserRegistration UR5 = new UserRegistration();
            UR5.Password("passwordrule1");
            Assert.AreEqual(true, UR5.Password("passwordrule1"));
        }

        [TestMethod()]
        public void PasswordRule2Test()
        {
            UserRegistration UR6 = new UserRegistration();
            UR6.PasswordRule2("PassWordRule2");
            Assert.AreEqual(true, UR6.PasswordRule2("PassWordRule2"));
        }

        [TestMethod()]
        public void PasswordRule3Test()
        {
            UserRegistration UR7 = new UserRegistration();
            UR7.PasswordRule3("PassWordRule3");
            Assert.AreEqual(true, UR7.PasswordRule3("PassWordRule3"));
        }

        [TestMethod()]
        public void PasswordRule4Test()
        {
            UserRegistration UR8 = new UserRegistration();
            UR8.PasswordRule4("PassWordRule@4");
            Assert.AreEqual(true, UR8.PasswordRule4("PassWordRule@4"));
        }
    }
}



