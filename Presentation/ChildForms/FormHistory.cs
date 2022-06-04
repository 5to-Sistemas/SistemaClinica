using CapaDatos;
using CapaNegocio;
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
    public partial class FormHistory : Form
    {
        HistorialLogica objhistoria = new HistorialLogica();
        ConexionSQL conexi = new ConexionSQL();
        public FormHistory()
        {
            InitializeComponent();
            dataGridView1.DataSource = objhistoria.MostrarH();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form hm = new Presentacion.Form1();
            hm.ShowDialog();
        }

        private void btnBuscarLaboratorio_Click(object sender, EventArgs e)
        {
            FormLaboratorio frmL = new FormLaboratorio();
            frmL.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexi.stringcone);
                string query = "select * from historial where " + cmbxfiltrohisto.Text + " like '%" + txtSearch.Text + "%'";
                SqlDataAdapter ada = new SqlDataAdapter(query, con);

                con.Open();

                DataSet data = new DataSet();

                ada.Fill(data, "historial");

                dataGridView1.DataSource = data;
                dataGridView1.DataMember = "historial";
            }
            catch
            {

            }
        }
    }
}
