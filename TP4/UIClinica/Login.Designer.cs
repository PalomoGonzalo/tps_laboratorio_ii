namespace UIClinica
{
    partial class Login
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_autoLogMedico = new System.Windows.Forms.Button();
            this.btn_autoOperador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loggear = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.btn_clienteLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(186, 437);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(85, 29);
            this.btn_salir.TabIndex = 36;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // btn_autoLogMedico
            // 
            this.btn_autoLogMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_autoLogMedico.FlatAppearance.BorderSize = 0;
            this.btn_autoLogMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autoLogMedico.ForeColor = System.Drawing.Color.White;
            this.btn_autoLogMedico.Location = new System.Drawing.Point(12, 324);
            this.btn_autoLogMedico.Name = "btn_autoLogMedico";
            this.btn_autoLogMedico.Size = new System.Drawing.Size(96, 23);
            this.btn_autoLogMedico.TabIndex = 35;
            this.btn_autoLogMedico.Text = "Medico Log";
            this.btn_autoLogMedico.UseVisualStyleBackColor = false;
            this.btn_autoLogMedico.Click += new System.EventHandler(this.btn_autoLogMedico_Click);
            // 
            // btn_autoOperador
            // 
            this.btn_autoOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_autoOperador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_autoOperador.ForeColor = System.Drawing.Color.White;
            this.btn_autoOperador.Location = new System.Drawing.Point(175, 324);
            this.btn_autoOperador.Name = "btn_autoOperador";
            this.btn_autoOperador.Size = new System.Drawing.Size(96, 23);
            this.btn_autoOperador.TabIndex = 34;
            this.btn_autoOperador.Text = "Operador Log";
            this.btn_autoOperador.UseVisualStyleBackColor = false;
            this.btn_autoOperador.Click += new System.EventHandler(this.btn_autoOperador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuario";
            // 
            // btn_loggear
            // 
            this.btn_loggear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_loggear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_loggear.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_loggear.ForeColor = System.Drawing.Color.White;
            this.btn_loggear.Location = new System.Drawing.Point(12, 236);
            this.btn_loggear.Name = "btn_loggear";
            this.btn_loggear.Size = new System.Drawing.Size(259, 49);
            this.btn_loggear.TabIndex = 31;
            this.btn_loggear.Text = "LOGIN";
            this.btn_loggear.UseVisualStyleBackColor = false;
            this.btn_loggear.Click += new System.EventHandler(this.btn_loggear_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(12, 127);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(259, 27);
            this.txt_password.TabIndex = 30;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_legajo
            // 
            this.txt_legajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.txt_legajo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_legajo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_legajo.ForeColor = System.Drawing.Color.White;
            this.txt_legajo.Location = new System.Drawing.Point(12, 40);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(259, 27);
            this.txt_legajo.TabIndex = 29;
            this.txt_legajo.Tag = "Ingrese Legajo";
            this.txt_legajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_legajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_legajo_KeyPress);
            // 
            // btn_clienteLog
            // 
            this.btn_clienteLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.btn_clienteLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clienteLog.ForeColor = System.Drawing.Color.White;
            this.btn_clienteLog.Location = new System.Drawing.Point(99, 374);
            this.btn_clienteLog.Name = "btn_clienteLog";
            this.btn_clienteLog.Size = new System.Drawing.Size(96, 23);
            this.btn_clienteLog.TabIndex = 37;
            this.btn_clienteLog.Text = "Cliente log";
            this.btn_clienteLog.UseVisualStyleBackColor = false;
            this.btn_clienteLog.Click += new System.EventHandler(this.btn_clienteLog_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(280, 642);
            this.Controls.Add(this.btn_clienteLog);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_autoLogMedico);
            this.Controls.Add(this.btn_autoOperador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loggear);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_legajo);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_autoLogMedico;
        private System.Windows.Forms.Button btn_autoOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_loggear;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.Button btn_clienteLog;
    }
}