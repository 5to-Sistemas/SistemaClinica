using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms
{
    public partial class FormPacients : Form
    {
        PatientsModel Objpatien = new PatientsModel();

        public FormPacients()
        {
            InitializeComponent();
            comboBox1.DataSource = FiltroPaciente.GetFilter();
        }

        private void FormPacients_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAPSDBDataSet1.paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.sAPSDBDataSet1.paciente);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string IDpaciente = dataGridView1.CurrentRow.Cells["idpaciente"].Value.ToString();
                string ci = dataGridView1.CurrentRow.Cells["ci"].Value.ToString();
                string direccion = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                string fechanac = dataGridView1.CurrentRow.Cells["fechanac"].Value.ToString();
                string telefono = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
                string sexo = dataGridView1.CurrentRow.Cells["sexo"].Value.ToString();
                string estadocivil = dataGridView1.CurrentRow.Cells["estadocivil"].Value.ToString();
                string estado = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        
        public void llegardatosdedgv()
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string IDpaciente = dataGridView1.CurrentRow.Cells["idpaciente"].Value.ToString();
                Objpatien.Eliminar(IDpaciente);
                MessageBox.Show("Eliminado correctamente");
                

            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Presentation.Properties.Settings.Default.conexion);
            string query = "select * from paciente where " + comboBox1.Text + " like '%" + txtSearch.Text + "%'";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);

            con.Open();

            DataSet data = new DataSet();

            ada.Fill(data, "paciente");

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "paciente";
        }
    }
}
