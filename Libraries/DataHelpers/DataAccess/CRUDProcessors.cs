using Libraries.DataHelpers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.DataHelpers.DataAccess
{
   public class CRUDProcessors :IDisposable
    {
        #region Constructor and implement IDisposeable

        private Component component = new Component();// Other managed resource this class uses.        
        private bool disposed = false;// Track whether Dispose has been called.

        // The class constructor.
        public CRUDProcessors()
        {
         
        }

        // Implement IDisposable.Do not make this method virtual.A derived class should not be able to override this method.
        public void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue and prevent finalization code for this object from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources can be disposed.
        // If disposing equals false, the method has been called by the 
        // runtime from inside the finalizer and you should not reference 
        // other objects. Only unmanaged resources can be disposed.
        private void Dispose(bool disposing)
        {
            if (!this.disposed)// Check to see if Dispose has already been called.
            {
                // If disposing equals true, dispose all managed and unmanaged resources.
                if (disposing)
                {
                    component.Dispose();// Dispose managed resources.
                }
            }
            disposed = true;
        }

        // Use C# destructor syntax for finalization code.
        // This destructor will run only if the Dispose method does not get called.
        // It gives your base class the opportunity to finalize.
        // Do not provide destructors in types derived from this class.
        /// <summary>
        /// Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
        /// </summary>
        ~CRUDProcessors()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(false) is optimal in terms of readability and maintainability.
            Dispose(false);
        }
        #endregion Constructor and implement IDisposable

        /// <summary>
        /// Query Get All Cars Data
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CarsModel> GetAllCars()
        {
            var db = new SqliteDbAccess();
            string query = "SELECT * FROM CarsModel ";

            IEnumerable<CarsModel> hasil = db.Get<CarsModel>(query, null);
            db.Dispose();
            
            return hasil;
        }

        /// <summary>
        /// Query Get Car data with filter id
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public IEnumerable<CarsModel> GetAllCarsFilter(CarsModel car)
        {
            var db = new SqliteDbAccess();
            string query = "SELECT * FROM CarsModel where Id = @id";

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@id", car.Id);
            IEnumerable<CarsModel> hasil = db.Get<CarsModel>(query, dictionary);

            db.Dispose();

            return hasil;
        }

        /// <summary>
        /// CRUD - Delete Car Data Methode
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public int DeleteCar(CarsModel car)
        {
            var db = new SqliteDbAccess();
            string query = "DELETE FROM CarsModel WHERE Id = @id";

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@id", car.Id);

            int hasil = db.Execution(query, dictionary);

            db.Dispose();

            return hasil;
        }

        /// <summary>
        /// CRUD - Insert Car Data Methode
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public int InsertCar(CarsModel car)
        {
            var db = new SqliteDbAccess();
            string query = "INSERT INTO CarsModel " +
                "(ModelName, SeriesName, ModelYear, NumberCar, CreateDate, RentCost) " +
                "values " +
                "(@modelName, @seriesName, @modelYear, @numberCar, @createDate, @rentCost)";

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@modelName", car.ModelName);
            dictionary.Add("@seriesName", car.SeriesName);
            dictionary.Add("@modelYear", car.ModelYear);
            dictionary.Add("@numberCar", car.NumberCar);
            dictionary.Add("@createDate", car.CreateDate);
            dictionary.Add("@rentCost", car.RentCost);

            int hasil = db.Execution(query, dictionary);

            db.Dispose();

            return hasil;
        }

        /// <summary>
        /// CRUD - Update Car Data Methode
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public int UpdateCar(CarsModel car)
        {
            var db = new SqliteDbAccess();
            string query = "UPDATE CarsModel SET ModelName = @modelName, SeriesName = @seriesName," +
                "  ModelYear = @modelYear, NumberCar = @numberCar, CreateDate = @createDate, RentCost = @rentCost WHERE Id = @id";

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@modelName", car.ModelName);
            dictionary.Add("@seriesName", car.SeriesName);
            dictionary.Add("@modelYear", car.ModelYear);
            dictionary.Add("@numberCar", car.NumberCar);
            dictionary.Add("@createDate", car.CreateDate);
            dictionary.Add("@id", car.Id);
            dictionary.Add("@rentCost", car.RentCost);

            int hasil = db.Execution(query, dictionary);

            db.Dispose();

            return hasil;
        }

    }
}
