using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DataAccess.DBServices
{
    public class ConnectionToSql
    {
        /// <summary>
        /// Esta clase abstracta es responsable de establecer la cadena de conexion
        /// y obtener la conexion a SQL.
        /// </summary>
        /// 

        public readonly string cadenaConexion;//Obtiene o establece la cadena de conexión.
        private OleDbConnection conectar;
        public SqlConnection con;
        public SqlDataAdapter adpt;
        public DataTable dt;
        public ConnectionToSql()
        {
            //Establecer la cadena de conexión.
            cadenaConexion = "data source=AR13L\\SQLEXPRESS;initial catalog=SAPSDB;Integrated Security=true";
            con = new SqlConnection(@"data source=AR13L
\\SQLEXPRESS;initial catalog=SAPSDB;Integrated Security=true");
        }
        protected SqlConnection GetConnection()
        {
            //Este métedo se encarga de establecer y devolver el objeto de conexión a SQL Server.
            return new SqlConnection(cadenaConexion);
        }  
        protected OleDbConnection Abrir()     // La clase OleDbConnection representa una conexión abierta con una fuente de datos.
        {
            conectar = new OleDbConnection(cadenaConexion);//Inicializa una nueva instancia de la clase OleDbConnection con la cadena de conexión especificado.
            try
            {
                conectar.Open(); //Abre una conexión de base de datos con los valores de propiedades especificadas por la cadena de conexion. 
                return (conectar);
            }
            catch
            {
                return null;
            }
        }
        public int Ejecutar(string consulta)   //Se usará para INSERT, DELETE O UPDATE, etc.
        {
            OleDbCommand comando = new OleDbCommand(consulta, Abrir());  //La clase OleDbCommand, representa una instrucción SQL o un procedimiento almacenado para ejecutar un origen de datos.
            int rpta = comando.ExecuteNonQuery();   //Ejecuta una sentencia de SQL en la conexión y devuelve el número de filas afectadas. 
            Cerrar();                            //Cierra la Conexión
            return (rpta);
        }
        public DataSet Consultar(string consulta)    //Se usará para SELECT
                                                     // La clase DataSet representa una caché de datos en memoria.
        {                                       // La clase OleDbDataAdapter, representa un conjunto de comandos de datos y una conexión de base de datos que se utilizan para rellenar el conjunto de datos y actualizar la fuente de datos.
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, Abrir()); // constructor OleDbDataAdapter(String, OleDbConnection). Inicializa una nueva instancia de la clase OleDbDataAdapter con un SelectCommand
            DataSet dt = new DataSet();
            adaptador.Fill(dt);         //Fill(DataSet),añade o renueva filas en el conjunto de datos. 
            
            Cerrar();                   //Cierra la Conexión
            return (dt);
        }
        private void Cerrar()
        {
            conectar.Close();
        }
    }
}
