namespace UIClinica
{
    partial class MenuOperador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AltaTurno = new System.Windows.Forms.Button();
            this.btn_listaInventario = new System.Windows.Forms.Button();
            this.btn_listaEmpleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_AltaTurno);
            this.panel1.Controls.Add(this.btn_listaInventario);
            this.panel1.Controls.Add(this.btn_listaEmpleados);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 539);
            this.panel1.TabIndex = 0;
            // 
            // btn_AltaTurno
            // 
            this.btn_AltaTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_AltaTurno.FlatAppearance.BorderSize = 0;
            this.btn_AltaTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AltaTurno.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AltaTurno.ForeColor = System.Drawing.Color.White;
            this.btn_AltaTurno.Location = new System.Drawing.Point(14, 149);
            this.btn_AltaTurno.Name = "btn_AltaTurno";
            this.btn_AltaTurno.Size = new System.Drawing.Size(169, 39);
            this.btn_AltaTurno.TabIndex = 13;
            this.btn_AltaTurno.Text = "Alta Turno";
            this.btn_AltaTurno.UseVisualStyleBackColor = false;
            this.btn_AltaTurno.Click += new System.EventHandler(this.btn_AltaTurno_Click);
            // 
            // btn_listaInventario
            // 
            this.btn_listaInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_listaInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listaInventario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_listaInventario.ForeColor = System.Drawing.Color.White;
            this.btn_listaInventario.Location = new System.Drawing.Point(14, 331);
            this.btn_listaInventario.Name = "btn_listaInventario";
            this.btn_listaInventario.Size = new System.Drawing.Size(169, 39);
            this.btn_listaInventario.TabIndex = 12;
            this.btn_listaInventario.Text = "Lista inventario";
            this.btn_listaInventario.UseVisualStyleBackColor = false;
            this.btn_listaInventario.Visible = false;
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
            this.btn_listaEmpleados.Text = "Lista Empleados";
            this.btn_listaEmpleados.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOMBRE OPE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "OPERADOR:";
            // 
            // MenuOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1098, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuOperador";
            this.Text = "MenuOperador";
            this.Load += new System.EventHandler(this.MenuOperador_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AltaTurno;
        private System.Windows.Forms.Button btn_listaInventario;
        private System.Windows.Forms.Button btn_listaEmpleados;
        private System.Windows.Forms.Label label2;
    }
}