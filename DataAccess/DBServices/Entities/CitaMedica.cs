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

        public void SelectAll(DataGridView table)
        {
            cx.con = new SqlConnection(cx.cadenaConexion);
            cx.adpt = new SqlDataAdapter("select * from Medicamento", cx.con);
            cx.dt = new DataTable();
            cx.adpt.Fill(cx.dt);
            table.DataSource = cx.dt;
        }

    }
}
