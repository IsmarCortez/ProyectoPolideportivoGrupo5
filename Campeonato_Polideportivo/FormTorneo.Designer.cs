﻿
namespace Campeonato_Polideportivo
{
    partial class FormTorneo
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
            this.TxtTemporada = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblDeporte = new System.Windows.Forms.Label();
            this.LblFinal = new System.Windows.Forms.Label();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.LblTemporada = new System.Windows.Forms.Label();
            this.LblIDTorneo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblTorneo = new System.Windows.Forms.Label();
            this.DgvTorneo = new System.Windows.Forms.DataGridView();
            this.pkidtorneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkiddeporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFechafin = new System.Windows.Forms.DateTimePicker();
            this.CmbDeporte = new System.Windows.Forms.ComboBox();
            this.BtnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTorneo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTemporada
            // 
            this.TxtTemporada.Location = new System.Drawing.Point(166, 188);
            this.TxtTemporada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTemporada.Name = "TxtTemporada";
            this.TxtTemporada.Size = new System.Drawing.Size(76, 20);
            this.TxtTemporada.TabIndex = 220;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(166, 132);
            this.TxtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(76, 20);
            this.TxtId.TabIndex = 219;
            this.TxtId.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(166, 160);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(76, 20);
            this.TxtNombre.TabIndex = 218;
            // 
            // LblDeporte
            // 
            this.LblDeporte.AutoSize = true;
            this.LblDeporte.Location = new System.Drawing.Point(56, 275);
            this.LblDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDeporte.Name = "LblDeporte";
            this.LblDeporte.Size = new System.Drawing.Size(45, 13);
            this.LblDeporte.TabIndex = 214;
            this.LblDeporte.Text = "Deporte";
            // 
            // LblFinal
            // 
            this.LblFinal.AutoSize = true;
            this.LblFinal.Location = new System.Drawing.Point(56, 242);
            this.LblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFinal.Name = "LblFinal";
            this.LblFinal.Size = new System.Drawing.Size(62, 13);
            this.LblFinal.TabIndex = 212;
            this.LblFinal.Text = "Fecha Final";
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Location = new System.Drawing.Point(56, 219);
            this.LblFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.LblFechaInicio.TabIndex = 211;
            this.LblFechaInicio.Text = "Fecha Inicio";
            // 
            // LblTemporada
            // 
            this.LblTemporada.AutoSize = true;
            this.LblTemporada.Location = new System.Drawing.Point(56, 188);
            this.LblTemporada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTemporada.Name = "LblTemporada";
            this.LblTemporada.Size = new System.Drawing.Size(61, 13);
            this.LblTemporada.TabIndex = 210;
            this.LblTemporada.Text = "Temporada";
            // 
            // LblIDTorneo
            // 
            this.LblIDTorneo.AutoSize = true;
            this.LblIDTorneo.Location = new System.Drawing.Point(56, 135);
            this.LblIDTorneo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIDTorneo.Name = "LblIDTorneo";
            this.LblIDTorneo.Size = new System.Drawing.Size(58, 13);
            this.LblIDTorneo.TabIndex = 209;
            this.LblIDTorneo.Text = "ID_Torneo";
            this.LblIDTorneo.Visible = false;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(56, 162);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(81, 13);
            this.LblNombre.TabIndex = 208;
            this.LblNombre.Text = "Nombre Torneo";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEliminar.Location = new System.Drawing.Point(664, 409);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 33);
            this.BtnEliminar.TabIndex = 207;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnModificar.Location = new System.Drawing.Point(482, 409);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 33);
            this.BtnModificar.TabIndex = 206;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnVer.Location = new System.Drawing.Point(308, 409);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(130, 33);
            this.BtnVer.TabIndex = 205;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnIngresar.Location = new System.Drawing.Point(123, 409);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(130, 33);
            this.BtnIngresar.TabIndex = 204;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblTorneo
            // 
            this.LblTorneo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTorneo.AutoSize = true;
            this.LblTorneo.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTorneo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblTorneo.Location = new System.Drawing.Point(355, 28);
            this.LblTorneo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTorneo.Name = "LblTorneo";
            this.LblTorneo.Size = new System.Drawing.Size(109, 40);
            this.LblTorneo.TabIndex = 202;
            this.LblTorneo.Text = "TORNEO";
            // 
            // DgvTorneo
            // 
            this.DgvTorneo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTorneo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTorneo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidtorneo,
            this.nombre,
            this.temporada,
            this.fechainicio,
            this.fechafin,
            this.fkiddeporte});
            this.DgvTorneo.Location = new System.Drawing.Point(308, 122);
            this.DgvTorneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvTorneo.Name = "DgvTorneo";
            this.DgvTorneo.ReadOnly = true;
            this.DgvTorneo.RowHeadersWidth = 51;
            this.DgvTorneo.RowTemplate.Height = 24;
            this.DgvTorneo.Size = new System.Drawing.Size(502, 273);
            this.DgvTorneo.TabIndex = 201;
            this.DgvTorneo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVer_CellContentClick);
            // 
            // pkidtorneo
            // 
            this.pkidtorneo.DataPropertyName = "pkidtorneo";
            this.pkidtorneo.HeaderText = "ID_torneo";
            this.pkidtorneo.MinimumWidth = 6;
            this.pkidtorneo.Name = "pkidtorneo";
            this.pkidtorneo.ReadOnly = true;
            this.pkidtorneo.Width = 79;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre Torneo";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 97;
            // 
            // temporada
            // 
            this.temporada.DataPropertyName = "temporada";
            this.temporada.HeaderText = "Temporada";
            this.temporada.MinimumWidth = 6;
            this.temporada.Name = "temporada";
            this.temporada.ReadOnly = true;
            this.temporada.Width = 86;
            // 
            // fechainicio
            // 
            this.fechainicio.DataPropertyName = "fechainicio";
            this.fechainicio.HeaderText = "Fecha Inicio";
            this.fechainicio.MinimumWidth = 6;
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.ReadOnly = true;
            this.fechainicio.Width = 83;
            // 
            // fechafin
            // 
            this.fechafin.DataPropertyName = "fechafin";
            this.fechafin.HeaderText = "Fecha Fin";
            this.fechafin.MinimumWidth = 6;
            this.fechafin.Name = "fechafin";
            this.fechafin.ReadOnly = true;
            this.fechafin.Width = 73;
            // 
            // fkiddeporte
            // 
            this.fkiddeporte.DataPropertyName = "fkiddeporte";
            this.fkiddeporte.HeaderText = "Deporte";
            this.fkiddeporte.MinimumWidth = 6;
            this.fkiddeporte.Name = "fkiddeporte";
            this.fkiddeporte.ReadOnly = true;
            this.fkiddeporte.Width = 70;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(166, 214);
            this.DtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(120, 20);
            this.DtpFechaInicio.TabIndex = 228;
            this.DtpFechaInicio.ValueChanged += new System.EventHandler(this.DtpFechaInicio_ValueChanged);
            // 
            // DtpFechafin
            // 
            this.DtpFechafin.Location = new System.Drawing.Point(166, 241);
            this.DtpFechafin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpFechafin.Name = "DtpFechafin";
            this.DtpFechafin.Size = new System.Drawing.Size(120, 20);
            this.DtpFechafin.TabIndex = 229;
            this.DtpFechafin.ValueChanged += new System.EventHandler(this.DtpFechafin_ValueChanged);
            // 
            // CmbDeporte
            // 
            this.CmbDeporte.FormattingEnabled = true;
            this.CmbDeporte.Location = new System.Drawing.Point(166, 275);
            this.CmbDeporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbDeporte.Name = "CmbDeporte";
            this.CmbDeporte.Size = new System.Drawing.Size(92, 21);
            this.CmbDeporte.TabIndex = 230;
            this.CmbDeporte.SelectedIndexChanged += new System.EventHandler(this.CmbDeporte_SelectedIndexChanged);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Haettenschweiler", 16.2F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnAyuda.Location = new System.Drawing.Point(776, 28);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(34, 27);
            this.BtnAyuda.TabIndex = 331;
            this.BtnAyuda.Text = "?";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FormTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(826, 531);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.CmbDeporte);
            this.Controls.Add(this.DtpFechafin);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.TxtTemporada);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblDeporte);
            this.Controls.Add(this.LblFinal);
            this.Controls.Add(this.LblFechaInicio);
            this.Controls.Add(this.LblTemporada);
            this.Controls.Add(this.LblIDTorneo);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblTorneo);
            this.Controls.Add(this.DgvTorneo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTorneo";
            this.Text = "FormTorneo";
            this.Load += new System.EventHandler(this.FormTorneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTorneo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTemporada;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblDeporte;
        private System.Windows.Forms.Label LblFinal;
        private System.Windows.Forms.Label LblFechaInicio;
        private System.Windows.Forms.Label LblTemporada;
        private System.Windows.Forms.Label LblIDTorneo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblTorneo;
        private System.Windows.Forms.DataGridView DgvTorneo;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechafin;
        private System.Windows.Forms.ComboBox CmbDeporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidtorneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkiddeporte;
        private System.Windows.Forms.Button BtnAyuda;
    }
}