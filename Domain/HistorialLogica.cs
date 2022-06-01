using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class HistorialLogica
    {
        private HistorialCD objetoCD = new HistorialCD();

        public DataTable MostrarH() {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable MostrarH(string idhistorial)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(Convert.ToInt16(idhistorial));
            return tabla;
        }
        public DataTable MostrarHistorialde1paciente(string idpaci)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarHistorialde1paciente(Convert.ToInt16(idpaci));
            return tabla;
        }
        public DataTable Tabla1pacient(string idpaci)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.obtenertablade1pacinte(Convert.ToInt16(idpaci));
            return tabla;
        }

        public DataTable Tabla1Medico(string idmedi)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.obtenertablade1medico(Convert.ToInt16(idmedi));
            return tabla;
        }

        public DataTable Tabla1User(string IDUSER)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.obtenertablade1usuario(Convert.ToInt16(IDUSER));
            return tabla;
        }
        public void InsertarHistorial (string tipoaten, string presionarte, string tempera, string peso, string estatura, string frecuencia, string anteceden, string diagnost, string tratamie, string detalles, string idcita)
        {

            objetoCD.Insertar(tipoaten,presionarte, Convert.ToDecimal( tempera),Convert.ToDecimal( peso), Convert.ToDecimal(estatura), Convert.ToDecimal(frecuencia),anteceden,diagnost,tratamie,detalles, Convert.ToInt16(idcita));
        }

        public void EditarHistorial(string tipoaten, string presionarte, string tempera, string peso, string estatura, string frecuencia, string anteceden, string diagnost, string tratamie, string detalles, string idcita,string idhisto)
        {
            
            objetoCD.Editar(tipoaten, presionarte, Convert.ToDecimal(tempera), Convert.ToDecimal(peso), Convert.ToDecimal(estatura), Convert.ToDecimal(frecuencia), anteceden, diagnost, tratamie, detalles, Convert.ToInt16(idcita),Convert.ToInt16(idhisto));
        }

        public void EliminarHistorial(string ci) 
        {

            objetoCD.Eliminar(Convert.ToInt32(ci));
        }

        public string diasvivos(string fechanac)
        {
            DateTime fechaDeNacimiento =  Convert.ToDateTime(fechanac);
            int edad = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Day - 1;
            return edad.ToString();
        }
        public string mesesvivos(string fechanac)
        {
            DateTime fechaDeNacimiento = Convert.ToDateTime(fechanac);
            int edad = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Month - 1;
            return edad.ToString();
        }
        public string anosvivos(string fechanac)
        {
            DateTime fechaDeNacimiento = Convert.ToDateTime(fechanac);
            int edad = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;
            return edad.ToString();
        }

    }
}
