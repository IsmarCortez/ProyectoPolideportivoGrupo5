﻿
namespace Campeonato_Polideportivo
{
    partial class FormFutbol
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
            this.TxtGoles = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblIdPartido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblFutbol = new System.Windows.Forms.Label();
            this.DgvFutbol = new System.Windows.Forms.DataGridView();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CmbEstadoPartido = new System.Windows.Forms.ComboBox();
            this.CmbGanadorEmpate = new System.Windows.Forms.ComboBox();
            this.CmbCampeonato = new System.Windows.Forms.ComboBox();
            this.CmbFase = new System.Windows.Forms.ComboBox();
            this.CmbArbitro = new System.Windows.Forms.ComboBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.CmbEquipoLocal = new System.Windows.Forms.ComboBox();
            this.CmbEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NudGolesLocal = new System.Windows.Forms.NumericUpDown();
            this.NudTirosLocal = new System.Windows.Forms.NumericUpDown();
            this.NudPosesionLocal = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NudPosesionVisitante = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.NudTirosVisitante = new System.Windows.Forms.NumericUpDown();
            this.NudGolesVisitante = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtIdFutbol = new System.Windows.Forms.TextBox();
            this.LblIdFutbol = new System.Windows.Forms.Label();
            this.BtnClasificacion = new System.Windows.Forms.Button();
            this.DgvClasificacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFutbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGolesLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTirosLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPosesionLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPosesionVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTirosVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGolesVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtGoles
            // 
            this.TxtGoles.AutoSize = true;
            this.TxtGoles.Location = new System.Drawing.Point(409, 144);
            this.TxtGoles.Name = "TxtGoles";
            this.TxtGoles.Size = new System.Drawing.Size(83, 17);
            this.TxtGoles.TabIndex = 54;
            this.TxtGoles.Text = "Goles Local";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ganador o empate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Arbitro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Fase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Campeonato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Estado Partido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Equipo Visitante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Equipo Local";
            // 
            // LblIdPartido
            // 
            this.LblIdPartido.AutoSize = true;
            this.LblIdPartido.Location = new System.Drawing.Point(35, 12);
            this.LblIdPartido.Name = "LblIdPartido";
            this.LblIdPartido.Size = new System.Drawing.Size(70, 17);
            this.LblIdPartido.TabIndex = 47;
            this.LblIdPartido.Text = "ID Partido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fecha";
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
            this.BtnEliminar.Location = new System.Drawing.Point(771, 556);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(173, 41);
            this.BtnEliminar.TabIndex = 45;
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
            this.BtnModificar.Location = new System.Drawing.Point(529, 556);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(173, 41);
            this.BtnModificar.TabIndex = 44;
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
            this.BtnVer.Location = new System.Drawing.Point(297, 556);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(173, 41);
            this.BtnVer.TabIndex = 43;
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
            this.BtnIngresar.Location = new System.Drawing.Point(51, 556);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(173, 41);
            this.BtnIngresar.TabIndex = 42;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblFutbol
            // 
            this.LblFutbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblFutbol.AutoSize = true;
            this.LblFutbol.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFutbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblFutbol.Location = new System.Drawing.Point(403, 26);
            this.LblFutbol.Name = "LblFutbol";
            this.LblFutbol.Size = new System.Drawing.Size(130, 50);
            this.LblFutbol.TabIndex = 40;
            this.LblFutbol.Text = "FÚTBOL";
            // 
            // DgvFutbol
            // 
            this.DgvFutbol.AllowUserToAddRows = false;
            this.DgvFutbol.AllowUserToDeleteRows = false;
            this.DgvFutbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFutbol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFutbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFutbol.Location = new System.Drawing.Point(51, 235);
            this.DgvFutbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvFutbol.Name = "DgvFutbol";
            this.DgvFutbol.RowHeadersWidth = 51;
            this.DgvFutbol.RowTemplate.Height = 24;
            this.DgvFutbol.Size = new System.Drawing.Size(895, 316);
            this.DgvFutbol.TabIndex = 39;
            this.DgvFutbol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFutbol_CellContentClick);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(168, 43);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(164, 22);
            this.DtpFecha.TabIndex = 65;
            // 
            // CmbEstadoPartido
            // 
            this.CmbEstadoPartido.FormattingEnabled = true;
            this.CmbEstadoPartido.Location = new System.Drawing.Point(168, 75);
            this.CmbEstadoPartido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEstadoPartido.Name = "CmbEstadoPartido";
            this.CmbEstadoPartido.Size = new System.Drawing.Size(164, 24);
            this.CmbEstadoPartido.TabIndex = 66;
            this.CmbEstadoPartido.SelectedIndexChanged += new System.EventHandler(this.CmbEstadoPartido_SelectedIndexChanged);
            // 
            // CmbGanadorEmpate
            // 
            this.CmbGanadorEmpate.FormattingEnabled = true;
            this.CmbGanadorEmpate.Location = new System.Drawing.Point(168, 108);
            this.CmbGanadorEmpate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbGanadorEmpate.Name = "CmbGanadorEmpate";
            this.CmbGanadorEmpate.Size = new System.Drawing.Size(164, 24);
            this.CmbGanadorEmpate.TabIndex = 67;
            this.CmbGanadorEmpate.SelectedIndexChanged += new System.EventHandler(this.CmbGanadorEmpate_SelectedIndexChanged);
            // 
            // CmbCampeonato
            // 
            this.CmbCampeonato.FormattingEnabled = true;
            this.CmbCampeonato.Location = new System.Drawing.Point(168, 142);
            this.CmbCampeonato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCampeonato.Name = "CmbCampeonato";
            this.CmbCampeonato.Size = new System.Drawing.Size(164, 24);
            this.CmbCampeonato.TabIndex = 68;
            this.CmbCampeonato.SelectedIndexChanged += new System.EventHandler(this.CmbCampeonato_SelectedIndexChanged);
            // 
            // CmbFase
            // 
            this.CmbFase.FormattingEnabled = true;
            this.CmbFase.Location = new System.Drawing.Point(168, 171);
            this.CmbFase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbFase.Name = "CmbFase";
            this.CmbFase.Size = new System.Drawing.Size(164, 24);
            this.CmbFase.TabIndex = 69;
            this.CmbFase.SelectedIndexChanged += new System.EventHandler(this.CmbFase_SelectedIndexChanged);
            // 
            // CmbArbitro
            // 
            this.CmbArbitro.FormattingEnabled = true;
            this.CmbArbitro.Location = new System.Drawing.Point(168, 203);
            this.CmbArbitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbArbitro.Name = "CmbArbitro";
            this.CmbArbitro.Size = new System.Drawing.Size(164, 24);
            this.CmbArbitro.TabIndex = 70;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(168, 12);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(164, 22);
            this.TxtId.TabIndex = 57;
            // 
            // CmbEquipoLocal
            // 
            this.CmbEquipoLocal.FormattingEnabled = true;
            this.CmbEquipoLocal.Location = new System.Drawing.Point(541, 108);
            this.CmbEquipoLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEquipoLocal.Name = "CmbEquipoLocal";
            this.CmbEquipoLocal.Size = new System.Drawing.Size(131, 24);
            this.CmbEquipoLocal.TabIndex = 71;
            this.CmbEquipoLocal.SelectedIndexChanged += new System.EventHandler(this.CmbEquipoLocal_SelectedIndexChanged);
            // 
            // CmbEquipoVisitante
            // 
            this.CmbEquipoVisitante.FormattingEnabled = true;
            this.CmbEquipoVisitante.Location = new System.Drawing.Point(821, 108);
            this.CmbEquipoVisitante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEquipoVisitante.Name = "CmbEquipoVisitante";
            this.CmbEquipoVisitante.Size = new System.Drawing.Size(129, 24);
            this.CmbEquipoVisitante.TabIndex = 72;
            this.CmbEquipoVisitante.SelectedIndexChanged += new System.EventHandler(this.CmbEquipoVisitante_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Tiros Local";
            // 
            // NudGolesLocal
            // 
            this.NudGolesLocal.Location = new System.Drawing.Point(541, 142);
            this.NudGolesLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NudGolesLocal.Name = "NudGolesLocal";
            this.NudGolesLocal.Size = new System.Drawing.Size(131, 22);
            this.NudGolesLocal.TabIndex = 76;
            this.NudGolesLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudTirosLocal
            // 
            this.NudTirosLocal.Location = new System.Drawing.Point(541, 172);
            this.NudTirosLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NudTirosLocal.Name = "NudTirosLocal";
            this.NudTirosLocal.Size = new System.Drawing.Size(131, 22);
            this.NudTirosLocal.TabIndex = 77;
            this.NudTirosLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudPosesionLocal
            // 
            this.NudPosesionLocal.Location = new System.Drawing.Point(541, 204);
            this.NudPosesionLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NudPosesionLocal.Name = "NudPosesionLocal";
            this.NudPosesionLocal.Size = new System.Drawing.Size(131, 22);
            this.NudPosesionLocal.TabIndex = 80;
            this.NudPosesionLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(409, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = "Posesion Local";
            // 
            // NudPosesionVisitante
            // 
            this.NudPosesionVisitante.Location = new System.Drawing.Point(821, 203);
            this.NudPosesionVisitante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NudPosesionVisitante.Name = "NudPosesionVisitante";
            this.NudPosesionVisitante.Size = new System.Drawing.Size(129, 22);
            this.NudPosesionVisitante.TabIndex = 88;
            this.NudPosesionVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(687, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 17);
            this.label13.TabIndex = 86;
            this.label13.Text = "Posesion Visitante";
            // 
            // NudTirosVisitante
            // 
            this.NudTirosVisitante.Location = new System.Drawing.Point(821, 171);
            this.NudTirosVisitante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NudTirosVisitante.Name = "NudTirosVisitante";
            this.NudTirosVisitante.Size = new System.Drawing.Size(129, 22);
            this.NudTirosVisitante.TabIndex = 85;
            this.NudTirosVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudGolesVisitante
            // 
            this.NudGolesVisitante.Location = new System.Drawing.Point(821, 142);
            this.NudGolesVisitante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NudGolesVisitante.Name = "NudGolesVisitante";
            this.NudGolesVisitante.Size = new System.Drawing.Size(129, 22);
            this.NudGolesVisitante.TabIndex = 84;
            this.NudGolesVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(687, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 83;
            this.label14.Text = "Tiros Visitante";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(687, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 82;
            this.label15.Text = "Goles Visitante";
            // 
            // TxtIdFutbol
            // 
            this.TxtIdFutbol.Enabled = false;
            this.TxtIdFutbol.Location = new System.Drawing.Point(821, 71);
            this.TxtIdFutbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIdFutbol.Name = "TxtIdFutbol";
            this.TxtIdFutbol.Size = new System.Drawing.Size(129, 22);
            this.TxtIdFutbol.TabIndex = 90;
            // 
            // LblIdFutbol
            // 
            this.LblIdFutbol.AutoSize = true;
            this.LblIdFutbol.Location = new System.Drawing.Point(689, 71);
            this.LblIdFutbol.Name = "LblIdFutbol";
            this.LblIdFutbol.Size = new System.Drawing.Size(64, 17);
            this.LblIdFutbol.TabIndex = 89;
            this.LblIdFutbol.Text = "ID Futbol";
            // 
            // BtnClasificacion
            // 
            this.BtnClasificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClasificacion.Font = new System.Drawing.Font("Haettenschweiler", 16.2F);
            this.BtnClasificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnClasificacion.Location = new System.Drawing.Point(794, 12);
            this.BtnClasificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClasificacion.Name = "BtnClasificacion";
            this.BtnClasificacion.Size = new System.Drawing.Size(156, 44);
            this.BtnClasificacion.TabIndex = 91;
            this.BtnClasificacion.Text = "CLASIFICACION";
            this.BtnClasificacion.UseVisualStyleBackColor = false;
            this.BtnClasificacion.Click += new System.EventHandler(this.BtnClasificacion_Click);
            // 
            // DgvClasificacion
            // 
            this.DgvClasificacion.AllowUserToAddRows = false;
            this.DgvClasificacion.AllowUserToDeleteRows = false;
            this.DgvClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClasificacion.Location = new System.Drawing.Point(88, 235);
            this.DgvClasificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvClasificacion.Name = "DgvClasificacion";
            this.DgvClasificacion.RowHeadersWidth = 51;
            this.DgvClasificacion.RowTemplate.Height = 24;
            this.DgvClasificacion.Size = new System.Drawing.Size(821, 316);
            this.DgvClasificacion.TabIndex = 92;
            // 
            // FormFutbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 654);
            this.Controls.Add(this.DgvClasificacion);
            this.Controls.Add(this.BtnClasificacion);
            this.Controls.Add(this.TxtIdFutbol);
            this.Controls.Add(this.LblIdFutbol);
            this.Controls.Add(this.NudPosesionVisitante);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NudTirosVisitante);
            this.Controls.Add(this.NudGolesVisitante);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.NudPosesionLocal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NudTirosLocal);
            this.Controls.Add(this.NudGolesLocal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbEquipoVisitante);
            this.Controls.Add(this.CmbEquipoLocal);
            this.Controls.Add(this.CmbArbitro);
            this.Controls.Add(this.CmbFase);
            this.Controls.Add(this.CmbCampeonato);
            this.Controls.Add(this.CmbGanadorEmpate);
            this.Controls.Add(this.CmbEstadoPartido);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtGoles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblIdPartido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblFutbol);
            this.Controls.Add(this.DgvFutbol);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFutbol";
            this.Text = "FormFutbol";
            this.Load += new System.EventHandler(this.FormFutbol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFutbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGolesLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTirosLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPosesionLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPosesionVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTirosVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGolesVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClasificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TxtGoles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblIdPartido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblFutbol;
        private System.Windows.Forms.DataGridView DgvFutbol;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.ComboBox CmbEstadoPartido;
        private System.Windows.Forms.ComboBox CmbGanadorEmpate;
        private System.Windows.Forms.ComboBox CmbCampeonato;
        private System.Windows.Forms.ComboBox CmbFase;
        private System.Windows.Forms.ComboBox CmbArbitro;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.ComboBox CmbEquipoLocal;
        private System.Windows.Forms.ComboBox CmbEquipoVisitante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NudGolesLocal;
        private System.Windows.Forms.NumericUpDown NudTirosLocal;
        private System.Windows.Forms.NumericUpDown NudPosesionLocal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NudPosesionVisitante;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NudTirosVisitante;
        private System.Windows.Forms.NumericUpDown NudGolesVisitante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtIdFutbol;
        private System.Windows.Forms.Label LblIdFutbol;
        private System.Windows.Forms.Button BtnClasificacion;
        private System.Windows.Forms.DataGridView DgvClasificacion;
    }
}