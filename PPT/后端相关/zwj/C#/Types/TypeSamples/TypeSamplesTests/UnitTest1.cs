using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeSamples
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanCastTests()
        {
            Manager m = new Manager();
            Employee e = (Employee)m;
            Assert.AreEqual(e, m);
        }

        [TestMethod]
        //[ExpectedException(typeof(InvalidCastException))]
        public void CannotCastTests()
        {
            Staff s = new Staff();
        //    Manager m = (Manager)s;

        }

        
    }
}
