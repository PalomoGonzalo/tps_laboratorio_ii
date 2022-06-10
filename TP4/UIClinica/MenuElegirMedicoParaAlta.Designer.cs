namespace UIClinica
{
    partial class MenuElegirMedicoParaAlta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_TipoMedico = new System.Windows.Forms.ComboBox();
            this.lbl_tipoMedico = new System.Windows.Forms.Label();
            this.btn_buscarMedico = new System.Windows.Forms.Button();
            this.dtvg_MedicosLista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_MedicosLista)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_TipoMedico
            // 
            this.cmb_TipoMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.cmb_TipoMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_TipoMedico.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_TipoMedico.ForeColor = System.Drawing.Color.White;
            this.cmb_TipoMedico.FormattingEnabled = true;
            this.cmb_TipoMedico.Items.AddRange(new object[] {
            "Cardiogolo",
            "Cirujano",
            "Clinico"});
            this.cmb_TipoMedico.Location = new System.Drawing.Point(29, 56);
            this.cmb_TipoMedico.Name = "cmb_TipoMedico";
            this.cmb_TipoMedico.Size = new System.Drawing.Size(178, 31);
            this.cmb_TipoMedico.TabIndex = 5;
            // 
            // lbl_tipoMedico
            // 
            this.lbl_tipoMedico.AutoSize = true;
            this.lbl_tipoMedico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipoMedico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tipoMedico.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tipoMedico.Location = new System.Drawing.Point(29, 9);
            this.lbl_tipoMedico.Name = "lbl_tipoMedico";
            this.lbl_tipoMedico.Size = new System.Drawing.Size(178, 28);
            this.lbl_tipoMedico.TabIndex = 6;
            this.lbl_tipoMedico.Text = "Tipo Medico Turno";
            // 
            // btn_buscarMedico
            // 
            this.btn_buscarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_buscarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscarMedico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buscarMedico.ForeColor = System.Drawing.Color.White;
            this.btn_buscarMedico.Location = new System.Drawing.Point(29, 127);
            this.btn_buscarMedico.Name = "btn_buscarMedico";
            this.btn_buscarMedico.Size = new System.Drawing.Size(178, 53);
            this.btn_buscarMedico.TabIndex = 19;
            this.btn_buscarMedico.Text = "BUSCAR MEDICO";
            this.btn_buscarMedico.UseVisualStyleBackColor = false;
            this.btn_buscarMedico.Click += new System.EventHandler(this.btn_buscarMedico_Click);
            // 
            // dtvg_MedicosLista
            // 
            this.dtvg_MedicosLista.AllowUserToAddRows = false;
            this.dtvg_MedicosLista.AllowUserToDeleteRows = false;
            this.dtvg_MedicosLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.dtvg_MedicosLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvg_MedicosLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvg_MedicosLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvg_MedicosLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtvg_MedicosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvg_MedicosLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Legajo,
            this.Especialidad});
            this.dtvg_MedicosLista.GridColor = System.Drawing.Color.SteelBlue;
            this.dtvg_MedicosLista.Location = new System.Drawing.Point(300, 12);
            this.dtvg_MedicosLista.Name = "dtvg_MedicosLista";
            this.dtvg_MedicosLista.ReadOnly = true;
            this.dtvg_MedicosLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvg_MedicosLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtvg_MedicosLista.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dtvg_MedicosLista.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtvg_MedicosLista.RowTemplate.Height = 25;
            this.dtvg_MedicosLista.Size = new System.Drawing.Size(348, 168);
            this.dtvg_MedicosLista.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Id";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(300, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "BUSCAR AGENDA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuElegirMedicoParaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(700, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtvg_MedicosLista);
            this.Controls.Add(this.btn_buscarMedico);
            this.Controls.Add(this.lbl_tipoMedico);
            this.Controls.Add(this.cmb_TipoMedico);
            this.Name = "MenuElegirMedicoParaAlta";
            this.Text = "MenuElegirMedicoParaAlta";
            this.Load += new System.EventHandler(this.MenuElegirMedicoParaAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_MedicosLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_TipoMedico;
        private System.Windows.Forms.Label lbl_tipoMedico;
        private System.Windows.Forms.Button btn_buscarMedico;
        private System.Windows.Forms.DataGridView dtvg_MedicosLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}