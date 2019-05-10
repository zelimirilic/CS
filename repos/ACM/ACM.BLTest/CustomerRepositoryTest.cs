using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExixting()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddres = "zelimir.ilic@gmail.com",
                FirstName = "Zelimir",
                LastName = "Ilic"
            };
            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.EmailAddres, actual.EmailAddres);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);

        }
        [TestMethod]
        public void RetrieveExixtingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddres = "zelimir.ilic@gmail.com",
                FirstName = "Zelimir",
                LastName = "Ilic",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Majke Jevrosime bb",
                        StreetLine2 = "selo Zuce",
                        City = "Beograd",
                        State = "Srbija",
                        PostalCode = "11000",
                        Country = "Srbija"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Rige od Fere 3",
                        City = "Beograd",
                        State = "Srbija",
                        PostalCode = "11000",
                        Country = "Srbija"
                    }
                }

            };
            //Act
            var actual = customerRepository.Retrieve(1);
            //Assert
            Assert.AreEqual(expected.EmailAddres, actual.EmailAddres);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            }
        }
    }
};


