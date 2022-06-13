namespace UIClinica
{
    partial class MenuCliente
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
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelarTurno = new System.Windows.Forms.Button();
            this.dtvg_clienteTurno = new System.Windows.Forms.DataGridView();
            this.btn_aceptarCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_clienteTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreCliente.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(95, 9);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(124, 28);
            this.lbl_nombreCliente.TabIndex = 15;
            this.lbl_nombreCliente.Text = "NOMBRE CLI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "CLIENTE:";
            // 
            // btn_cancelarTurno
            // 
            this.btn_cancelarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_cancelarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelarTurno.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelarTurno.ForeColor = System.Drawing.Color.White;
            this.btn_cancelarTurno.Location = new System.Drawing.Point(12, 76);
            this.btn_cancelarTurno.Name = "btn_cancelarTurno";
            this.btn_cancelarTurno.Size = new System.Drawing.Size(207, 39);
            this.btn_cancelarTurno.TabIndex = 17;
            this.btn_cancelarTurno.Text = "CANCELAR TURNO";
            this.btn_cancelarTurno.UseVisualStyleBackColor = false;
            this.btn_cancelarTurno.Click += new System.EventHandler(this.btn_cancelarTurno_Click);
            // 
            // dtvg_clienteTurno
            // 
            this.dtvg_clienteTurno.AllowUserToAddRows = false;
            this.dtvg_clienteTurno.AllowUserToDeleteRows = false;
            this.dtvg_clienteTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtvg_clienteTurno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.dtvg_clienteTurno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvg_clienteTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvg_clienteTurno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvg_clienteTurno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvg_clienteTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvg_clienteTurno.GridColor = System.Drawing.Color.SteelBlue;
            this.dtvg_clienteTurno.Location = new System.Drawing.Point(12, 132);
            this.dtvg_clienteTurno.Name = "dtvg_clienteTurno";
            this.dtvg_clienteTurno.ReadOnly = true;
            this.dtvg_clienteTurno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvg_clienteTurno.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvg_clienteTurno.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtvg_clienteTurno.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtvg_clienteTurno.RowTemplate.Height = 25;
            this.dtvg_clienteTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvg_clienteTurno.Size = new System.Drawing.Size(613, 338);
            this.dtvg_clienteTurno.TabIndex = 34;
            // 
            // btn_aceptarCancelar
            // 
            this.btn_aceptarCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_aceptarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aceptarCancelar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptarCancelar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptarCancelar.Location = new System.Drawing.Point(12, 489);
            this.btn_aceptarCancelar.Name = "btn_aceptarCancelar";
            this.btn_aceptarCancelar.Size = new System.Drawing.Size(207, 39);
            this.btn_aceptarCancelar.TabIndex = 35;
            this.btn_aceptarCancelar.Text = "ACEPTAR";
            this.btn_aceptarCancelar.UseVisualStyleBackColor = false;
            this.btn_aceptarCancelar.Click += new System.EventHandler(this.btn_aceptarCancelar_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(683, 569);
            this.Controls.Add(this.btn_aceptarCancelar);
            this.Controls.Add(this.dtvg_clienteTurno);
            this.Controls.Add(this.btn_cancelarTurno);
            this.Controls.Add(this.lbl_nombreCliente);
            this.Controls.Add(this.label2);
            this.Name = "MenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCliente";
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_clienteTurno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelarTurno;
        private System.Windows.Forms.DataGridView dtvg_clienteTurno;
        private System.Windows.Forms.Button btn_aceptarCancelar;
    }
}