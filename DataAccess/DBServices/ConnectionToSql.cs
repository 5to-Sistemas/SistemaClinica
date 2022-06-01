using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices
{
    public abstract class ConnectionToSql
    {
        /// <summary>
        /// Esta clase abstracta es responsable de establecer la cadena de conexion
        /// y obtener la conexion a SQL.
        /// </summary>
        /// 

        private readonly string connectionString;//Obtiene o establece la cadena de conexión.
        
        public ConnectionToSql()
        {
            //Establecer la cadena de conexión.
            connectionString = "Server= DESKTOP-793T557\\SQLEXPRESS; DataBase= SAPSDB; Integrated Security=True";
        }
        protected SqlConnection GetConnection()
        {
            //Este métedo se encarga de establecer y devolver el objeto de conexión a SQL Server.
            return new SqlConnection(connectionString);
        }

    }
}
