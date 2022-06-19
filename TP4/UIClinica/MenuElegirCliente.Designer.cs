namespace UIClinica
{
    partial class MenuElegirCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dtvg_MedicosLista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.lbl_codigoCliente = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_MedicosLista)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(362, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 53);
            this.button1.TabIndex = 26;
            this.button1.Text = "BUSCAR MEDICO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtvg_MedicosLista
            // 
            this.dtvg_MedicosLista.AllowUserToAddRows = false;
            this.dtvg_MedicosLista.AllowUserToDeleteRows = false;
            this.dtvg_MedicosLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.dtvg_MedicosLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvg_MedicosLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvg_MedicosLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvg_MedicosLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvg_MedicosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvg_MedicosLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Legajo,
            this.Especialidad});
            this.dtvg_MedicosLista.GridColor = System.Drawing.Color.SteelBlue;
            this.dtvg_MedicosLista.Location = new System.Drawing.Point(362, 45);
            this.dtvg_MedicosLista.Name = "dtvg_MedicosLista";
            this.dtvg_MedicosLista.ReadOnly = true;
            this.dtvg_MedicosLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvg_MedicosLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvg_MedicosLista.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtvg_MedicosLista.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtvg_MedicosLista.RowTemplate.Height = 25;
            this.dtvg_MedicosLista.Size = new System.Drawing.Size(348, 168);
            this.dtvg_MedicosLista.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Dni";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Edad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_buscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscarCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buscarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_buscarCliente.Location = new System.Drawing.Point(22, 198);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(178, 53);
            this.btn_buscarCliente.TabIndex = 24;
            this.btn_buscarCliente.Text = "BUSCAR CLIENTE";
            this.btn_buscarCliente.UseVisualStyleBackColor = false;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // lbl_codigoCliente
            // 
            this.lbl_codigoCliente.AutoSize = true;
            this.lbl_codigoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigoCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codigoCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_codigoCliente.Location = new System.Drawing.Point(22, 45);
            this.lbl_codigoCliente.Name = "lbl_codigoCliente";
            this.lbl_codigoCliente.Size = new System.Drawing.Size(266, 28);
            this.lbl_codigoCliente.TabIndex = 23;
            this.lbl_codigoCliente.Text = "INGRESE EL DNI DEL CLIENTE";
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dni.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dni.ForeColor = System.Drawing.Color.White;
            this.txt_dni.Location = new System.Drawing.Point(22, 107);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(259, 27);
            this.txt_dni.TabIndex = 30;
            this.txt_dni.Tag = "Ingrese Legajo";
            this.txt_dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // MenuElegirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtvg_MedicosLista);
            this.Controls.Add(this.btn_buscarCliente);
            this.Controls.Add(this.lbl_codigoCliente);
            this.Name = "MenuElegirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuElegirCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_MedicosLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtvg_MedicosLista;
        private System.Windows.Forms.Button btn_buscarCliente;
        private System.Windows.Forms.Label lbl_codigoCliente;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}