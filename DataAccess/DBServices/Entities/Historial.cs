using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.DBServices.Entities
{
    public class Historial
    {
        ConnectionToSql conexion;
        public Historial()
        {
            conexion = new ConnectionToSql();

        }
        public void TraerTodos(DataGridView table)
        {
            conexion.con = new SqlConnection(conexion.cadenaConexion);
            conexion.adpt = new SqlDataAdapter("select * from historial", conexion.con);
            conexion.dt = new DataTable();
            conexion.adpt.Fill(conexion.dt);
            table.DataSource = conexion.dt;
        }
    }
}
