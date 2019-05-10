using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACB.BL_Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Zelimir";
            customer.LastName = "Ilic";
            string expected = "Zelimir Ilic";


            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void LastNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            //customer.FirstName = "Zelimir";
            customer.LastName = "Ilic";
            string expected = " Ilic";


            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void FirstNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Zelimir";
            customer.LastName = "Ilic";
            string expected = "Zelimir Ilic";


            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Ilic";
            customer.EmailAddres = "zelimir.ilic@gmail.com";
            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer();
            //customer.LastName = "Ilic";
            customer.EmailAddres = "zelimir.ilic@gmail.com";
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Ilic";
            //customer.EmailAddres = "zelimir.ilic@gmail.com";
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }

}
