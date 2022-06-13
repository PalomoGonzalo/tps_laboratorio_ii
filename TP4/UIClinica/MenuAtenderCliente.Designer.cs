namespace UIClinica
{
    partial class MenuAtenderCliente
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
            this.btn_atenderCliente = new System.Windows.Forms.Button();
            this.dtvg_turnosLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_turnosLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atenderCliente
            // 
            this.btn_atenderCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_atenderCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_atenderCliente.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_atenderCliente.ForeColor = System.Drawing.Color.White;
            this.btn_atenderCliente.Location = new System.Drawing.Point(12, 389);
            this.btn_atenderCliente.Name = "btn_atenderCliente";
            this.btn_atenderCliente.Size = new System.Drawing.Size(358, 49);
            this.btn_atenderCliente.TabIndex = 32;
            this.btn_atenderCliente.Text = "ATENDER CLIENTE";
            this.btn_atenderCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_atenderCliente.UseVisualStyleBackColor = false;
            this.btn_atenderCliente.Click += new System.EventHandler(this.btn_atenderCliente_Click);
            // 
            // dtvg_turnosLista
            // 
            this.dtvg_turnosLista.AllowUserToAddRows = false;
            this.dtvg_turnosLista.AllowUserToDeleteRows = false;
            this.dtvg_turnosLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtvg_turnosLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.dtvg_turnosLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvg_turnosLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvg_turnosLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvg_turnosLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvg_turnosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvg_turnosLista.GridColor = System.Drawing.Color.SteelBlue;
            this.dtvg_turnosLista.Location = new System.Drawing.Point(12, 21);
            this.dtvg_turnosLista.Name = "dtvg_turnosLista";
            this.dtvg_turnosLista.ReadOnly = true;
            this.dtvg_turnosLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvg_turnosLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvg_turnosLista.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtvg_turnosLista.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtvg_turnosLista.RowTemplate.Height = 25;
            this.dtvg_turnosLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvg_turnosLista.Size = new System.Drawing.Size(613, 338);
            this.dtvg_turnosLista.TabIndex = 33;
            // 
            // MenuAtenderCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.dtvg_turnosLista);
            this.Controls.Add(this.btn_atenderCliente);
            this.Name = "MenuAtenderCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAtenderCliente";
            this.Load += new System.EventHandler(this.MenuAtenderCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_turnosLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_atenderCliente;
        private System.Windows.Forms.DataGridView dtvg_turnosLista;
    }
}