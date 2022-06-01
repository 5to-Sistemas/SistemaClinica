using Presentation;

namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.cmbxfiltrocita = new System.Windows.Forms.ComboBox();
            this.txbestadocivil = new System.Windows.Forms.TextBox();
            this.txbtiposangre = new System.Windows.Forms.TextBox();
            this.txbanos = new System.Windows.Forms.TextBox();
            this.txbmeses = new System.Windows.Forms.TextBox();
            this.txbdias = new System.Windows.Forms.TextBox();
            this.txbfechanacpac = new System.Windows.Forms.TextBox();
            this.txbidcita = new System.Windows.Forms.TextBox();
            this.txtfechacita = new System.Windows.Forms.TextBox();
            this.btnseleccionarcita = new System.Windows.Forms.Button();
            this.DBVcitasmedicas = new System.Windows.Forms.DataGridView();
            this.idcitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpacinteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sintomasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citamedicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAPSDBDataSet = new Presentation.SAPSDBDataSet();
            this.txbfiltrocitamedica = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbxapellidopac = new System.Windows.Forms.TextBox();
            this.btneliminarhis = new System.Windows.Forms.Button();
            this.btnguardarhistorial = new System.Windows.Forms.Button();
            this.txbdetalles = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txbtratamiento = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txbdiagnostic = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txbantecedentes = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.DGVhistorial = new System.Windows.Forms.DataGridView();
            this.txbfrecuencia = new System.Windows.Forms.TextBox();
            this.txbestatura = new System.Windows.Forms.TextBox();
            this.txbpeso = new System.Windows.Forms.TextBox();
            this.txbtempera = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txbpresionarte = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbxtipoatencion = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txbsintomas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbemailpac = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbtelefonopac = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbdireccionpac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbcipac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbhoracita = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxnombremedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbnombrepac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.citamedicaTableAdapter = new Presentation.SAPSDBDataSetTableAdapters.citamedicaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBVcitasmedicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citamedicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.cmbxfiltrocita);
            this.panel1.Controls.Add(this.txbestadocivil);
            this.panel1.Controls.Add(this.txbtiposangre);
            this.panel1.Controls.Add(this.txbanos);
            this.panel1.Controls.Add(this.txbmeses);
            this.panel1.Controls.Add(this.txbdias);
            this.panel1.Controls.Add(this.txbfechanacpac);
            this.panel1.Controls.Add(this.txbidcita);
            this.panel1.Controls.Add(this.txtfechacita);
            this.panel1.Controls.Add(this.btnseleccionarcita);
            this.panel1.Controls.Add(this.DBVcitasmedicas);
            this.panel1.Controls.Add(this.txbfiltrocitamedica);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.tbxapellidopac);
            this.panel1.Controls.Add(this.btneliminarhis);
            this.panel1.Controls.Add(this.btnguardarhistorial);
            this.panel1.Controls.Add(this.txbdetalles);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.txbtratamiento);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.txbdiagnostic);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.txbantecedentes);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.DGVhistorial);
            this.panel1.Controls.Add(this.txbfrecuencia);
            this.panel1.Controls.Add(this.txbestatura);
            this.panel1.Controls.Add(this.txbpeso);
            this.panel1.Controls.Add(this.txbtempera);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txbpresionarte);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.cmbxtipoatencion);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txbsintomas);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txbemailpac);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txbtelefonopac);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txbdireccionpac);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txbcipac);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbhoracita);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbtnM);
            this.panel1.Controls.Add(this.rbtnF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbxnombremedico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbnombrepac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 731);
            this.panel1.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(567, 182);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(46, 17);
            this.label30.TabIndex = 79;
            this.label30.Text = "EDAD";
            // 
            // cmbxfiltrocita
            // 
            this.cmbxfiltrocita.FormattingEnabled = true;
            this.cmbxfiltrocita.Location = new System.Drawing.Point(20, 52);
            this.cmbxfiltrocita.Name = "cmbxfiltrocita";
            this.cmbxfiltrocita.Size = new System.Drawing.Size(121, 21);
            this.cmbxfiltrocita.TabIndex = 78;
            // 
            // txbestadocivil
            // 
            this.txbestadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbestadocivil.Location = new System.Drawing.Point(344, 267);
            this.txbestadocivil.Name = "txbestadocivil";
            this.txbestadocivil.Size = new System.Drawing.Size(173, 26);
            this.txbestadocivil.TabIndex = 77;
            // 
            // txbtiposangre
            // 
            this.txbtiposangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtiposangre.Location = new System.Drawing.Point(168, 267);
            this.txbtiposangre.Name = "txbtiposangre";
            this.txbtiposangre.Size = new System.Drawing.Size(159, 26);
            this.txbtiposangre.TabIndex = 76;
            // 
            // txbanos
            // 
            this.txbanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbanos.Location = new System.Drawing.Point(628, 202);
            this.txbanos.Name = "txbanos";
            this.txbanos.Size = new System.Drawing.Size(44, 26);
            this.txbanos.TabIndex = 75;
            // 
            // txbmeses
            // 
            this.txbmeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmeses.Location = new System.Drawing.Point(569, 202);
            this.txbmeses.Name = "txbmeses";
            this.txbmeses.Size = new System.Drawing.Size(44, 26);
            this.txbmeses.TabIndex = 74;
            // 
            // txbdias
            // 
            this.txbdias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdias.Location = new System.Drawing.Point(513, 202);
            this.txbdias.Name = "txbdias";
            this.txbdias.Size = new System.Drawing.Size(44, 26);
            this.txbdias.TabIndex = 73;
            // 
            // txbfechanacpac
            // 
            this.txbfechanacpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbfechanacpac.Location = new System.Drawing.Point(344, 202);
            this.txbfechanacpac.Name = "txbfechanacpac";
            this.txbfechanacpac.Size = new System.Drawing.Size(163, 26);
            this.txbfechanacpac.TabIndex = 72;
            // 
            // txbidcita
            // 
            this.txbidcita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbidcita.Location = new System.Drawing.Point(714, 267);
            this.txbidcita.Name = "txbidcita";
            this.txbidcita.Size = new System.Drawing.Size(354, 26);
            this.txbidcita.TabIndex = 71;
            // 
            // txtfechacita
            // 
            this.txtfechacita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechacita.Location = new System.Drawing.Point(711, 202);
            this.txtfechacita.Name = "txtfechacita";
            this.txtfechacita.Size = new System.Drawing.Size(163, 26);
            this.txtfechacita.TabIndex = 70;
            // 
            // btnseleccionarcita
            // 
            this.btnseleccionarcita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionarcita.Location = new System.Drawing.Point(918, 43);
            this.btnseleccionarcita.Name = "btnseleccionarcita";
            this.btnseleccionarcita.Size = new System.Drawing.Size(147, 59);
            this.btnseleccionarcita.TabIndex = 69;
            this.btnseleccionarcita.Text = "SELECCIONAR";
            this.btnseleccionarcita.UseVisualStyleBackColor = true;
            this.btnseleccionarcita.Click += new System.EventHandler(this.btnseleccionarcita_Click);
            // 
            // DBVcitasmedicas
            // 
            this.DBVcitasmedicas.AutoGenerateColumns = false;
            this.DBVcitasmedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBVcitasmedicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcitaDataGridViewTextBoxColumn,
            this.idpacinteDataGridViewTextBoxColumn,
            this.idmedicoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.sintomasDataGridViewTextBoxColumn});
            this.DBVcitasmedicas.DataSource = this.citamedicaBindingSource;
            this.DBVcitasmedicas.Location = new System.Drawing.Point(350, 27);
            this.DBVcitasmedicas.Name = "DBVcitasmedicas";
            this.DBVcitasmedicas.Size = new System.Drawing.Size(562, 75);
            this.DBVcitasmedicas.TabIndex = 68;
            // 
            // idcitaDataGridViewTextBoxColumn
            // 
            this.idcitaDataGridViewTextBoxColumn.DataPropertyName = "idcita";
            this.idcitaDataGridViewTextBoxColumn.HeaderText = "idcita";
            this.idcitaDataGridViewTextBoxColumn.Name = "idcitaDataGridViewTextBoxColumn";
            this.idcitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpacinteDataGridViewTextBoxColumn
            // 
            this.idpacinteDataGridViewTextBoxColumn.DataPropertyName = "idpacinte";
            this.idpacinteDataGridViewTextBoxColumn.HeaderText = "idpacinte";
            this.idpacinteDataGridViewTextBoxColumn.Name = "idpacinteDataGridViewTextBoxColumn";
            // 
            // idmedicoDataGridViewTextBoxColumn
            // 
            this.idmedicoDataGridViewTextBoxColumn.DataPropertyName = "idmedico";
            this.idmedicoDataGridViewTextBoxColumn.HeaderText = "idmedico";
            this.idmedicoDataGridViewTextBoxColumn.Name = "idmedicoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // sintomasDataGridViewTextBoxColumn
            // 
            this.sintomasDataGridViewTextBoxColumn.DataPropertyName = "sintomas";
            this.sintomasDataGridViewTextBoxColumn.HeaderText = "sintomas";
            this.sintomasDataGridViewTextBoxColumn.Name = "sintomasDataGridViewTextBoxColumn";
            // 
            // citamedicaBindingSource
            // 
            this.citamedicaBindingSource.DataMember = "citamedica";
            this.citamedicaBindingSource.DataSource = this.sAPSDBDataSet;
            // 
            // sAPSDBDataSet
            // 
            this.sAPSDBDataSet.DataSetName = "SAPSDBDataSet";
            this.sAPSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbfiltrocitamedica
            // 
            this.txbfiltrocitamedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbfiltrocitamedica.Location = new System.Drawing.Point(155, 47);
            this.txbfiltrocitamedica.Name = "txbfiltrocitamedica";
            this.txbfiltrocitamedica.Size = new System.Drawing.Size(189, 26);
            this.txbfiltrocitamedica.TabIndex = 67;
            this.txbfiltrocitamedica.TextChanged += new System.EventHandler(this.txbfiltrocitamedica_TextChanged);
            this.txbfiltrocitamedica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbfiltrocitamedica_KeyUp);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(432, 112);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 17);
            this.label29.TabIndex = 66;
            this.label29.Text = "APELLIDO";
            // 
            // tbxapellidopac
            // 
            this.tbxapellidopac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxapellidopac.Location = new System.Drawing.Point(429, 132);
            this.tbxapellidopac.Name = "tbxapellidopac";
            this.tbxapellidopac.Size = new System.Drawing.Size(260, 26);
            this.tbxapellidopac.TabIndex = 65;
            // 
            // btneliminarhis
            // 
            this.btneliminarhis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarhis.Location = new System.Drawing.Point(165, 557);
            this.btneliminarhis.Name = "btneliminarhis";
            this.btneliminarhis.Size = new System.Drawing.Size(147, 45);
            this.btneliminarhis.TabIndex = 62;
            this.btneliminarhis.Text = "ELIMINAR";
            this.btneliminarhis.UseVisualStyleBackColor = true;
            this.btneliminarhis.Click += new System.EventHandler(this.btneliminarhis_Click);
            // 
            // btnguardarhistorial
            // 
            this.btnguardarhistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarhistorial.Location = new System.Drawing.Point(12, 557);
            this.btnguardarhistorial.Name = "btnguardarhistorial";
            this.btnguardarhistorial.Size = new System.Drawing.Size(147, 45);
            this.btnguardarhistorial.TabIndex = 61;
            this.btnguardarhistorial.Text = "GUARDAR";
            this.btnguardarhistorial.UseVisualStyleBackColor = true;
            this.btnguardarhistorial.Click += new System.EventHandler(this.btnguardarhistorial_Click);
            // 
            // txbdetalles
            // 
            this.txbdetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdetalles.Location = new System.Drawing.Point(822, 481);
            this.txbdetalles.Multiline = true;
            this.txbdetalles.Name = "txbdetalles";
            this.txbdetalles.Size = new System.Drawing.Size(236, 55);
            this.txbdetalles.TabIndex = 60;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(819, 461);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(138, 17);
            this.label28.TabIndex = 59;
            this.label28.Text = "DETALLES/EXTRAS";
            // 
            // txbtratamiento
            // 
            this.txbtratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtratamiento.Location = new System.Drawing.Point(555, 481);
            this.txbtratamiento.Multiline = true;
            this.txbtratamiento.Name = "txbtratamiento";
            this.txbtratamiento.Size = new System.Drawing.Size(236, 55);
            this.txbtratamiento.TabIndex = 58;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(552, 461);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(107, 17);
            this.label27.TabIndex = 57;
            this.label27.Text = "TRATAMIENTO";
            // 
            // txbdiagnostic
            // 
            this.txbdiagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdiagnostic.Location = new System.Drawing.Point(292, 481);
            this.txbdiagnostic.Multiline = true;
            this.txbdiagnostic.Name = "txbdiagnostic";
            this.txbdiagnostic.Size = new System.Drawing.Size(236, 55);
            this.txbdiagnostic.TabIndex = 56;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(289, 461);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 17);
            this.label26.TabIndex = 55;
            this.label26.Text = "DIAGNOSTICO";
            // 
            // txbantecedentes
            // 
            this.txbantecedentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbantecedentes.Location = new System.Drawing.Point(25, 481);
            this.txbantecedentes.Multiline = true;
            this.txbantecedentes.Name = "txbantecedentes";
            this.txbantecedentes.Size = new System.Drawing.Size(236, 55);
            this.txbantecedentes.TabIndex = 54;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(22, 461);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 17);
            this.label25.TabIndex = 53;
            this.label25.Text = "ANTECEDENTES";
            // 
            // DGVhistorial
            // 
            this.DGVhistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVhistorial.Location = new System.Drawing.Point(10, 608);
            this.DGVhistorial.Name = "DGVhistorial";
            this.DGVhistorial.Size = new System.Drawing.Size(1055, 111);
            this.DGVhistorial.TabIndex = 52;
            // 
            // txbfrecuencia
            // 
            this.txbfrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbfrecuencia.Location = new System.Drawing.Point(904, 423);
            this.txbfrecuencia.Name = "txbfrecuencia";
            this.txbfrecuencia.Size = new System.Drawing.Size(119, 26);
            this.txbfrecuencia.TabIndex = 51;
            // 
            // txbestatura
            // 
            this.txbestatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbestatura.Location = new System.Drawing.Point(779, 423);
            this.txbestatura.Name = "txbestatura";
            this.txbestatura.Size = new System.Drawing.Size(119, 26);
            this.txbestatura.TabIndex = 50;
            // 
            // txbpeso
            // 
            this.txbpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbpeso.Location = new System.Drawing.Point(646, 423);
            this.txbpeso.Name = "txbpeso";
            this.txbpeso.Size = new System.Drawing.Size(119, 26);
            this.txbpeso.TabIndex = 49;
            // 
            // txbtempera
            // 
            this.txbtempera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtempera.Location = new System.Drawing.Point(509, 423);
            this.txbtempera.Name = "txbtempera";
            this.txbtempera.Size = new System.Drawing.Size(119, 26);
            this.txbtempera.TabIndex = 48;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(899, 403);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(166, 17);
            this.label24.TabIndex = 47;
            this.label24.Text = "FRECUENCIA CARDIACA";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(776, 403);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 17);
            this.label23.TabIndex = 46;
            this.label23.Text = "ESTATURA";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(643, 403);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 17);
            this.label22.TabIndex = 44;
            this.label22.Text = "PESO";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(506, 403);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 17);
            this.label21.TabIndex = 42;
            this.label21.Text = "TEMPERATURA";
            // 
            // txbpresionarte
            // 
            this.txbpresionarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbpresionarte.Location = new System.Drawing.Point(360, 423);
            this.txbpresionarte.Name = "txbpresionarte";
            this.txbpresionarte.Size = new System.Drawing.Size(140, 26);
            this.txbpresionarte.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(360, 403);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 17);
            this.label20.TabIndex = 40;
            this.label20.Text = "PRESION ARTERIAL";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 403);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "TIPO DE ATENCION";
            // 
            // cmbxtipoatencion
            // 
            this.cmbxtipoatencion.FormattingEnabled = true;
            this.cmbxtipoatencion.Location = new System.Drawing.Point(22, 428);
            this.cmbxtipoatencion.Name = "cmbxtipoatencion";
            this.cmbxtipoatencion.Size = new System.Drawing.Size(330, 21);
            this.cmbxtipoatencion.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 17);
            this.label18.TabIndex = 37;
            this.label18.Text = "BUSCAR CITA MEDICA";
            // 
            // txbsintomas
            // 
            this.txbsintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsintomas.Location = new System.Drawing.Point(714, 336);
            this.txbsintomas.Multiline = true;
            this.txbsintomas.Name = "txbsintomas";
            this.txbsintomas.Size = new System.Drawing.Size(351, 55);
            this.txbsintomas.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(711, 316);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "SINTOMAS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(711, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "CITA MEDICA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(344, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "ESTADO CIVIL";
            // 
            // txbemailpac
            // 
            this.txbemailpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemailpac.Location = new System.Drawing.Point(363, 365);
            this.txbemailpac.Name = "txbemailpac";
            this.txbemailpac.Size = new System.Drawing.Size(326, 26);
            this.txbemailpac.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(360, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "EMAIL";
            // 
            // txbtelefonopac
            // 
            this.txbtelefonopac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtelefonopac.Location = new System.Drawing.Point(22, 365);
            this.txbtelefonopac.Name = "txbtelefonopac";
            this.txbtelefonopac.Size = new System.Drawing.Size(319, 26);
            this.txbtelefonopac.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "TELFONO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(165, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "TIPO DE SANGRE";
            // 
            // txbdireccionpac
            // 
            this.txbdireccionpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdireccionpac.Location = new System.Drawing.Point(22, 316);
            this.txbdireccionpac.Name = "txbdireccionpac";
            this.txbdireccionpac.Size = new System.Drawing.Size(667, 26);
            this.txbdireccionpac.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "DIRECCION";
            // 
            // txbcipac
            // 
            this.txbcipac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcipac.Location = new System.Drawing.Point(22, 267);
            this.txbcipac.Name = "txbcipac";
            this.txbcipac.Size = new System.Drawing.Size(137, 26);
            this.txbcipac.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "CI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(899, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "HORA DE REG.";
            // 
            // txbhoracita
            // 
            this.txbhoracita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbhoracita.Location = new System.Drawing.Point(902, 202);
            this.txbhoracita.Name = "txbhoracita";
            this.txbhoracita.Size = new System.Drawing.Size(163, 26);
            this.txbhoracita.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(711, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "FECHA DE REG.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(634, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "ANO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(576, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "MES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "DIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "FECHA DE NAC.";
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(247, 208);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(34, 17);
            this.rbtnM.TabIndex = 8;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Location = new System.Drawing.Point(192, 208);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(31, 17);
            this.rbtnF.TabIndex = 7;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEXO";
            // 
            // txbxnombremedico
            // 
            this.txbxnombremedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxnombremedico.Location = new System.Drawing.Point(711, 132);
            this.txbxnombremedico.Name = "txbxnombremedico";
            this.txbxnombremedico.Size = new System.Drawing.Size(354, 26);
            this.txbxnombremedico.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "MEDICO";
            // 
            // txbnombrepac
            // 
            this.txbnombrepac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnombrepac.Location = new System.Drawing.Point(165, 132);
            this.txbnombrepac.Name = "txbnombrepac";
            this.txbnombrepac.Size = new System.Drawing.Size(260, 26);
            this.txbnombrepac.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.DefaultUserProfile;
            this.pictureBox1.Location = new System.Drawing.Point(22, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // citamedicaTableAdapter
            // 
            this.citamedicaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 731);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBVcitasmedicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citamedicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneliminarhis;
        private System.Windows.Forms.Button btnguardarhistorial;
        private System.Windows.Forms.TextBox txbdetalles;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txbtratamiento;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txbdiagnostic;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txbantecedentes;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView DGVhistorial;
        private System.Windows.Forms.TextBox txbfrecuencia;
        private System.Windows.Forms.TextBox txbestatura;
        private System.Windows.Forms.TextBox txbpeso;
        private System.Windows.Forms.TextBox txbtempera;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbpresionarte;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbxtipoatencion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbsintomas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbemailpac;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbtelefonopac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbdireccionpac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbcipac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbhoracita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxnombremedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbnombrepac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbxapellidopac;
        private System.Windows.Forms.Button btnseleccionarcita;
        private System.Windows.Forms.DataGridView DBVcitasmedicas;
        private System.Windows.Forms.TextBox txbfiltrocitamedica;
        private System.Windows.Forms.TextBox txtfechacita;
        private System.Windows.Forms.TextBox txbidcita;
        private System.Windows.Forms.TextBox txbestadocivil;
        private System.Windows.Forms.TextBox txbtiposangre;
        private System.Windows.Forms.TextBox txbanos;
        private System.Windows.Forms.TextBox txbmeses;
        private System.Windows.Forms.TextBox txbdias;
        private System.Windows.Forms.TextBox txbfechanacpac;
        private System.Windows.Forms.ComboBox cmbxfiltrocita;
        private SAPSDBDataSet sAPSDBDataSet;
        private System.Windows.Forms.BindingSource citamedicaBindingSource;
        private Presentation.SAPSDBDataSetTableAdapters.citamedicaTableAdapter citamedicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacinteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sintomasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label30;
    }
}

