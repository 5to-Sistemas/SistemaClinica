using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices
{
    public class PatientsDA : ConnectionToSql
    {
        private ConexionSQL conexion = new ConexionSQL();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM paciente";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;



        }
        
        
        public DataTable obtenertablade1pacinte(int idpaci)
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM paciente WHERE idpaciente=@idpaciente";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpaciente", idpaci);
            leer = comando.ExecuteReader();
            dt.Load(leer);
            conexion.CerrarConexion();
            return dt;

        }

        public DataTable obtenertablade1usuario(int iduser)
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Users WHERE id=@idusuario";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idusuario", iduser);
            leer = comando.ExecuteReader();
            dt.Load(leer);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
            return dt;

        }

        public void Insertar(int idpaciente, int ci,string direccion, DateTime fecha,string tiposangre,int telefono, string sexo, string estadocivil,byte estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO paciente" +
                " VALUES(@idpaciente,@ci,@direccion," +
                "@fecha,@tiposangre,@telefono,@sexo" +
                ",@estadocivil,@estado)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpaciente", idpaciente);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@tiposangre", tiposangre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@sexo", sexo);
            comando.Parameters.AddWithValue("@estadocivil", estadocivil);
            comando.Parameters.AddWithValue("@estado", estado);
            

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(int idpaciente, int ci, string direccion, DateTime fecha, string tiposangre, int telefono, string sexo, string estadocivil, byte estado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update paciente set idpaciente=@idpaciente, " +
                "ci=@ci, direccion=@direccion, " +
                "fechanac=@fechanac, tiposangre=@tiposangre, telefono=@telefono, " +
                "sexo=@sexo, estadocivil=@estadocivil, estado=@estado where idpaciente=@idpaciente";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpaciente", idpaciente);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@fechanac", fecha);
            comando.Parameters.AddWithValue("@tiposangre", tiposangre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@sexo", sexo);
            comando.Parameters.AddWithValue("@estadocivil", estadocivil);
            comando.Parameters.AddWithValue("@estado", estado);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idpaciente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from paciente where idpaciente=@idpaciente";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpaciente", idpaciente);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
