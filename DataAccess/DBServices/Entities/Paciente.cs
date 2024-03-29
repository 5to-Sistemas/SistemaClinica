﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
        public void TraerTodos(DataGridView table)
        {
            conexion.con = new SqlConnection(conexion.cadenaConexion);
            conexion.adpt = new SqlDataAdapter("select * from paciente", conexion.con);
            conexion.dt = new DataTable();
            conexion.adpt.Fill(conexion.dt);
            table.DataSource = conexion.dt;
        }

        public void CargarDatos()
        {

        }
    }
}
