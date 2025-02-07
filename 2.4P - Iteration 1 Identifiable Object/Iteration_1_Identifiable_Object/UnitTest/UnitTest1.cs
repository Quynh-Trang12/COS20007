using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iteration_1_Identifiable_Object; // Correct namespace

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Identifiable_Object obj; // Correct class name

        [TestMethod]
        public void TestMethod1()
        {
            // Example test method
            string[] identifiers = { "id1", "id2" };
            obj = new Identifiable_Object(identifiers);
            Assert.IsTrue(obj.AreYou("id1"));
        }
    }
}