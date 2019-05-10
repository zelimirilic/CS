using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Library.Test
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [Test]
        public void SampleTest1()
        {
            //Arrange
            int input = 1;
            //Action
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("1", output);
        }
        [Test]
        public void SampleTest2([Values(1,2,4,17,34,67,77,88,97)] int input)
        {
            //Arrange
            
            //Action
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void SampleTest3([Values(3,6,9)] int input )
        {
            //Arrange
            
            //Action
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void SampleTest4([Values(5,20)] int input)
        {
            //Arrange
            
            //Action
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void SampleTest5([Values(15,30,45,60,75,90)]int input)
        {
            //Arrange
            
            //Action
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
