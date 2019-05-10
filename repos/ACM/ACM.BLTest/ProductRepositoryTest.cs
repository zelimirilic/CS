using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            Product product = new Product();

            object myObj = new object();
            Console.WriteLine("Object: " + myObj.ToString());
            Console.WriteLine("Product: " + product.ToString());
        }
    }
}
