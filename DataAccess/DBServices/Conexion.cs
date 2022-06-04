using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class Conexion
    {
        string cadenaconexion;
        SqlConnection conex;


        #region "Metodos"

        public SqlConnection conectar()
        {
            try
            {
                cadenaconexion = "Data Source=CHEBI\\CHEBISQL;Initial Catalog=SAPSDB;Integrated Security=True";
                conex = new SqlConnection(cadenaconexion);
                conex.Open();

                if (conex.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexion Correcta");
                }

            }
            catch
            {
                MessageBox.Show("Conexion no realizada");
            }
            return conex;
        }

        public void desconectar()
        {
            conex.Close();
        }

        public void EjecutarSql(string consulta)
        {
            this.conectar();
            SqlCommand con = new SqlCommand(consulta, this.conex);
            int filasafectadas = con.ExecuteNonQuery();
            if (filasafectadas > 0)
                MessageBox.Show("Operacion realizada exitosamente", "La base de datos fue modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Operacion no realizada", "La base de datos no modificada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.desconectar();
        }

        public void ActualizarGrid(DataGridView dg, string tabla, string campos, string orden)
        {
            string consulta = "Select " + campos + " from " + tabla + " " + orden;
            System.Data.DataSet mds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conex);
            da.Fill(mds, tabla);
            dg.DataSource = mds;
            dg.DataMember = tabla;

        }

        #endregion
    }
}
