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
    public partial class FormCitaMedica : Form
    {
        public FormCitaMedica()
        {
            InitializeComponent();
        }

        private void FormCitaMedica_Load(object sender, EventArgs e)
        {
            if (dgvCitas.Rows.Count == 0)
                lblInfoCitasHoy.Text = "Usted no tiene citas programadas para hoy.";
            else
                lblInfoCitasHoy.Text = "Usted tiene " + dgvCitas.Rows.Count + " citas programadas para hoy.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(); 
        }
    }
}
