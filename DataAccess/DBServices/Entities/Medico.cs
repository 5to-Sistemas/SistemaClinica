using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess.DBServices.Entities
{
    public class Medico
    {
        #region ->Atributos
        public int idmedico { get; set; }
        public int ci { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string diahabiles { get; set; }
        public string HorarioInicio { get; set; }
        public string HorarioFin { get; set; }
        public string especialidad { get; set; }
        #endregion

        ConnectionToSql cx;
        public Medico()
        {
            cx = new ConnectionToSql();
        }

        public DataSet SelectAll()
        {
            cx.con = new SqlConnection(cx.cadenaConexion);
            cx.adpt = new SqlDataAdapter("select * from medico" +
                "", cx.con);
            DataSet ds = new DataSet();
            cx.adpt.Fill(ds);
            return ds;
        }
    }
}
