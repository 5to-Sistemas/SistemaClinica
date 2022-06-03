using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionSQL
    {
        public string stringcone = "Data Source=PCEDU;Initial Catalog=SAPSDB;Integrated Security=True";
        public SqlConnection Conexion = new SqlConnection("Data Source=PCEDU;Initial Catalog=SAPSDB;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        public string getstringconexion()
        {
            return stringcone;
        }
    }
}
