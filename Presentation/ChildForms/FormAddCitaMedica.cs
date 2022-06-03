
using DataAccess.DBServices.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccess;

namespace Presentation.ChildForms
{
    public partial class FormAddCitaMedica : BaseForms.BaseFixedForm
    {
        CitaMedica cm;
        Medico m;
        User u;
        
        
        public FormAddCitaMedica()
        {
            InitializeComponent();
            cm = new CitaMedica();
            m = new Medico();
            u = new User();
        }
        private void FormAddCitaMedica_Load(object sender, EventArgs e)
        {
            cbxEspecialidad.ValueMember = "especialidad";
            cbxEspecialidad.DisplayMember = "especialidad";
            //cbxEspecialidad.DataSource = m.SelectAll().Tables[0];
            //MessageBox.Show(m.SeleccionarCita().ToString);
            cbxMedico.ValueMember = "firstName";
            cbxMedico.DisplayMember = "firstName";
           // cbxMedico.DataSource = m.SelectAll().Tables[0];
            cbxHora.ValueMember = "HorarioInicio";
            cbxHora.DisplayMember = "HorarioIncio";
           // cbxHora.DataSource = m.SelectAll().Tables[0];

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            cm.fecha = dtpFecha.Value;
            cm.hora = cbxHora.Text;
            cm.sintomas = txtSintomas.Text;
            DialogResult = DialogResult.OK;
            Close();
            
            cx.con = new SqlConnection(cx.cadenaConexion);
            cx.adpt = new SqlDataAdapter("select * from medico inner join Users on id= idmedico" +
                "", cx.con);
            DataSet ds = new DataSet();
            cx.adpt.Fill(ds);
            return ds;
            */
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
