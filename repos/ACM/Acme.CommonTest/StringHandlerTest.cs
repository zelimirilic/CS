using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            
            var source = "ScrewDriver";
            var expected = "Screw Driver";

            //Act
            var actual = source.InsertSpaces();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //Arrange
            
            var source = "Screw Driver";
            var expected = "Screw Driver";

            //Act
            var actual = source.InsertSpaces();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
