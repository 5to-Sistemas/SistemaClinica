using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using DataAccess;
using DataAccess.DBServices;
using DataAccess.DBServices.Entities;

namespace Presentation.ChildForms
{
    public partial class FormCitaMedica : Form
    {
        ConexionSQL cx;
        CitaMedica cm;
        public FormCitaMedica()
        {
            InitializeComponent();
            cx = new ConexionSQL();
            cm = new CitaMedica();
        }

        private void FormCitaMedica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAPSDBDataSet.citamedica' table. You can move, or remove it, as needed.
            cx.AbrirConexion();
            dgvCitas.DataSource = cm.SelectByDate(dgvCitas,DateTime.Now).Tables[0];
            if (dgvCitas.Rows.Count == 0)
            {
                lblInfoCitasHoy.Text = "Usted no tiene citas programadas para hoy.";
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                
            }
            else
            {
                lblInfoCitasHoy.Text = "Usted tiene " + dgvCitas.Rows.Count + " citas programadas para hoy.";
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddCitaMedica addCitaMedica = new FormAddCitaMedica();
            addCitaMedica.Show();
            if (DialogResult == DialogResult.OK) {
                //cm.InsertData(,cm.fecha,cm.hora,cm.sintomas);
                dgvCitas.DataSource = cm.SelectByDate(dgvCitas, DateTime.Now).Tables[0];
            }
        }

        private void dgvCitas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnRemove.Enabled=true;
        }

        private void FormCitaMedica_Leave(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }
    }
}
