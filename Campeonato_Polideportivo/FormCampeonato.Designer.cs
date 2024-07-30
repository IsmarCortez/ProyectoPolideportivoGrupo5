﻿
namespace Campeonato_Polideportivo
{
    partial class FormCampeonato
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
            this.CmbDeporte = new System.Windows.Forms.ComboBox();
            this.LblCampeonato = new System.Windows.Forms.Label();
            this.DgwCampeonato = new System.Windows.Forms.DataGridView();
            this.LblIdCampeonato = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblTemporada = new System.Windows.Forms.Label();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.LblFechaFin = new System.Windows.Forms.Label();
            this.LblDeporte = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TxtIdCampeonato = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTemporada = new System.Windows.Forms.TextBox();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgwCampeonato)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbDeporte
            // 
            this.CmbDeporte.FormattingEnabled = true;
            this.CmbDeporte.Location = new System.Drawing.Point(146, 376);
            this.CmbDeporte.Name = "CmbDeporte";
            this.CmbDeporte.Size = new System.Drawing.Size(250, 24);
            this.CmbDeporte.TabIndex = 51;
            this.CmbDeporte.Text = "Selecciona un deporte...";
            // 
            // LblCampeonato
            // 
            this.LblCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCampeonato.AutoSize = true;
            this.LblCampeonato.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampeonato.Location = new System.Drawing.Point(358, 22);
            this.LblCampeonato.Name = "LblCampeonato";
            this.LblCampeonato.Size = new System.Drawing.Size(226, 50);
            this.LblCampeonato.TabIndex = 50;
            this.LblCampeonato.Text = "CAMPEONATO";
            // 
            // DgwCampeonato
            // 
            this.DgwCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgwCampeonato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwCampeonato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwCampeonato.Location = new System.Drawing.Point(427, 99);
            this.DgwCampeonato.Name = "DgwCampeonato";
            this.DgwCampeonato.RowHeadersWidth = 51;
            this.DgwCampeonato.RowTemplate.Height = 24;
            this.DgwCampeonato.Size = new System.Drawing.Size(521, 369);
            this.DgwCampeonato.TabIndex = 49;
            this.DgwCampeonato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwCampeonato_CellContentClick);
            // 
            // LblIdCampeonato
            // 
            this.LblIdCampeonato.AutoSize = true;
            this.LblIdCampeonato.Location = new System.Drawing.Point(51, 129);
            this.LblIdCampeonato.Name = "LblIdCampeonato";
            this.LblIdCampeonato.Size = new System.Drawing.Size(21, 17);
            this.LblIdCampeonato.TabIndex = 56;
            this.LblIdCampeonato.Text = "ID";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(51, 175);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 57;
            this.LblNombre.Text = "Nombre";
            // 
            // LblTemporada
            // 
            this.LblTemporada.AutoSize = true;
            this.LblTemporada.Location = new System.Drawing.Point(51, 222);
            this.LblTemporada.Name = "LblTemporada";
            this.LblTemporada.Size = new System.Drawing.Size(81, 17);
            this.LblTemporada.TabIndex = 58;
            this.LblTemporada.Text = "Temporada";
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Location = new System.Drawing.Point(51, 269);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(83, 17);
            this.LblFechaInicio.TabIndex = 59;
            this.LblFechaInicio.Text = "Fecha Inicio";
            // 
            // LblFechaFin
            // 
            this.LblFechaFin.AutoSize = true;
            this.LblFechaFin.Location = new System.Drawing.Point(51, 324);
            this.LblFechaFin.Name = "LblFechaFin";
            this.LblFechaFin.Size = new System.Drawing.Size(70, 17);
            this.LblFechaFin.TabIndex = 60;
            this.LblFechaFin.Text = "Fecha Fin";
            // 
            // LblDeporte
            // 
            this.LblDeporte.AutoSize = true;
            this.LblDeporte.Location = new System.Drawing.Point(50, 383);
            this.LblDeporte.Name = "LblDeporte";
            this.LblDeporte.Size = new System.Drawing.Size(59, 17);
            this.LblDeporte.TabIndex = 61;
            this.LblDeporte.Text = "Deporte";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(146, 269);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(250, 22);
            this.DtpFechaInicio.TabIndex = 62;
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Location = new System.Drawing.Point(146, 324);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(250, 22);
            this.DtpFechaFin.TabIndex = 63;
            // 
            // TxtIdCampeonato
            // 
            this.TxtIdCampeonato.Enabled = false;
            this.TxtIdCampeonato.Location = new System.Drawing.Point(146, 126);
            this.TxtIdCampeonato.Name = "TxtIdCampeonato";
            this.TxtIdCampeonato.Size = new System.Drawing.Size(100, 22);
            this.TxtIdCampeonato.TabIndex = 64;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(146, 175);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(250, 22);
            this.TxtNombre.TabIndex = 65;
            // 
            // TxtTemporada
            // 
            this.TxtTemporada.Location = new System.Drawing.Point(146, 222);
            this.TxtTemporada.Name = "TxtTemporada";
            this.TxtTemporada.Size = new System.Drawing.Size(250, 22);
            this.TxtTemporada.TabIndex = 66;
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnVer.Location = new System.Drawing.Point(306, 526);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(174, 41);
            this.BtnVer.TabIndex = 70;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEliminar.Location = new System.Drawing.Point(729, 526);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(174, 41);
            this.BtnEliminar.TabIndex = 69;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnModificar.Location = new System.Drawing.Point(516, 526);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(174, 41);
            this.BtnModificar.TabIndex = 68;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnIngresar.Location = new System.Drawing.Point(97, 526);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(174, 41);
            this.BtnIngresar.TabIndex = 67;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // FormCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 653);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtTemporada);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdCampeonato);
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.LblDeporte);
            this.Controls.Add(this.LblFechaFin);
            this.Controls.Add(this.LblFechaInicio);
            this.Controls.Add(this.LblTemporada);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblIdCampeonato);
            this.Controls.Add(this.CmbDeporte);
            this.Controls.Add(this.LblCampeonato);
            this.Controls.Add(this.DgwCampeonato);
            this.Name = "FormCampeonato";
            this.Text = "FormCampeonato";
            ((System.ComponentModel.ISupportInitialize)(this.DgwCampeonato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbDeporte;
        private System.Windows.Forms.Label LblCampeonato;
        private System.Windows.Forms.DataGridView DgwCampeonato;
        private System.Windows.Forms.Label LblIdCampeonato;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTemporada;
        private System.Windows.Forms.Label LblFechaInicio;
        private System.Windows.Forms.Label LblFechaFin;
        private System.Windows.Forms.Label LblDeporte;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.TextBox TxtIdCampeonato;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTemporada;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnIngresar;
    }
}