using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vsosample;

namespace vsosample.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var person = new vsosample.Person { Name = "Hoge" };
            Assert.AreEqual("Hoge", person.SayName());
        }
    }
}
