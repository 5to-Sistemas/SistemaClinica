using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class HistorialCD
    {
        private ConexionSQL conexion = new ConexionSQL();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar() { 
       
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM historial";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            
            
            
        }
        public DataTable Mostrar(int idhistory)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM historial WHERE idHistoria=@idhisto";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idhisto", idhistory);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarHistorialde1paciente(int idpaci)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select u.firstName as NombrePaciente, h.* from historial h,citamedica c, Users u where h.idcita = c.idcita and c.idpacinte = u.id and u.id = @iduser;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@iduser", idpaci);
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
        public DataTable obtenertablade1medico(int iddoctor)
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Users WHERE id=@idmedico";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idmedico", iddoctor);
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

        public void Insertar(string tipoaten, string presionarte,decimal tempera,decimal peso,decimal estatura,decimal frecuencia,string anteceden, string diagnost, string tratamie, string detalles,int idcita ) 
        {            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO historial"+
                " VALUES(@tipoatencion,@presionarte,@tempera,"+
                "@peso,@estatura,@frecuenciacar,@antecdentes"+
                ",@diagnostico,@tratamiento,@detalles,@idcita)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@tipoatencion", tipoaten);
            comando.Parameters.AddWithValue("@presionarte", presionarte);
            comando.Parameters.AddWithValue("@tempera", tempera);
            comando.Parameters.AddWithValue("@peso", peso);
            comando.Parameters.AddWithValue("@estatura", estatura);
            comando.Parameters.AddWithValue("@frecuenciacar", frecuencia);
            comando.Parameters.AddWithValue("@antecdentes", anteceden);
            comando.Parameters.AddWithValue("@diagnostico", diagnost);
            comando.Parameters.AddWithValue("@tratamiento", tratamie);
            comando.Parameters.AddWithValue("@detalles", detalles);
            comando.Parameters.AddWithValue("@idcita", idcita);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        
        }

        public void Editar(string tipoaten, string presionarte, decimal tempera, decimal peso, decimal estatura, decimal frecuencia, string anteceden, string diagnost, string tratamie, string detalles, int idcita, int idhisto)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update historial set tipodeatencion=@tipoatencion, " +
                "presionarterial=@presionarte, temperatura=@tempera, " +
                "peso=@peso, estatura=@estatura, frecuenciacardiaca=@frecuenciacar, " +
                "antecedentes=@antecdentes, diagnostico=@diagnostico, tratamiento=@tratamiento, detalles=@detalles, " +
                "idcita=@idcita where idHistoria=@idhisto";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@tipoatencion", tipoaten);
            comando.Parameters.AddWithValue("@presionarte", presionarte);
            comando.Parameters.AddWithValue("@tempera", tempera);
            comando.Parameters.AddWithValue("@peso", peso);
            comando.Parameters.AddWithValue("@estatura", estatura);
            comando.Parameters.AddWithValue("@frecuenciacar", frecuencia);
            comando.Parameters.AddWithValue("@antecdentes", anteceden);
            comando.Parameters.AddWithValue("@diagnostico", diagnost);
            comando.Parameters.AddWithValue("@tratamiento", tratamie);
            comando.Parameters.AddWithValue("@detalles", detalles);
            comando.Parameters.AddWithValue("@idcita", idcita);
            comando.Parameters.AddWithValue("@idhisto", idhisto);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idhisto) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from historial where idHistoria=@idhisto";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idhisto", idhisto);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
