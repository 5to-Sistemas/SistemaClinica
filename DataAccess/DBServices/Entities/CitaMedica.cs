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
        #region -> Atributos
        public int idmedico { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public string sintomas { get; set; }
        #endregion

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

        public int InsertData(int idpaciente,int idmedico,string fecha, string hora, string sintomas) {
            cx.con = new SqlConnection(cx.cadenaConexion);
            SqlCommand cmd = new SqlCommand("insert into citamedica(idpaciente,idmedico,fecha,hora,sintomas) values ("
                + idpaciente + "," + idmedico +","+fecha+","+hora+","+sintomas+")", cx.con);
            int rpta = cmd.ExecuteNonQuery();
            return rpta;
        }

        public int UpdateData(int idpaciente, int idmedico, string fecha, string hora, string sintomas) {
            cx.con = new SqlConnection(cx.cadenaConexion);
            SqlCommand cmd = new SqlCommand("update citamedica set " +
                "idpaciente=" + idpaciente + ", idmedico=" + idmedico + ", fecha=" + fecha + ", hora=" + hora + ", sintomas=" + sintomas + " where idmedico= " + idmedico, cx.con);
            int rpta = cmd.ExecuteNonQuery();
            return rpta;
        }

        public int DeleteData(int idmedico) {
            cx.con = new SqlConnection(cx.cadenaConexion);
            SqlCommand cmd = new SqlCommand("delete from citamedica where idmedico=" + idmedico, cx.con);
            int rpta = cmd.ExecuteNonQuery();
            return rpta;
        }
    }
}
