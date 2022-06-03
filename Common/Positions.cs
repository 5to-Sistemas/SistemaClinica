﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Positions
    {
        /// <summary>
        /// Esta estructura almacena los cargos del usuario, escencial para
        /// realizar las condiciones de los permisos de usuario (Para el ejemplo del proyecto).
        /// De igual manera esto es opcional, en su lugar puedes usar
        /// una tabla de cargos en la base de datos, puedes hacerlo
        /// mediante enumeraciones y el ID de los cargos.
        /// </summary>
        public const string vacio = "";
        public const string Medico = "Medico";
        public const string Enfermera = "Enfermera";
        public const string Paciente = "Paciente";
        /*public const string AsistenteAdministrativo = "Administrative assistant";
        public const string GerenteDeRecursosHumanos = "Human resource manager";
        public const string Recepsionista = "Receptionist";*/
        public const string AdministradorDeSistema = "Administrador Del Sistema";

        public static IEnumerable<string> GetPositions()
        {//Método para listar los cargos. Se usa para establece la fuente de datos
            //del ComboBox en el formulario usuario de la capa de interfaz de usuario.
            var positions = new List<string>();
            positions.Add(vacio);
            positions.Add(Medico);
            positions.Add(Enfermera);
            positions.Add(Paciente);
            /*positions.Add(AsistenteAdministrativo);
            positions.Add(GerenteDeRecursosHumanos);
            positions.Add(Recepsionista);*/
            positions.Add(AdministradorDeSistema);
            positions.Sort();
            return positions;
        }
    }
}
