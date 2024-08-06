
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.LblCampeonato = new System.Windows.Forms.Label();
            this.BtnVer = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Location = new System.Drawing.Point(402, 170);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(230, 20);
            this.txtCorreo.TabIndex = 70;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasenia.Location = new System.Drawing.Point(402, 138);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(230, 20);
            this.txtContrasenia.TabIndex = 69;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(402, 109);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 20);
            this.txtUsuario.TabIndex = 68;
            // 
            // lblPermisos
            // 
            this.lblPermisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(181, 207);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(52, 13);
            this.lblPermisos.TabIndex = 67;
            this.lblPermisos.Text = "Permisos:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(181, 173);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(97, 13);
            this.lblCorreo.TabIndex = 65;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(181, 141);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenia.TabIndex = 64;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(181, 112);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblNomUsuario.TabIndex = 63;
            this.lblNomUsuario.Text = "Nombre de Usuario:";
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Usuario Estándar"});
            this.cmbPermisos.Location = new System.Drawing.Point(402, 207);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(230, 21);
            this.cmbPermisos.TabIndex = 71;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRegistrar.Location = new System.Drawing.Point(184, 247);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(448, 33);
            this.btnRegistrar.TabIndex = 72;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // LblCampeonato
            // 
            this.LblCampeonato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCampeonato.AutoSize = true;
            this.LblCampeonato.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampeonato.Location = new System.Drawing.Point(322, 42);
            this.LblCampeonato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCampeonato.Name = "LblCampeonato";
            this.LblCampeonato.Size = new System.Drawing.Size(210, 40);
            this.LblCampeonato.TabIndex = 73;
            this.LblCampeonato.Text = "NUEVO USUARIO";
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
            this.BtnVer.Location = new System.Drawing.Point(184, 284);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(448, 33);
            this.BtnVer.TabIndex = 74;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(105, 347);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(620, 121);
            this.dgvUsuarios.TabIndex = 75;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 531);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LblCampeonato);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbPermisos);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNomUsuario);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.ComboBox cmbPermisos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label LblCampeonato;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}