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
    public class CitaMedica
    {
        ConnectionToSql cx;
        public CitaMedica(){
            cx = new ConnectionToSql();
        }

        public DataSet SelectAll(DataGridView table)
        {
            cx.con = new SqlConnection(cx.cadenaConexion);
            cx.adpt = new SqlDataAdapter("select * from citamedica" +
                "", cx.con);
            DataSet ds = new DataSet();
            cx.adpt.Fill(ds);
            return ds;
        }

        public DataSet SelectByDate(DataGridView table, DateTime fecha) {
            cx.con = new SqlConnection(cx.cadenaConexion);
            cx.adpt = new SqlDataAdapter("select * from citamedica where fecha='" + fecha +
                "'", cx.con);
            DataSet ds = new DataSet();
            cx.adpt.Fill(ds);
           return ds;
        }

    }
}
