using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.TablasRecurentes
{
    public class FiltroCita
    {
        public const string fecha = "fecha";
        public const string hora = "hora";


        public static IEnumerable<string> GetFilter()
        {//Método para listar los cargos. Se usa para establece la fuente de datos
            //del ComboBox en el formulario usuario de la capa de interfaz de usuario.
            var positions = new List<string>();
            positions.Add(hora);
            positions.Add(fecha);
            positions.Sort();
            return positions;
        }
    }
}

