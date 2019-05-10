using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Zelimir",
                LastName = "Ilic",
                OrderDate = new DateTimeOffset(2018, 2, 14, 10, 00, 00, new TimeSpan(1, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Majke Jevrosime bb",
                    StreetLine2 = "selo Zuce",
                    City = "Beograd",
                    State = "Srbija",
                    PostalCode = "11000",
                    Country = "Srbija"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                    OrderQuantity = 2,
                    ProductName = "Tulips",
                    PurchasePrice = 12.54M
                    },
                    new OrderDisplayItem()
                    {
                    OrderQuantity = 1,
                    ProductName = "Raketa",
                    PurchasePrice = 6M
                    }
                }

            };


            //Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);

            for(int i=0; i<1; i++)
            {
                Assert.AreEqual(expected.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.OrderDisplayItemList[i].PurchasePrice, actual.OrderDisplayItemList[i].PurchasePrice);

            }

            //Assert

        }
    }
}
