namespace Presentation.ChildForms
{
    partial class FormAddCitaMedica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbxMedico = new System.Windows.Forms.ComboBox();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(117, 129);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(99, 20);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(162, 198);
            this.lblMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(60, 20);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Medico";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(162, 268);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(162, 323);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(48, 20);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Location = new System.Drawing.Point(72, 388);
            this.lblSintomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(153, 20);
            this.lblSintomas.TabIndex = 5;
            this.lblSintomas.Text = "Sintomas (opcional):";
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Location = new System.Drawing.Point(254, 125);
            this.cbxEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(298, 28);
            this.cbxEspecialidad.TabIndex = 6;
            this.cbxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbxEspecialidad_SelectedIndexChanged);
            // 
            // cbxMedico
            // 
            this.cbxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedico.FormattingEnabled = true;
            this.cbxMedico.Location = new System.Drawing.Point(254, 186);
            this.cbxMedico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMedico.Name = "cbxMedico";
            this.cbxMedico.Size = new System.Drawing.Size(298, 28);
            this.cbxMedico.TabIndex = 7;
            // 
            // cbxHora
            // 
            this.cbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(254, 318);
            this.cbxHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(222, 28);
            this.cbxHora.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(254, 268);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(298, 26);
            this.dtpFecha.TabIndex = 9;
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(254, 388);
            this.txtSintomas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(270, 141);
            this.txtSintomas.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(272, 635);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(225, 62);
            this.btnCancel.TabIndex = 129;
            this.btnCancel.Text = "X  Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(534, 635);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 62);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAddCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 780);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbxHora);
            this.Controls.Add(this.cbxMedico);
            this.Controls.Add(this.cbxEspecialidad);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblEspecialidad);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddCitaMedica";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Añadir cita medica";
            this.Load += new System.EventHandler(this.FormAddCitaMedica_Load);
            this.Controls.SetChildIndex(this.lblEspecialidad, 0);
            this.Controls.SetChildIndex(this.lblMedico, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblHora, 0);
            this.Controls.SetChildIndex(this.lblSintomas, 0);
            this.Controls.SetChildIndex(this.cbxEspecialidad, 0);
            this.Controls.SetChildIndex(this.cbxMedico, 0);
            this.Controls.SetChildIndex(this.cbxHora, 0);
            this.Controls.SetChildIndex(this.dtpFecha, 0);
            this.Controls.SetChildIndex(this.txtSintomas, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.ComboBox cbxEspecialidad;
        private System.Windows.Forms.ComboBox cbxMedico;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtSintomas;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
    }
}