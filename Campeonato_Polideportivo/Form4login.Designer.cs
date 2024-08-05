
namespace Campeonato_Polideportivo
{
    partial class Form4login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.llblAdmin = new System.Windows.Forms.LinkLabel();
            this.llblCuenta = new System.Windows.Forms.LinkLabel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 531);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Campeonato_Polideportivo.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.llblAdmin);
            this.PanelForm.Controls.Add(this.llblCuenta);
            this.PanelForm.Controls.Add(this.BtnIngresar);
            this.PanelForm.Controls.Add(this.TxtContrasenia);
            this.PanelForm.Controls.Add(this.TxtUsuario);
            this.PanelForm.Controls.Add(this.LblLogin);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(200, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(688, 531);
            this.PanelForm.TabIndex = 1;
            this.PanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // llblAdmin
            // 
            this.llblAdmin.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.llblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llblAdmin.AutoSize = true;
            this.llblAdmin.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAdmin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.llblAdmin.Location = new System.Drawing.Point(594, 505);
            this.llblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblAdmin.Name = "llblAdmin";
            this.llblAdmin.Size = new System.Drawing.Size(83, 17);
            this.llblAdmin.TabIndex = 18;
            this.llblAdmin.TabStop = true;
            this.llblAdmin.Text = "Administrador";
            this.llblAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAdmin_LinkClicked_1);
            // 
            // llblCuenta
            // 
            this.llblCuenta.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.llblCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblCuenta.AutoSize = true;
            this.llblCuenta.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCuenta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.llblCuenta.Location = new System.Drawing.Point(319, 349);
            this.llblCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblCuenta.Name = "llblCuenta";
            this.llblCuenta.Size = new System.Drawing.Size(109, 17);
            this.llblCuenta.TabIndex = 17;
            this.llblCuenta.TabStop = true;
            this.llblCuenta.Text = "No tengo una cuenta";
            this.llblCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCuenta_LinkClicked);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnIngresar.Location = new System.Drawing.Point(149, 287);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(454, 33);
            this.BtnIngresar.TabIndex = 15;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click_1);
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TxtContrasenia.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.TxtContrasenia.Location = new System.Drawing.Point(149, 210);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(455, 31);
            this.TxtContrasenia.TabIndex = 8;
            this.TxtContrasenia.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.TxtUsuario.Location = new System.Drawing.Point(149, 139);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(455, 31);
            this.TxtUsuario.TabIndex = 7;
            this.TxtUsuario.Text = "Usuario";
            // 
            // LblLogin
            // 
            this.LblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Haettenschweiler", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.LblLogin.Location = new System.Drawing.Point(335, 60);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(64, 32);
            this.LblLogin.TabIndex = 6;
            this.LblLogin.Text = "LOGIN";
            // 
            // Form4login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(888, 531);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(902, 488);
            this.Name = "Form4login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form4login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.LinkLabel llblAdmin;
        private System.Windows.Forms.LinkLabel llblCuenta;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblLogin;
    }
}