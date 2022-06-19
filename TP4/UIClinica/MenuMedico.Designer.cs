namespace UIClinica
{
    partial class MenuMedico
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
            this.lbl_nombreMedico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_atender = new System.Windows.Forms.Button();
            this.btn_listaEmpleados = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombreMedico
            // 
            this.lbl_nombreMedico.AutoSize = true;
            this.lbl_nombreMedico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreMedico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreMedico.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreMedico.Location = new System.Drawing.Point(107, 34);
            this.lbl_nombreMedico.Name = "lbl_nombreMedico";
            this.lbl_nombreMedico.Size = new System.Drawing.Size(140, 28);
            this.lbl_nombreMedico.TabIndex = 16;
            this.lbl_nombreMedico.Text = "NOMBRE MED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "MEDICO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_atender);
            this.panel1.Controls.Add(this.btn_listaEmpleados);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 539);
            this.panel1.TabIndex = 15;
            // 
            // btn_atender
            // 
            this.btn_atender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_atender.FlatAppearance.BorderSize = 0;
            this.btn_atender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atender.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_atender.ForeColor = System.Drawing.Color.White;
            this.btn_atender.Location = new System.Drawing.Point(14, 149);
            this.btn_atender.Name = "btn_atender";
            this.btn_atender.Size = new System.Drawing.Size(169, 39);
            this.btn_atender.TabIndex = 13;
            this.btn_atender.Text = "ATENDER ";
            this.btn_atender.UseVisualStyleBackColor = false;
            this.btn_atender.Click += new System.EventHandler(this.btn_atender_Click);
            // 
            // btn_listaEmpleados
            // 
            this.btn_listaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_listaEmpleados.FlatAppearance.BorderSize = 0;
            this.btn_listaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listaEmpleados.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_listaEmpleados.ForeColor = System.Drawing.Color.White;
            this.btn_listaEmpleados.Location = new System.Drawing.Point(14, 242);
            this.btn_listaEmpleados.Name = "btn_listaEmpleados";
            this.btn_listaEmpleados.Size = new System.Drawing.Size(169, 39);
            this.btn_listaEmpleados.TabIndex = 11;
            this.btn_listaEmpleados.Text = "Cancelar Turno";
            this.btn_listaEmpleados.UseVisualStyleBackColor = false;
            this.btn_listaEmpleados.Click += new System.EventHandler(this.btn_listaEmpleados_Click);
            // 
            // MenuMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(302, 711);
            this.Controls.Add(this.lbl_nombreMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuMedico";
            this.Load += new System.EventHandler(this.MenuMedico_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_atender;
        private System.Windows.Forms.Button btn_listaEmpleados;
    }
}