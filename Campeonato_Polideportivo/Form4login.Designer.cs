﻿
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
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LLblPassword = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.PanelIzquierdo.Controls.Add(this.pictureBox1);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanelIzquierdo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(440, 981);
            this.PanelIzquierdo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Campeonato_Polideportivo.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 249);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.TxtUsuario.Location = new System.Drawing.Point(612, 290);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(830, 48);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Text = "Usuario";
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TxtPassword.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.TxtPassword.Location = new System.Drawing.Point(612, 528);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(830, 48);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "Contraseña";
            // 
            // LblLogin
            // 
            this.LblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Haettenschweiler", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.LblLogin.Location = new System.Drawing.Point(975, 112);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(110, 54);
            this.LblLogin.TabIndex = 3;
            this.LblLogin.Text = "LOGIN";
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
            this.BtnIngresar.Location = new System.Drawing.Point(612, 738);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(832, 62);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LLblPassword
            // 
            this.LLblPassword.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.LLblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LLblPassword.AutoSize = true;
            this.LLblPassword.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLblPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.LLblPassword.Location = new System.Drawing.Point(898, 861);
            this.LLblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLblPassword.Name = "LLblPassword";
            this.LLblPassword.Size = new System.Drawing.Size(266, 29);
            this.LLblPassword.TabIndex = 5;
            this.LLblPassword.TabStop = true;
            this.LLblPassword.Text = "¿Has olvidado tu contraseña?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(958, 662);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chubasco";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alejandro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 621);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ismar Cortez jeje";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fernando";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kateryn";
            // 
            // Form4login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1628, 981);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LLblPassword);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.PanelIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1640, 865);
            this.Name = "Form4login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PanelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.LinkLabel LLblPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}