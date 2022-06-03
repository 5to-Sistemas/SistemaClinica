using DataAccess.DBServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MedicalModel
    {
        private MedicalDA objetoCD = new MedicalDA();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public DataTable Mostrartablade1medico(string idmed)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.obtenertablade1medico(Convert.ToInt16(idmed));
            return tabla;
        }


        public DataTable Tabla1User(string IDUSER)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.obtenertablade1usuario(Convert.ToInt16(IDUSER));
            return tabla;
        }

        public string obteneriddeuserbyusername(string username)
        {
            return objetoCD.obtenerIDde1usuario(username);
        }

        public void Insertar(string idmedico, string ci, string direccion, string telefono, string diahabiles, string HorarioInicio, string HorarioFin, string especialidad, string sexo)
        {

            objetoCD.Insertar(Convert.ToInt16(idmedico), Convert.ToInt16(ci), direccion, Convert.ToInt16(telefono), diahabiles, HorarioInicio, HorarioFin, especialidad, sexo);
        }

        public void Editar(string idmedico, string ci, string direccion, string telefono, string diahabiles, string HorarioInicio, string HorarioFin, string especialidad, string sexo)
        {

            objetoCD.Editar(Convert.ToInt16(idmedico), Convert.ToInt16(ci), direccion, Convert.ToInt16(telefono), diahabiles, HorarioInicio, HorarioFin, especialidad, sexo);
        }

        public void Eliminar(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
