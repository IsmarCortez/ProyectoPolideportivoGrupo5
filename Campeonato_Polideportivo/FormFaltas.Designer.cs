
namespace Campeonato_Polideportivo
{
    partial class FormFaltas
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
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtMinuto = new System.Windows.Forms.TextBox();
            this.TxtIdFaltas = new System.Windows.Forms.TextBox();
            this.LblTipoFalta = new System.Windows.Forms.Label();
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.LblMinuto = new System.Windows.Forms.Label();
            this.LblIdCampeonato = new System.Windows.Forms.Label();
            this.CmbFalta = new System.Windows.Forms.ComboBox();
            this.LblFaltas = new System.Windows.Forms.Label();
            this.DgvFaltas = new System.Windows.Forms.DataGridView();
            this.CmbTarjeta = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblIdPartido = new System.Windows.Forms.Label();
            this.LblIdJugador = new System.Windows.Forms.Label();
            this.LblEquipo = new System.Windows.Forms.Label();
            this.CmbPartido = new System.Windows.Forms.ComboBox();
            this.CmbEquipo = new System.Windows.Forms.ComboBox();
            this.CmbJugador = new System.Windows.Forms.ComboBox();
            this.CmbArbitro = new System.Windows.Forms.ComboBox();
            this.LblArbitro = new System.Windows.Forms.Label();
            this.CmbCampeonato = new System.Windows.Forms.ComboBox();
            this.LblCampeonato = new System.Windows.Forms.Label();
            this.BtnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFaltas)).BeginInit();
            this.SuspendLayout();
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
            this.BtnVer.Location = new System.Drawing.Point(233, 449);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(130, 33);
            this.BtnVer.TabIndex = 88;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
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
            this.BtnEliminar.Location = new System.Drawing.Point(550, 449);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 33);
            this.BtnEliminar.TabIndex = 87;
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
            this.BtnModificar.Location = new System.Drawing.Point(391, 449);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 33);
            this.BtnModificar.TabIndex = 86;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.BtnIngresar.Location = new System.Drawing.Point(76, 449);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(130, 33);
            this.BtnIngresar.TabIndex = 85;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtMinuto
            // 
            this.TxtMinuto.Location = new System.Drawing.Point(115, 98);
            this.TxtMinuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMinuto.Name = "TxtMinuto";
            this.TxtMinuto.Size = new System.Drawing.Size(188, 20);
            this.TxtMinuto.TabIndex = 83;
            // 
            // TxtIdFaltas
            // 
            this.TxtIdFaltas.Enabled = false;
            this.TxtIdFaltas.Location = new System.Drawing.Point(115, 67);
            this.TxtIdFaltas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtIdFaltas.Name = "TxtIdFaltas";
            this.TxtIdFaltas.Size = new System.Drawing.Size(76, 20);
            this.TxtIdFaltas.TabIndex = 82;
            this.TxtIdFaltas.Visible = false;
            // 
            // LblTipoFalta
            // 
            this.LblTipoFalta.AutoSize = true;
            this.LblTipoFalta.Location = new System.Drawing.Point(43, 162);
            this.LblTipoFalta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTipoFalta.Name = "LblTipoFalta";
            this.LblTipoFalta.Size = new System.Drawing.Size(69, 13);
            this.LblTipoFalta.TabIndex = 77;
            this.LblTipoFalta.Text = "Tipo de Falta";
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.Location = new System.Drawing.Point(44, 132);
            this.LblTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(40, 13);
            this.LblTarjeta.TabIndex = 76;
            this.LblTarjeta.Text = "Tarjeta";
            // 
            // LblMinuto
            // 
            this.LblMinuto.AutoSize = true;
            this.LblMinuto.Location = new System.Drawing.Point(44, 98);
            this.LblMinuto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMinuto.Name = "LblMinuto";
            this.LblMinuto.Size = new System.Drawing.Size(39, 13);
            this.LblMinuto.TabIndex = 75;
            this.LblMinuto.Text = "Minuto";
            // 
            // LblIdCampeonato
            // 
            this.LblIdCampeonato.AutoSize = true;
            this.LblIdCampeonato.Location = new System.Drawing.Point(44, 69);
            this.LblIdCampeonato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIdCampeonato.Name = "LblIdCampeonato";
            this.LblIdCampeonato.Size = new System.Drawing.Size(18, 13);
            this.LblIdCampeonato.TabIndex = 74;
            this.LblIdCampeonato.Text = "ID";
            this.LblIdCampeonato.Visible = false;
            // 
            // CmbFalta
            // 
            this.CmbFalta.FormattingEnabled = true;
            this.CmbFalta.Location = new System.Drawing.Point(115, 162);
            this.CmbFalta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbFalta.Name = "CmbFalta";
            this.CmbFalta.Size = new System.Drawing.Size(188, 21);
            this.CmbFalta.TabIndex = 73;
            this.CmbFalta.Text = "Selecciona un tipo de falta...";
            // 
            // LblFaltas
            // 
            this.LblFaltas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblFaltas.AutoSize = true;
            this.LblFaltas.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFaltas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblFaltas.Location = new System.Drawing.Point(316, 16);
            this.LblFaltas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFaltas.Name = "LblFaltas";
            this.LblFaltas.Size = new System.Drawing.Size(109, 40);
            this.LblFaltas.TabIndex = 72;
            this.LblFaltas.Text = "FALTAS";
            // 
            // DgvFaltas
            // 
            this.DgvFaltas.AllowUserToAddRows = false;
            this.DgvFaltas.AllowUserToDeleteRows = false;
            this.DgvFaltas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFaltas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFaltas.Location = new System.Drawing.Point(323, 80);
            this.DgvFaltas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvFaltas.Name = "DgvFaltas";
            this.DgvFaltas.ReadOnly = true;
            this.DgvFaltas.RowHeadersWidth = 51;
            this.DgvFaltas.RowTemplate.Height = 24;
            this.DgvFaltas.Size = new System.Drawing.Size(391, 334);
            this.DgvFaltas.TabIndex = 71;
            this.DgvFaltas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFaltas_CellContentClick);
            // 
            // CmbTarjeta
            // 
            this.CmbTarjeta.FormattingEnabled = true;
            this.CmbTarjeta.Location = new System.Drawing.Point(115, 130);
            this.CmbTarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbTarjeta.Name = "CmbTarjeta";
            this.CmbTarjeta.Size = new System.Drawing.Size(188, 21);
            this.CmbTarjeta.TabIndex = 89;
            this.CmbTarjeta.Text = "Selecciona una tarjeta...";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(115, 195);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.TxtDescripcion.TabIndex = 91;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(44, 195);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 90;
            this.LblDescripcion.Text = "Descripción";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(115, 228);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(188, 20);
            this.DtpFecha.TabIndex = 93;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(44, 228);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 92;
            this.LblFecha.Text = "Fecha";
            // 
            // LblIdPartido
            // 
            this.LblIdPartido.AutoSize = true;
            this.LblIdPartido.Location = new System.Drawing.Point(44, 294);
            this.LblIdPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIdPartido.Name = "LblIdPartido";
            this.LblIdPartido.Size = new System.Drawing.Size(40, 13);
            this.LblIdPartido.TabIndex = 94;
            this.LblIdPartido.Text = "Partido";
            // 
            // LblIdJugador
            // 
            this.LblIdJugador.AutoSize = true;
            this.LblIdJugador.Location = new System.Drawing.Point(38, 362);
            this.LblIdJugador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIdJugador.Name = "LblIdJugador";
            this.LblIdJugador.Size = new System.Drawing.Size(45, 13);
            this.LblIdJugador.TabIndex = 96;
            this.LblIdJugador.Text = "Jugador";
            // 
            // LblEquipo
            // 
            this.LblEquipo.AutoSize = true;
            this.LblEquipo.Location = new System.Drawing.Point(43, 327);
            this.LblEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEquipo.Name = "LblEquipo";
            this.LblEquipo.Size = new System.Drawing.Size(40, 13);
            this.LblEquipo.TabIndex = 98;
            this.LblEquipo.Text = "Equipo";
            // 
            // CmbPartido
            // 
            this.CmbPartido.FormattingEnabled = true;
            this.CmbPartido.Location = new System.Drawing.Point(115, 292);
            this.CmbPartido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbPartido.Name = "CmbPartido";
            this.CmbPartido.Size = new System.Drawing.Size(188, 21);
            this.CmbPartido.TabIndex = 100;
            this.CmbPartido.Text = "Selecciona un partido...";
            this.CmbPartido.SelectedIndexChanged += new System.EventHandler(this.CmbPartido_SelectedIndexChanged);
            // 
            // CmbEquipo
            // 
            this.CmbEquipo.Enabled = false;
            this.CmbEquipo.FormattingEnabled = true;
            this.CmbEquipo.Location = new System.Drawing.Point(115, 325);
            this.CmbEquipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbEquipo.Name = "CmbEquipo";
            this.CmbEquipo.Size = new System.Drawing.Size(188, 21);
            this.CmbEquipo.TabIndex = 101;
            this.CmbEquipo.Text = "Selecciona un equipo...";
            this.CmbEquipo.SelectedIndexChanged += new System.EventHandler(this.CmbEquipo_SelectedIndexChanged);
            // 
            // CmbJugador
            // 
            this.CmbJugador.Enabled = false;
            this.CmbJugador.FormattingEnabled = true;
            this.CmbJugador.Location = new System.Drawing.Point(115, 359);
            this.CmbJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbJugador.Name = "CmbJugador";
            this.CmbJugador.Size = new System.Drawing.Size(188, 21);
            this.CmbJugador.TabIndex = 102;
            this.CmbJugador.Text = "Selecciona un jugador...";
            this.CmbJugador.SelectedIndexChanged += new System.EventHandler(this.CmbJugador_SelectedIndexChanged);
            // 
            // CmbArbitro
            // 
            this.CmbArbitro.FormattingEnabled = true;
            this.CmbArbitro.Location = new System.Drawing.Point(115, 394);
            this.CmbArbitro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbArbitro.Name = "CmbArbitro";
            this.CmbArbitro.Size = new System.Drawing.Size(188, 21);
            this.CmbArbitro.TabIndex = 104;
            this.CmbArbitro.Text = "Selecciona un arbitro...";
            // 
            // LblArbitro
            // 
            this.LblArbitro.AutoSize = true;
            this.LblArbitro.Location = new System.Drawing.Point(44, 394);
            this.LblArbitro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblArbitro.Name = "LblArbitro";
            this.LblArbitro.Size = new System.Drawing.Size(37, 13);
            this.LblArbitro.TabIndex = 103;
            this.LblArbitro.Text = "Arbitro";
            // 
            // CmbCampeonato
            // 
            this.CmbCampeonato.FormattingEnabled = true;
            this.CmbCampeonato.Location = new System.Drawing.Point(115, 260);
            this.CmbCampeonato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbCampeonato.Name = "CmbCampeonato";
            this.CmbCampeonato.Size = new System.Drawing.Size(188, 21);
            this.CmbCampeonato.TabIndex = 106;
            this.CmbCampeonato.Text = "Selecciona un campeonato...";
            this.CmbCampeonato.SelectedIndexChanged += new System.EventHandler(this.CmbCampeonato_SelectedIndexChanged);
            // 
            // LblCampeonato
            // 
            this.LblCampeonato.AutoSize = true;
            this.LblCampeonato.Location = new System.Drawing.Point(44, 262);
            this.LblCampeonato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCampeonato.Name = "LblCampeonato";
            this.LblCampeonato.Size = new System.Drawing.Size(67, 13);
            this.LblCampeonato.TabIndex = 105;
            this.LblCampeonato.Text = "Campeonato";
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Haettenschweiler", 16.2F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnAyuda.Location = new System.Drawing.Point(680, 24);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(34, 33);
            this.BtnAyuda.TabIndex = 326;
            this.BtnAyuda.Text = "?";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FormFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(746, 531);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.CmbCampeonato);
            this.Controls.Add(this.LblCampeonato);
            this.Controls.Add(this.CmbArbitro);
            this.Controls.Add(this.LblArbitro);
            this.Controls.Add(this.CmbJugador);
            this.Controls.Add(this.CmbEquipo);
            this.Controls.Add(this.CmbPartido);
            this.Controls.Add(this.LblEquipo);
            this.Controls.Add(this.LblIdJugador);
            this.Controls.Add(this.LblIdPartido);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.CmbTarjeta);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtMinuto);
            this.Controls.Add(this.TxtIdFaltas);
            this.Controls.Add(this.LblTipoFalta);
            this.Controls.Add(this.LblTarjeta);
            this.Controls.Add(this.LblMinuto);
            this.Controls.Add(this.LblIdCampeonato);
            this.Controls.Add(this.CmbFalta);
            this.Controls.Add(this.LblFaltas);
            this.Controls.Add(this.DgvFaltas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFaltas";
            this.Text = "FormFaltas";
            this.Load += new System.EventHandler(this.FormFaltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtMinuto;
        private System.Windows.Forms.TextBox TxtIdFaltas;
        private System.Windows.Forms.Label LblTipoFalta;
        private System.Windows.Forms.Label LblTarjeta;
        private System.Windows.Forms.Label LblMinuto;
        private System.Windows.Forms.Label LblIdCampeonato;
        private System.Windows.Forms.ComboBox CmbFalta;
        private System.Windows.Forms.Label LblFaltas;
        private System.Windows.Forms.DataGridView DgvFaltas;
        private System.Windows.Forms.ComboBox CmbTarjeta;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblIdPartido;
        private System.Windows.Forms.Label LblIdJugador;
        private System.Windows.Forms.Label LblEquipo;
        private System.Windows.Forms.ComboBox CmbPartido;
        private System.Windows.Forms.ComboBox CmbEquipo;
        private System.Windows.Forms.ComboBox CmbJugador;
        private System.Windows.Forms.ComboBox CmbArbitro;
        private System.Windows.Forms.Label LblArbitro;
        private System.Windows.Forms.ComboBox CmbCampeonato;
        private System.Windows.Forms.Label LblCampeonato;
        private System.Windows.Forms.Button BtnAyuda;
    }
}