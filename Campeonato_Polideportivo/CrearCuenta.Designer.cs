
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.LblCrearCuenta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 29);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // LblCrearCuenta
            // 
            this.LblCrearCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCrearCuenta.AutoSize = true;
            this.LblCrearCuenta.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrearCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblCrearCuenta.Location = new System.Drawing.Point(276, 53);
            this.LblCrearCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCrearCuenta.Name = "LblCrearCuenta";
            this.LblCrearCuenta.Size = new System.Drawing.Size(196, 40);
            this.LblCrearCuenta.TabIndex = 58;
            this.LblCrearCuenta.Text = "CREAR CUENTA";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Haettenschweiler", 18F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.lblUsuario.Location = new System.Drawing.Point(152, 145);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 26);
            this.lblUsuario.TabIndex = 59;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Haettenschweiler", 18F);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.lblContraseña.Location = new System.Drawing.Point(152, 177);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(104, 26);
            this.lblContraseña.TabIndex = 60;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Haettenschweiler", 18F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.lblCorreo.Location = new System.Drawing.Point(152, 254);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(160, 26);
            this.lblCorreo.TabIndex = 61;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(374, 151);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 20);
            this.txtUsuario.TabIndex = 62;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasenia.Location = new System.Drawing.Point(374, 184);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '•';
            this.txtContrasenia.Size = new System.Drawing.Size(230, 20);
            this.txtContrasenia.TabIndex = 63;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Location = new System.Drawing.Point(374, 264);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(230, 20);
            this.txtCorreo.TabIndex = 64;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(65)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(156, 308);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(448, 33);
            this.btnRegistrar.TabIndex = 65;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Font = new System.Drawing.Font("Haettenschweiler", 18F);
            this.lblConfirmacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.lblConfirmacion.Location = new System.Drawing.Point(152, 217);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(115, 26);
            this.lblConfirmacion.TabIndex = 66;
            this.lblConfirmacion.Text = "Confirmación:";
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmacion.Location = new System.Drawing.Point(374, 226);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.PasswordChar = '•';
            this.txtConfirmacion.Size = new System.Drawing.Size(230, 20);
            this.txtConfirmacion.TabIndex = 67;
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(746, 531);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.LblCrearCuenta);
            this.Controls.Add(this.btnSalir);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label LblCrearCuenta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.TextBox txtConfirmacion;
    }
}