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


        [TestMethod]
        public void GetAllCarsFilterTest()
        {
            //Arrange
            var bm = new CRUDProcessors();
            var carmodel = new CarsModel();
            carmodel.Id= 7; // this ID value on Table data is Refer to Row 6, Toyota Car Model
            
            //Act
            obj.CarModels = bm.GetAllCarsFilter(carmodel);

            //Assert

            Assert.IsNotNull(obj.CarModels);
            bm.Dispose();
        }

        [TestMethod]
        public void DeleteCarTest()
        {
            //Arrange
            var bm = new CRUDProcessors();
            var carmodel = new CarsModel();
            carmodel.Id = 12; // this ID value on Table data is Refer to Row 11, KIA Car Model
            obj.VarIntOutput = 0;
            //Act
            obj.VarIntOutput = bm.DeleteCar(carmodel);

            //Assert
            Assert.IsTrue(obj.VarIntOutput > 0, "The actual deletion was success on more than 1 row data");

            bm.Dispose();
        }

        [TestMethod]
        public void InsertCarTest()
        {
            //Arrange
            var bm = new CRUDProcessors();
            var carmodel = new CarsModel();
            carmodel.ModelName = "HONDA";
            carmodel.SeriesName = "BRV";
            carmodel.ModelYear = 2009;
            carmodel.NumberCar = "BX 12412 FF";
            carmodel.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            carmodel.RentCost = 460000;

            obj.VarIntOutput = 0;
            //Act
            obj.VarIntOutput = bm.InsertCar(carmodel);

            //Assert
            Assert.IsTrue(obj.VarIntOutput > 0, "The actual Insertion was success on  1 row data");

            bm.Dispose();
        }

        [TestMethod]
        public void UpdateCarTest()
        {
            //Arrange
            var bm = new CRUDProcessors();
            var carmodel = new CarsModel();
            carmodel.Id = 9; // this ID value on Table data is Refer to Row 11, KIA Car Model
            carmodel.ModelName = "HONDA";
            carmodel.SeriesName = "MOBILIO RS";
            carmodel.ModelYear = 2009;
            carmodel.NumberCar = "BX 12236 HH";
            carmodel.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            carmodel.RentCost = 460000;

            obj.VarIntOutput = 0;
            //Act
            obj.VarIntOutput = bm.UpdateCar(carmodel);

            //Assert
            Assert.IsTrue(obj.VarIntOutput > 0, "The actual Update was success on more than 1 row data");

            bm.Dispose();
        }


    }



}
