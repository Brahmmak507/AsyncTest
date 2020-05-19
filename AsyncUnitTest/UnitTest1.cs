using System;
using DTSTestAsynch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using customclassLib;

namespace AsyncUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        CustomClass module1Class1 = new CustomClass();
        [TestMethod]
        public async Task TestMethod1()
        {
            var Result = await module1Class1.Method1();
            
            Assert.AreEqual<int>(Result,100 );
        }

        [TestMethod]
        public void TestMethod2()
        {
            
            Assert.AreEqual(1, module1Class1.Method2());
        }
    }
}
