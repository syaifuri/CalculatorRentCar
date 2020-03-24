using System;
using Libraries.DataHelpers.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibrariesTest
{
    [TestClass]
    public class TransactionProcessorTest
    {
        private AttributesObject obj = new AttributesObject();

        [TestMethod]
        public void GetDiscountValueTest()
        {
            //Arrange
            var bm = new TransactionProcessor();
            obj.VarInput0 = 3; // days length
            obj.VarInput01 = 2; // car qty
            obj.VarInput02 = 2009; // year of car model
            obj.VarOutput = 22;

            //Act
            obj.VarExpected = bm.GetDiscountValue(obj.VarInput0, obj.VarInput01,  obj.VarInput02);

            //Assert
            Assert.AreEqual(obj.VarOutput, obj.VarExpected);
            bm.Dispose();
        }
    }
}
