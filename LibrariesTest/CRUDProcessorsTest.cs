using System;
using System.Collections.Generic;
using Libraries.DataHelpers.DataAccess;
using Libraries.DataHelpers.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace LibrariesTest
{
    [TestClass]
   public class CRUDProcessorsTest
    {
        private AttributesObject obj = new AttributesObject();

        [TestMethod]
        public void GetAllCarsTest()
        {
            //Arrange
            var bm = new CRUDProcessors();

            //Act
            obj.CarModels = bm.GetAllCars();

            //Assert
            
            Assert.IsNotNull(obj.CarModels);
            bm.Dispose();
        }
    }
}
