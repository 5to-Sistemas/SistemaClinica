using System;
using Domain;
using DataAccess.DBServices.Entities;
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
    public partial class FormReports : Form
    {
        private UserModel userModel = new UserModel();
        Medicamento medicamento;
        public FormReports()
        {
            InitializeComponent();
            medicamento = new Medicamento();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dtgvPaciente.Columns.Count; i++)
            {
                string item = dtgvPaciente.Rows[dtgvPaciente.CurrentCell.RowIndex].Cells[i].Value.ToString();
                list.Add(item);
            }
        }

        private void btnReporteMedicamentos_Click(object sender, EventArgs e)
        {
            string[,] data = new string[dataMedicamentos.Rows.Count, dataMedicamentos.Columns.Count];
            for (int i = 0; i < dataMedicamentos.Rows.Count; i++)
            {
                for (int k = 0; k < dataMedicamentos.Columns.Count; k++)
                {
                    data[i, k] = dataMedicamentos.Rows[i].Cells[k].Value.ToString();
                }
            }
        }
    }
}
