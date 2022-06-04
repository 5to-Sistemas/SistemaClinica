using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DBServices.Entities;
namespace Presentation.ChildForms
{
    public partial class FormLaboratorio : BaseForms.BaseFixedForm
    {
        Datos.Conexion objConexion = new Datos.Conexion();
        Laboratorio objLaboratorio = new Laboratorio();
        Boolean estado;
        public FormLaboratorio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            estado = false;
            objConexion.conectar();
            objConexion.ActualizarGrid(dgvLaboratorio, "Laboratorio", "*", " order by codLaboratorio");
            objConexion.desconectar();
        }
        public void Limpiar()
        {
            txtCriterioCod.Clear();
            txtCriterioNombre.Clear();
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            string criterio = txtCriterioCod.Text;
            objConexion.ActualizarGrid(dgvLaboratorio, "Laboratorio", "*", " where codLaboratorio = " + criterio.ToString());
            Limpiar();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string criterio = txtCriterioNombre.Text;
            objConexion.ActualizarGrid(dgvLaboratorio, "Laboratorio", "*", " where Nombre = " + "'" + criterio.ToString() + "'");
            Limpiar();
        }
        private void txtCriterioNombre_KeyUp(object sender, KeyEventArgs e)
        {
            objConexion.ActualizarGrid(dgvLaboratorio, "Laboratorio", "*", " where Nombre like '" + txtCriterioNombre.Text + "%'");
        }

        private void txtCriterioNombre_KeyUp_1(object sender, KeyEventArgs e)
        {
            objConexion.ActualizarGrid(dgvLaboratorio, "Laboratorio", "*", " where Nombre like '" + txtCriterioNombre.Text + "%'");
        }
    }
}
