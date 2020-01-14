using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTemplate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void ExceptionTest()
        {
            try
            {
                //En metode der smider en exception
                Assert.Fail(); // If it gets to this line, no exception was thrown.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
