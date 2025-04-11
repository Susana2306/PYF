namespace PYF.Formularios
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblOlvidasteC = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.Location = new System.Drawing.Point(12, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(41, 36);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(700, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 82);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(186, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCrearCuenta);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.lblOlvidasteC);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(178, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 281);
            this.panel1.TabIndex = 5;
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCrearCuenta.Location = new System.Drawing.Point(129, 242);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(163, 17);
            this.lblCrearCuenta.TabIndex = 10;
            this.lblCrearCuenta.Text = "¿No tienes cuenta? Créala";
            this.lblCrearCuenta.Click += new System.EventHandler(this.lblCrearCuenta_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Azure;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnIniciarSesion.Location = new System.Drawing.Point(153, 194);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(113, 38);
            this.btnIniciarSesion.TabIndex = 9;
            this.btnIniciarSesion.Text = "INGRESAR";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // lblOlvidasteC
            // 
            this.lblOlvidasteC.AutoSize = true;
            this.lblOlvidasteC.Font = new System.Drawing.Font("Perpetua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidasteC.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblOlvidasteC.Location = new System.Drawing.Point(183, 138);
            this.lblOlvidasteC.Name = "lblOlvidasteC";
            this.lblOlvidasteC.Size = new System.Drawing.Size(165, 17);
            this.lblOlvidasteC.TabIndex = 8;
            this.lblOlvidasteC.Text = "¿Olvidaste tu contraseña?";
            this.lblOlvidasteC.Click += new System.EventHandler(this.lblOlvidasteC_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(156, 95);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(217, 29);
            this.txtContrasena.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(156, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(217, 32);
            this.txtUsuario.TabIndex = 5;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInicio);
            this.Name = "frmInicioSesion";
            this.Text = "InicioSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOlvidasteC;
        private System.Windows.Forms.Label lblCrearCuenta;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}