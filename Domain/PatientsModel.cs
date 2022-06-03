using DataAccess.DBServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PatientsModel
    {
        private PatientsDA objetoCD = new PatientsDA();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        
        public DataTable Mostrartablade1paciente(string idpaci)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.obtenertablade1pacinte(Convert.ToInt32(idpaci));
            return tabla;
        }
        

        public DataTable Tabla1User(string IDUSER)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.obtenertablade1usuario(Convert.ToInt32(IDUSER));
            return tabla;
        }

        public string obteneriddeuserbyusername(string username)
        {
            return objetoCD.obtenerIDde1usuario(username);
        }

        public void Insertar(string idpaciente, string ci, string direccion, string fecha, string tiposangre, string telefono, string sexo, string estadocivil, string estado)
        {

            objetoCD.Insertar(Convert.ToInt32(idpaciente), Convert.ToInt32(ci), direccion, Convert.ToDateTime(fecha), tiposangre, Convert.ToInt32(telefono), sexo, estadocivil, estado);
        }

        public void Editar(string idpaciente, string ci, string direccion, string fecha, string tiposangre, string telefono, string sexo, string estadocivil, string estado)
        {

            objetoCD.Editar(Convert.ToInt32(idpaciente), Convert.ToInt32(ci), direccion, Convert.ToDateTime(fecha), tiposangre, Convert.ToInt32(telefono), sexo, estadocivil, estado);
        }

        public void Eliminar(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public int existepaciente(string username)
        {
            return objetoCD.existepaci(username);
            
        }

    }
}
