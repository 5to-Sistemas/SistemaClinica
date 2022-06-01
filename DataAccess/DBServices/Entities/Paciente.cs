using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DataAccess.DBServices.Entities
{
    public class Paciente
    {
        public int Codper { get; set; }
        public string Fechanac { get; set; }
        public string Codtiposangre { get; set; }
        public string Telefono { get; set; }
        public string Contactoemergencia { get; set; }
        public string Sexo { get; set; }
        public string Estadocivil { get; set; }
        public string estado { get; set; }

        ConnectionToSql conexion;
        public Paciente()
        {
            conexion = new ConnectionToSql();
        }
        public DataSet TraerDatosporID(int codper)
        {
            string consulta = "select p.codper,p.fechanac, t.nombre, p.telefono, p.contactoemergencia, p.sexo, p.estado from paciente p, tiposdesangre t where p.codper = #codper ";
            consulta = consulta.Replace("#codper", codper.ToString());
            return (conexion.Consultar(consulta));
        }
        
        public void CargarDatos()
        {

        }
    }
}
