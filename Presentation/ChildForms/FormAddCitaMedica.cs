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

namespace Presentation.ChildForms
{
    public partial class FormAddCitaMedica : BaseForms.BaseFixedForm
    {
        CitaMedica cm;
        Medico m;
        public FormAddCitaMedica()
        {
            InitializeComponent();
            cm = new CitaMedica();
            m = new Medico();
        }
        private void FormAddCitaMedica_Load(object sender, EventArgs e)
        {
            cbxEspecialidad.ValueMember = "especialidad";
            cbxEspecialidad.DisplayMember = "especialidad";
            cbxEspecialidad.DataSource = m.SelectAll().Tables[0];
            cbxMedico.ValueMember = "idmedico";
            cbxMedico.DisplayMember = "idmedico";
            cbxMedico.DataSource = m.SelectAll().Tables[0];
            cbxHora.ValueMember = "HorarioInicio";
            cbxHora.DisplayMember = "HorarioIncio";
            cbxHora.DataSource = m.SelectAll().Tables[0];

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cm.fecha = dtpFecha.Value;
            cm.hora = cbxHora.Text;
            cm.sintomas = txtSintomas.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
