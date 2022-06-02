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
            this.lblEspecialidad.Location = new System.Drawing.Point(78, 84);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(108, 129);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(42, 13);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Medico";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(108, 174);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(108, 210);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Location = new System.Drawing.Point(48, 252);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(102, 13);
            this.lblSintomas.TabIndex = 5;
            this.lblSintomas.Text = "Sintomas (opcional):";
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Location = new System.Drawing.Point(169, 81);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(200, 21);
            this.cbxEspecialidad.TabIndex = 6;
            // 
            // cbxMedico
            // 
            this.cbxMedico.FormattingEnabled = true;
            this.cbxMedico.Location = new System.Drawing.Point(169, 121);
            this.cbxMedico.Name = "cbxMedico";
            this.cbxMedico.Size = new System.Drawing.Size(200, 21);
            this.cbxMedico.TabIndex = 7;
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(169, 207);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(121, 21);
            this.cbxHora.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(169, 174);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(169, 252);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(181, 93);
            this.txtSintomas.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(181, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 129;
            this.btnCancel.Text = "X  Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(356, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // FormAddCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 507);
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
            this.Name = "FormAddCitaMedica";
            this.Text = "Añadir cita medica";
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