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
using logica;
using logica.TablasRecurentes;
using Common;
using CapaDatos;
using DataAccess.DBServices;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        HistorialLogica objhistorialL = new HistorialLogica();
        private string IDhisto = null;
        //private bool Editar = false;

        private string IDcita = null;
        private string IDpaci = null;
        private string IDmedi = null;
        //ConexionSQL cx;
        ConnectionToSql cx;
        public Form1()
        {
            InitializeComponent();
            cmbxtipoatencion.DataSource = TipoAtencion.GetTypes();
            cmbxfiltrocita.DataSource = FiltroCita.GetFilter();
            //cx = new ConexionSQL();
            cx = new ConnectionToSql();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAPSDBDataSet.citamedica' Puede moverla o quitarla según sea necesario.
            //cx.AbrirConexion();
            this.citamedicaTableAdapter.Fill(this.sAPSDBDataSet.citamedica);

            /*this.leer_datos("SELECT * FROM citamedica", ref resultados, "citamedica");
            this.mifiltro = ((DataTable)resultados.Tables["citamedica"]).DefaultView;
            this.dataGridView2.DataSource = mifiltro;*/
        }

        #region liveview
        /*
        DataSet resultados = new DataSet();
        DataView mifiltro;
        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string cadena = "Server= DESKTOP-793T557\\SQLEXPRESS; DataBase= SAPSDB; Integrated Security= true";
                SqlConnection cn = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        */
        private void txbfiltrocitamedica_KeyUp(object sender, KeyEventArgs e)
        {
            /*string salida_datos = "";
            string[] palabras_busqueda = this.txbfiltrocitamedica.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(fecha LIKE '%" + palabra + "%' OR hora LIKE '%" + palabra + "%')";
                }
                else 
                {
                    salida_datos += " AND (fecha LIKE '%" + palabra + "%' OR hora LIKE '%" + palabra + "%')";
                }

            }
            this.mifiltro.RowFilter = salida_datos;*/
        }

        
        #endregion


        private void btnseleccionarcita_Click(object sender, EventArgs e)
        {
            if (DBVcitasmedicas.SelectedRows.Count > 0)
            {
                llenarcasillasdecita();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
            
        }

        private void llenarcasillasdecita()
        {
            
            IDcita = DBVcitasmedicas.CurrentRow.Cells[0].Value.ToString();
            IDpaci = DBVcitasmedicas.CurrentRow.Cells[1].Value.ToString();
            IDmedi = DBVcitasmedicas.CurrentRow.Cells[2].Value.ToString();
            txbidcita.Text = IDcita.ToString();
            DataTable tbuser = new DataTable();
            tbuser = objhistorialL.Tabla1User(IDpaci);
            txbnombrepac.Text = tbuser.Rows[0]["firstName"].ToString();
            tbxapellidopac.Text = tbuser.Rows[0]["lastName"].ToString();
            txbemailpac.Text = tbuser.Rows[0]["email"].ToString();
            DataTable tbpaciente = new DataTable();
            tbpaciente = objhistorialL.Tabla1pacient(IDpaci);

            txbcipac.Text = tbpaciente.Rows[0]["ci"].ToString();
            txbdireccionpac.Text = tbpaciente.Rows[0]["direccion"].ToString();
            txbfechanacpac.Text = tbpaciente.Rows[0]["fechanac"].ToString();
            txbdias.Text = objhistorialL.diasvivos(tbpaciente.Rows[0]["fechanac"].ToString());
            txbmeses.Text = objhistorialL.mesesvivos(tbpaciente.Rows[0]["fechanac"].ToString());
            txbanos.Text = objhistorialL.anosvivos(tbpaciente.Rows[0]["fechanac"].ToString());
            txbtiposangre.Text = tbpaciente.Rows[0]["tiposangre"].ToString();
            txbtelefonopac.Text = tbpaciente.Rows[0]["telefono"].ToString();
            if (tbpaciente.Rows[0]["sexo"].ToString() == "M")
            {
                rbtnM.Checked = true;
            }
            else if (tbpaciente.Rows[0]["sexo"].ToString() == "F")
            {
                rbtnF.Checked = true;
            }
            txbestadocivil.Text = tbpaciente.Rows[0]["estadocivil"].ToString();
            DataTable tbmedico = new DataTable();
            tbmedico = objhistorialL.Tabla1Medico(IDmedi);
            txbxnombremedico.Text = tbmedico.Rows[0]["firstName"].ToString() + " " + tbmedico.Rows[0]["lastName"].ToString();

            txtfechacita.Text = DBVcitasmedicas.CurrentRow.Cells[3].Value.ToString();
            txbhoracita.Text = DBVcitasmedicas.CurrentRow.Cells[4].Value.ToString();
            txbsintomas.Text = DBVcitasmedicas.CurrentRow.Cells[5].Value.ToString();

            MostrarHistorialPaciente();
            txbidcita.Enabled = false;

            txtfechacita.Enabled = false;
            txbhoracita.Enabled = false;
            txbsintomas.Enabled = false;

            txbdias.Enabled = false;
            txbmeses.Enabled = false;
            txbanos.Enabled = false;

            txbnombrepac.Enabled = false;
            tbxapellidopac.Enabled = false;
            txbemailpac.Enabled = false;

            txbcipac.Enabled = false;
            txbdireccionpac.Enabled = false;
            txbfechanacpac.Enabled = false;
            txbtiposangre.Enabled = false;
            txbtelefonopac.Enabled = false;


            rbtnM.Enabled = false;

            rbtnF.Enabled = false;
            txbestadocivil.Enabled = false;
            txbxnombremedico.Enabled = false;


        }

        


        private void MostrarHistorial()
        {

            HistorialLogica objeto = new HistorialLogica();
            DGVhistorial.DataSource = objeto.MostrarH();
        }
        private void MostrarHistorialPaciente()
        {

            HistorialLogica objeto = new HistorialLogica();
            DGVhistorial.DataSource = objeto.MostrarHistorialde1paciente(IDpaci);
        }


        private void btnguardarhistorial_Click(object sender, EventArgs e)
        {
            try
            {
                
                objhistorialL.InsertarHistorial(cmbxtipoatencion.Text, txbpresionarte.Text, txbtempera.Text,txbpeso.Text,txbestatura.Text,txbfrecuencia.Text,txbantecedentes.Text,txbdiagnostic.Text,txbtratamiento.Text,txbdetalles.Text,IDcita);
                MessageBox.Show("se inserto correctamente");
                MostrarHistorialPaciente();
                limpiarForm();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
            }



        }


        

        

        private void limpiarForm()
        {
            txtfechacita.Enabled = true;
            txbhoracita.Enabled = true;
            txbsintomas.Enabled = true;

            txbnombrepac.Enabled = true;
            tbxapellidopac.Enabled = true;
            txbemailpac.Enabled = true;

            txbcipac.Enabled = true;
            txbdireccionpac.Enabled = true;
            txbfechanacpac.Enabled = true;
            txbtiposangre.Enabled = true;
            txbtelefonopac.Enabled = true;


            rbtnM.Enabled = true;

            rbtnF.Enabled = true;
            txbestadocivil.Enabled = true;
            txbxnombremedico.Enabled = true;
            //limpiar

            txtfechacita.Clear();
            txbhoracita.Clear();
            txbsintomas.Clear();

            txbnombrepac.Clear();
            tbxapellidopac.Clear();
            txbemailpac.Clear();

            txbcipac.Clear();
            txbdireccionpac.Clear();
            txbfechanacpac.Clear();
            txbtiposangre.Clear();
            txbtelefonopac.Clear();


            rbtnM.Checked = false;

            rbtnF.Checked = false;
            txbestadocivil.Clear();
            txbxnombremedico.Clear();
            //limpiar historial

            cmbxtipoatencion.Text = "";
            txbpresionarte.Clear();
            txbtempera.Clear();
            txbpeso.Clear();
            txbestatura.Clear();
            txbfrecuencia.Clear();
            txbantecedentes.Clear();
            txbdiagnostic.Clear();
            txbtratamiento.Clear();
            txbdetalles.Clear();
            IDcita = null;
        }

        

        private void btneliminarhis_Click(object sender, EventArgs e)
        {
            if (DGVhistorial.SelectedRows.Count > 0)
            {
                IDhisto = DGVhistorial.CurrentRow.Cells["idHistoria"].Value.ToString();
                objhistorialL.EliminarHistorial(IDhisto);
                MessageBox.Show("Eliminado correctamente");
                MostrarHistorialPaciente();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void txbfiltrocitamedica_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Presentation.Properties.Settings.Default.conexion);
            string query = "select * from citamedica where "+cmbxfiltrocita.Text+" like '%"+txbfiltrocitamedica.Text+"%'";
            SqlDataAdapter ada = new SqlDataAdapter(query,con);

            con.Open();

            DataSet data = new DataSet();

            ada.Fill(data, "citamedica");

            DBVcitasmedicas.DataSource = data;
            DBVcitasmedicas.DataMember = "citamedica";

        }
    }
}
