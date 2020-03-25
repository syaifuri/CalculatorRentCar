using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.DataHelpers.Factory
{
   public class TransactionProcessor : IDisposable
    {
        #region Constructor and implement IDisposeable

        private Component component = new Component();// Other managed resource this class uses.        
        private bool disposed = false;// Track whether Dispose has been called.

        // The class constructor.
        public TransactionProcessor()
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
        ~TransactionProcessor()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(false) is optimal in terms of readability and maintainability.
            Dispose(false);
        }
        #endregion Constructor and implement IDisposable


        /// <summary>
        /// Getting Discount value based on logic defined rule
        /// </summary>
        /// <param name="days"></param>
        /// <param name="carQty"></param>
        /// <param name="modelYear"></param>
        /// <returns></returns>
        public decimal GetDiscountValue(int days, int carQty, int modelYear )
        {
            decimal discount = 0;
            // 
            // 1. if rent for 3 days discount 5 %
            if (days >= 3)
            {
                discount += 5;
            }
            // 2. if rent 2 car or more discount 10 %
            if (carQty >= 2)
            {
                discount += 10;
            }
            // 3. if the car built below 2010 discount 7 %
            if (modelYear < 2010)
            {
                discount += 7;
            }
            return discount;
        }


    }
}
