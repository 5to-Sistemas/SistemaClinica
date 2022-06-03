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
    public class MedicalDA
    {
        private ConexionSQL conexion = new ConexionSQL();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM medico";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;



        }


        public DataTable obtenertablade1medico(int idmedico)
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM medico WHERE idmedico=@idmedico";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idmedico", idmedico);
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

        public string obtenerIDde1usuario(string userName)
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Users WHERE userName=@userName";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@userName", userName);
            leer = comando.ExecuteReader();
            dt.Load(leer);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
            return dt.Rows[0][0].ToString();

        }


        public void Insertar(int idmedico, int ci, string direccion, int telefono, string diahabiles, string HorarioInicio, string HorarioFin, string especialidad, string sexo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO medico" +
                " VALUES(@idmedico,@ci,@direccion," +
                "@telefono,@diahabiles,@HorarioInicio,@HorarioFin" +
                ",@especialidad,@sexo)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idmedico", idmedico);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@diahabiles", diahabiles);
            comando.Parameters.AddWithValue("@HorarioInicio", HorarioInicio);
            comando.Parameters.AddWithValue("@HorarioFin", HorarioFin);
            comando.Parameters.AddWithValue("@especialidad", especialidad);
            comando.Parameters.AddWithValue("@sexo", sexo);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(int idmedico, int ci, string direccion, int telefono, string diahabiles, string HorarioInicio, string HorarioFin, string especialidad, string sexo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update medico set idmedico=@idmedico, " +
                "ci=@ci, direccion=@direccion, " +
                "telefono=@telefono, diahabiles=@diahabiles, HorarioInicio=@HorarioInicio, " +
                "HorarioFin=@HorarioFin, especialidad=@especialidad, sexo=@sexo where idpaciente=@idpaciente";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idmedico", idmedico);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@diahabiles", diahabiles);
            comando.Parameters.AddWithValue("@HorarioInicio", HorarioInicio);
            comando.Parameters.AddWithValue("@HorarioFin", HorarioFin);
            comando.Parameters.AddWithValue("@especialidad", especialidad);
            comando.Parameters.AddWithValue("@sexo", sexo);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idmedico)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from medico where idmedico=@idmedico";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idmedico", idmedico);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
