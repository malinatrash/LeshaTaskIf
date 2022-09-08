using System;
using LeshaTaskIf;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FirstNumberBiggest()
        {
            var number = 321;
            var response = Logic.Calculate(number);
            Assert.AreEqual(3, response);
        }
        [Test]
        public void SecondNumberBiggest()
        {
            var number = 231;
            var response = Logic.Calculate(number);
            Assert.AreEqual(3, response);
        }
        [Test]
        public void ThirdNumberBiggest()
        {
            var number = 123;
            var response = Logic.Calculate(number);
            Assert.AreEqual(3, response);
        }
    }
}