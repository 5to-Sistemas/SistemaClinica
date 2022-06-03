using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.DBServices.Entities
{
    public class Laboratorio
    {
         Datos.Conexion ca = new Datos.Conexion();

        #region "Atributos"
        int codLaboratorio;
        string Nombre;
        string Dirección;
        string nombreContacto;
        string telefonoContacto;
        #endregion

        #region "Propiedades"
        public int PcodLaboratorio
        {
            set { codLaboratorio = value; }
            get { return codLaboratorio; }
        }
        public string PNombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public string PDirección
        {
            set { Dirección = value; }
            get { return Dirección; }
        }
        public string PnombreContacto
        {
            set { nombreContacto = value; }
            get { return nombreContacto; }
        }
        public string PtelefonoContacto
        {
            set { telefonoContacto = value; }
            get { return telefonoContacto; }
        }

        #endregion

        #region "Constructor"
        public Laboratorio()
        {
            PcodLaboratorio = 0;
            PNombre = "";
            PDirección = "";
            PnombreContacto = "";
            PtelefonoContacto = "";
        }
        public Laboratorio(int codLaboratorio, string Nombre, string Dirección, string nombreContacto, string telefonoContacto )
        {
            PcodLaboratorio = codLaboratorio;
            PNombre = Nombre;
            PDirección = Dirección;
            PnombreContacto = nombreContacto;
            PtelefonoContacto = telefonoContacto;
        }
        #endregion

        #region "Metodos"

        #endregion
    }
}
