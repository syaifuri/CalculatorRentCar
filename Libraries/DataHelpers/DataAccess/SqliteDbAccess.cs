using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraries.DataHelpers.DataAccess
{
   public class SqliteDbAccess: IDisposable
    {
        #region Constructor and implement IDisposeable

        private Component component = new Component();// Other managed resource this class uses.        
        private bool disposed = false;// Track whether Dispose has been called.

        // The class constructor.
        public SqliteDbAccess() {
            SqlitePath();
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
        ~SqliteDbAccess()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(false) is optimal in terms of readability and maintainability.
            Dispose(false);
        }
        #endregion Constructor and implement IDisposable

        private IDbConnection SqlLiteDbConnection;

        /// <summary>
        /// Query used for CRUD (read data -view Select / Get table data )
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public IEnumerable<T> Get<T>(string query, Dictionary<string, object> dictionary)
        {
            IEnumerable<T> entities = null;
            var conn = SqlLiteDbConnection;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    entities = conn.Query<T>(query, new DynamicParameters(dictionary));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return entities;
        }

        /// <summary>
        /// Query used for CRUD (execute create/insert, update, delete )
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public int Execution(string query, Dictionary<string, object> dictionary)
        {
            int hasil = 0;
            var conn = SqlLiteDbConnection;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    hasil = conn.Execute(query, new DynamicParameters(dictionary));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return hasil;
        }


        /// <summary>
        /// Path to get location sqlite db location connection strings
        /// </summary>
        /// <returns></returns>
        public string SqlitePath()
        {
            string data = System.IO.Directory.GetCurrentDirectory() + @"\Data";
            if (!System.IO.File.Exists(data + @"\data.db"))
            {
                data = data + @"\data.db";
                SQLiteConnection.CreateFile(data);

                data = "Data Source = " + data;

            }
            else
            {
                data = data + @"\data.db";
                data = "Data Source = " + data;
            }
            SqlLiteDbConnection = new SQLiteConnection(data);
            return data;

        }
    }
}
