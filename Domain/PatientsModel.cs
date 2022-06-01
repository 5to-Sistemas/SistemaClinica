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
            tabla = objetoCD.obtenertablade1pacinte(Convert.ToInt16(idpaci));
            return tabla;
        }
        
        //test

        public DataTable Tabla1User(string IDUSER)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.obtenertablade1usuario(Convert.ToInt16(IDUSER));
            return tabla;
        }
        public void Insertar(string idpaciente, string ci, string direccion, string fecha, string tiposangre, string telefono, string sexo, string estadocivil, string estado)
        {

            objetoCD.Insertar(Convert.ToInt16(idpaciente), Convert.ToInt16(ci), direccion, Convert.ToDateTime(fecha), tiposangre, Convert.ToInt16(telefono), sexo, estadocivil, Convert.ToByte(estado));
        }

        public void Editar(string idpaciente, string ci, string direccion, string fecha, string tiposangre, string telefono, string sexo, string estadocivil, string estado)
        {

            objetoCD.Editar(Convert.ToInt16(idpaciente), Convert.ToInt16(ci), direccion, Convert.ToDateTime(fecha), tiposangre, Convert.ToInt16(telefono), sexo, estadocivil, Convert.ToByte(estado));
        }

        public void Eliminar(string ci)
        {

            objetoCD.Eliminar(Convert.ToInt32(ci));
        }

    }
}
