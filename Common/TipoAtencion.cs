using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class TipoAtencion
    {
        
        public const string AtencionGeneral = "Consulta General";
        public const string Especializada = "Consulta Especializada";
        
        //asd
        public static IEnumerable<string> GetTypes()
        {//Método para listar los cargos. Se usa para establece la fuente de datos
            //del ComboBox en el formulario usuario de la capa de interfaz de usuario.
            var positions = new List<string>();
            positions.Add(AtencionGeneral);
            positions.Add(Especializada);
            positions.Sort();
            return positions;
        }
    }
}
