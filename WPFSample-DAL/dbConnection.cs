using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPFSample_DAL
{
    public class dbConnection
    {
        /// <summary>
        /// Abre una conexión con los valores por defecto
        /// </summary>
        public dbConnection()
        {
            String connectionString = "Server=localhost;"+
                "Database=Primitiva;"+
                "User Id=prueba;"+
                "Password = 123; ";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString=connectionString;
            conn.Open();
        }


    }
}
