namespace SI_Machine
{
    partial class Form1
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
            this.ofArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.lvCorreos = new System.Windows.Forms.ListView();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.btnEnviarCorreos = new System.Windows.Forms.Button();
            this.wbTemplate = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofArchivo
            // 
            this.ofArchivo.FileName = "*.*";
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Location = new System.Drawing.Point(364, 12);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(183, 23);
            this.btnBuscarArchivo.TabIndex = 4;
            this.btnBuscarArchivo.Text = "Cargar Correos";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // lvCorreos
            // 
            this.lvCorreos.Location = new System.Drawing.Point(12, 43);
            this.lvCorreos.Name = "lvCorreos";
            this.lvCorreos.Size = new System.Drawing.Size(535, 395);
            this.lvCorreos.TabIndex = 5;
            this.lvCorreos.UseCompatibleStateImageBehavior = false;
            this.lvCorreos.View = System.Windows.Forms.View.Details;
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(1074, 12);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(183, 23);
            this.btnTemplate.TabIndex = 6;
            this.btnTemplate.Text = "Cargar Template";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(554, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Text = "Facebook";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(554, 141);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 20);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "grupo4.seg.inf@gmail.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(554, 190);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "seg123456";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(554, 43);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(182, 20);
            this.txtAsunto.TabIndex = 10;
            this.txtAsunto.Text = "Cambios";
            // 
            // btnEnviarCorreos
            // 
            this.btnEnviarCorreos.Location = new System.Drawing.Point(554, 218);
            this.btnEnviarCorreos.Name = "btnEnviarCorreos";
            this.btnEnviarCorreos.Size = new System.Drawing.Size(182, 23);
            this.btnEnviarCorreos.TabIndex = 11;
            this.btnEnviarCorreos.Text = "Enviar Correos";
            this.btnEnviarCorreos.UseVisualStyleBackColor = true;
            this.btnEnviarCorreos.Click += new System.EventHandler(this.btnEnviarCorreos_Click);
            // 
            // wbTemplate
            // 
            this.wbTemplate.Location = new System.Drawing.Point(742, 43);
            this.wbTemplate.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTemplate.Name = "wbTemplate";
            this.wbTemplate.Size = new System.Drawing.Size(515, 395);
            this.wbTemplate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Asunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Clave:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Emails";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(742, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Template";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 451);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wbTemplate);
            this.Controls.Add(this.btnEnviarCorreos);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnTemplate);
            this.Controls.Add(this.lvCorreos);
            this.Controls.Add(this.btnBuscarArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofArchivo;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.ListView lvCorreos;
        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Button btnEnviarCorreos;
        private System.Windows.Forms.WebBrowser wbTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

