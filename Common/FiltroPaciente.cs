using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class FiltroPaciente
    {
        public const string ci = "ci";
        public const string telefono = "telefono";


        public static IEnumerable<string> GetFilter()
        {//Método para listar los cargos. Se usa para establece la fuente de datos
            //del ComboBox en el formulario usuario de la capa de interfaz de usuario.
            var positions = new List<string>();
            positions.Add(telefono);
            positions.Add(ci);
            positions.Sort();
            return positions;
        }
    }
}
