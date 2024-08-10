
namespace Campeonato_Polideportivo
{
    partial class Usuarios
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
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblPermisos = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.LblNomUsuario = new System.Windows.Forms.Label();
            this.CmbPermisos = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.LblNuevoUsuario = new System.Windows.Forms.Label();
            this.BtnVer = new System.Windows.Forms.Button();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.LblContraseñaConfirmacion = new System.Windows.Forms.Label();
            this.TxtConfirmacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCorreo.Location = new System.Drawing.Point(536, 244);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(305, 22);
            this.TxtCorreo.TabIndex = 70;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtContrasenia.Location = new System.Drawing.Point(536, 170);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '•';
            this.TxtContrasenia.Size = new System.Drawing.Size(305, 22);
            this.TxtContrasenia.TabIndex = 69;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUsuario.Location = new System.Drawing.Point(536, 134);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(305, 22);
            this.TxtUsuario.TabIndex = 68;
            // 
            // LblPermisos
            // 
            this.LblPermisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPermisos.AutoSize = true;
            this.LblPermisos.Location = new System.Drawing.Point(241, 289);
            this.LblPermisos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPermisos.Name = "LblPermisos";
            this.LblPermisos.Size = new System.Drawing.Size(67, 16);
            this.LblPermisos.TabIndex = 67;
            this.LblPermisos.Text = "Permisos:";
            // 
            // LblCorreo
            // 
            this.LblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(241, 247);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(121, 16);
            this.LblCorreo.TabIndex = 65;
            this.LblCorreo.Text = "Correo Electrónico:";
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.Location = new System.Drawing.Point(241, 174);
            this.LblContrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(79, 16);
            this.LblContrasenia.TabIndex = 64;
            this.LblContrasenia.Text = "Contraseña:";
            // 
            // LblNomUsuario
            // 
            this.LblNomUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNomUsuario.AutoSize = true;
            this.LblNomUsuario.Location = new System.Drawing.Point(241, 138);
            this.LblNomUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNomUsuario.Name = "LblNomUsuario";
            this.LblNomUsuario.Size = new System.Drawing.Size(128, 16);
            this.LblNomUsuario.TabIndex = 63;
            this.LblNomUsuario.Text = "Nombre de Usuario:";
            // 
            // CmbPermisos
            // 
            this.CmbPermisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbPermisos.FormattingEnabled = true;
            this.CmbPermisos.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Usuario Estándar"});
            this.CmbPermisos.Location = new System.Drawing.Point(536, 289);
            this.CmbPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.CmbPermisos.Name = "CmbPermisos";
            this.CmbPermisos.Size = new System.Drawing.Size(305, 24);
            this.CmbPermisos.TabIndex = 71;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnRegistrar.Location = new System.Drawing.Point(245, 341);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(597, 41);
            this.BtnRegistrar.TabIndex = 72;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // LblNuevoUsuario
            // 
            this.LblNuevoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNuevoUsuario.AutoSize = true;
            this.LblNuevoUsuario.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevoUsuario.Location = new System.Drawing.Point(429, 52);
            this.LblNuevoUsuario.Name = "LblNuevoUsuario";
            this.LblNuevoUsuario.Size = new System.Drawing.Size(254, 50);
            this.LblNuevoUsuario.TabIndex = 73;
            this.LblNuevoUsuario.Text = "NUEVO USUARIO";
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnVer.Location = new System.Drawing.Point(245, 386);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(597, 41);
            this.BtnVer.TabIndex = 74;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(136, 447);
            this.DgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersWidth = 51;
            this.DgvUsuarios.Size = new System.Drawing.Size(827, 149);
            this.DgvUsuarios.TabIndex = 75;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.DgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // LblContraseñaConfirmacion
            // 
            this.LblContraseñaConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblContraseñaConfirmacion.AutoSize = true;
            this.LblContraseñaConfirmacion.Location = new System.Drawing.Point(241, 212);
            this.LblContraseñaConfirmacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContraseñaConfirmacion.Name = "LblContraseñaConfirmacion";
            this.LblContraseñaConfirmacion.Size = new System.Drawing.Size(135, 16);
            this.LblContraseñaConfirmacion.TabIndex = 76;
            this.LblContraseñaConfirmacion.Text = "Confirma Contraseña:";
            // 
            // TxtConfirmacion
            // 
            this.TxtConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtConfirmacion.Location = new System.Drawing.Point(536, 208);
            this.TxtConfirmacion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfirmacion.Name = "TxtConfirmacion";
            this.TxtConfirmacion.PasswordChar = '•';
            this.TxtConfirmacion.Size = new System.Drawing.Size(305, 22);
            this.TxtConfirmacion.TabIndex = 77;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 654);
            this.Controls.Add(this.TxtConfirmacion);
            this.Controls.Add(this.LblContraseñaConfirmacion);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LblNuevoUsuario);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.CmbPermisos);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblPermisos);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblContrasenia);
            this.Controls.Add(this.LblNomUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblPermisos;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.Label LblNomUsuario;
        private System.Windows.Forms.ComboBox CmbPermisos;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label LblNuevoUsuario;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Label LblContraseñaConfirmacion;
        private System.Windows.Forms.TextBox TxtConfirmacion;
    }
}