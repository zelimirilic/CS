using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddres = "zelimir.ilic@gmail.com",
                FirstName = "Zelimir",
                LastName = "Ilic",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Tulips",
                ProductDescription = "Made in Netherland",
                CurrentPrice = 11.23M
            };
            changedItems.Add(product);

            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert
            
        }
    }
}
