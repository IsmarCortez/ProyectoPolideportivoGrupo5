
namespace Campeonato_Polideportivo
{
    partial class CrearCuenta
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblCrearCuenta = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.LblConfirmacion = new System.Windows.Forms.Label();
            this.TxtConfirmacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Location = new System.Drawing.Point(16, 15);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(43, 36);
            this.BtnSalir.TabIndex = 57;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblCrearCuenta
            // 
            this.LblCrearCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCrearCuenta.AutoSize = true;
            this.LblCrearCuenta.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrearCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblCrearCuenta.Location = new System.Drawing.Point(368, 65);
            this.LblCrearCuenta.Name = "LblCrearCuenta";
            this.LblCrearCuenta.Size = new System.Drawing.Size(240, 50);
            this.LblCrearCuenta.TabIndex = 58;
            this.LblCrearCuenta.Text = "CREAR CUENTA";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Haettenschweiler", 18F);
            this.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblUsuario.Location = new System.Drawing.Point(203, 178);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(91, 32);
            this.LblUsuario.TabIndex = 59;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Haettenschweiler", 18F);
            this.LblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblContraseña.Location = new System.Drawing.Point(203, 218);
            this.LblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(127, 32);
            this.LblContraseña.TabIndex = 60;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // LblCorreo
            // 
            this.LblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Haettenschweiler", 18F);
            this.LblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblCorreo.Location = new System.Drawing.Point(203, 313);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(196, 32);
            this.LblCorreo.TabIndex = 61;
            this.LblCorreo.Text = "Correo Electrónico:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUsuario.Location = new System.Drawing.Point(499, 186);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(305, 22);
            this.TxtUsuario.TabIndex = 62;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtContrasenia.Location = new System.Drawing.Point(499, 226);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '•';
            this.TxtContrasenia.Size = new System.Drawing.Size(305, 22);
            this.TxtContrasenia.TabIndex = 63;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCorreo.Location = new System.Drawing.Point(499, 325);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(305, 22);
            this.TxtCorreo.TabIndex = 64;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(65)))));
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(208, 379);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(597, 41);
            this.BtnRegistrar.TabIndex = 65;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // LblConfirmacion
            // 
            this.LblConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblConfirmacion.AutoSize = true;
            this.LblConfirmacion.Font = new System.Drawing.Font("Haettenschweiler", 18F);
            this.LblConfirmacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblConfirmacion.Location = new System.Drawing.Point(203, 267);
            this.LblConfirmacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConfirmacion.Name = "LblConfirmacion";
            this.LblConfirmacion.Size = new System.Drawing.Size(142, 32);
            this.LblConfirmacion.TabIndex = 66;
            this.LblConfirmacion.Text = "Confirmación:";
            // 
            // TxtConfirmacion
            // 
            this.TxtConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtConfirmacion.Location = new System.Drawing.Point(499, 278);
            this.TxtConfirmacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtConfirmacion.Name = "TxtConfirmacion";
            this.TxtConfirmacion.PasswordChar = '•';
            this.TxtConfirmacion.Size = new System.Drawing.Size(305, 22);
            this.TxtConfirmacion.TabIndex = 67;
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(995, 654);
            this.Controls.Add(this.TxtConfirmacion);
            this.Controls.Add(this.LblConfirmacion);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblCrearCuenta);
            this.Controls.Add(this.BtnSalir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblCrearCuenta;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label LblConfirmacion;
        private System.Windows.Forms.TextBox TxtConfirmacion;
    }
}