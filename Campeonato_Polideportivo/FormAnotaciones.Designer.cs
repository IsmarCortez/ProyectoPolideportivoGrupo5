
namespace Campeonato_Polideportivo
{
    partial class FormAnotaciones
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblAnotaciones = new System.Windows.Forms.Label();
            this.DgvAnotaciones = new System.Windows.Forms.DataGridView();
            this.LblIdAnotaciones = new System.Windows.Forms.Label();
            this.LblMinuto = new System.Windows.Forms.Label();
            this.LblTipodeAnotacion = new System.Windows.Forms.Label();
            this.TxtIdAnotaciones = new System.Windows.Forms.TextBox();
            this.TxtMinuto = new System.Windows.Forms.TextBox();
            this.TxtTipodeAnotacion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblIdPartido = new System.Windows.Forms.Label();
            this.LblJugador = new System.Windows.Forms.Label();
            this.LblAsistencia = new System.Windows.Forms.Label();
            this.TxtIdPartido = new System.Windows.Forms.TextBox();
            this.TxtIdJugador = new System.Windows.Forms.TextBox();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.CmbTipoAnotacion = new System.Windows.Forms.ComboBox();
            this.CmbPartido = new System.Windows.Forms.ComboBox();
            this.CmbJugador = new System.Windows.Forms.ComboBox();
            this.CmbAsistencia = new System.Windows.Forms.ComboBox();
            this.CmbCampeonato = new System.Windows.Forms.ComboBox();
            this.LblCampeonato = new System.Windows.Forms.Label();
            this.CmbEquipo = new System.Windows.Forms.ComboBox();
            this.LblEquipo = new System.Windows.Forms.Label();
            this.BtnTablaMejoresJugs = new System.Windows.Forms.Button();
            this.DgvJugs = new System.Windows.Forms.DataGridView();
            this.BtnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnotaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJugs)).BeginInit();
            this.SuspendLayout();
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
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(551, 443);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 33);
            this.BtnEliminar.TabIndex = 62;
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
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(392, 443);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 33);
            this.BtnModificar.TabIndex = 61;
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
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(322, 396);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(130, 33);
            this.BtnIngresar.TabIndex = 60;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblAnotaciones
            // 
            this.LblAnotaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblAnotaciones.AutoSize = true;
            this.LblAnotaciones.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnotaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblAnotaciones.Location = new System.Drawing.Point(300, 38);
            this.LblAnotaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAnotaciones.Name = "LblAnotaciones";
            this.LblAnotaciones.Size = new System.Drawing.Size(185, 40);
            this.LblAnotaciones.TabIndex = 57;
            this.LblAnotaciones.Text = "ANOTACIONES";
            // 
            // DgvAnotaciones
            // 
            this.DgvAnotaciones.AllowUserToAddRows = false;
            this.DgvAnotaciones.AllowUserToDeleteRows = false;
            this.DgvAnotaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAnotaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvAnotaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAnotaciones.Location = new System.Drawing.Point(315, 93);
            this.DgvAnotaciones.Margin = new System.Windows.Forms.Padding(2);
            this.DgvAnotaciones.Name = "DgvAnotaciones";
            this.DgvAnotaciones.RowHeadersWidth = 51;
            this.DgvAnotaciones.RowTemplate.Height = 24;
            this.DgvAnotaciones.Size = new System.Drawing.Size(455, 266);
            this.DgvAnotaciones.TabIndex = 56;
            this.DgvAnotaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LblIdAnotaciones
            // 
            this.LblIdAnotaciones.AutoSize = true;
            this.LblIdAnotaciones.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdAnotaciones.Location = new System.Drawing.Point(66, 86);
            this.LblIdAnotaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIdAnotaciones.Name = "LblIdAnotaciones";
            this.LblIdAnotaciones.Size = new System.Drawing.Size(92, 17);
            this.LblIdAnotaciones.TabIndex = 63;
            this.LblIdAnotaciones.Text = "Id_anotaciones";
            this.LblIdAnotaciones.Visible = false;
            // 
            // LblMinuto
            // 
            this.LblMinuto.AutoSize = true;
            this.LblMinuto.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinuto.Location = new System.Drawing.Point(66, 119);
            this.LblMinuto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMinuto.Name = "LblMinuto";
            this.LblMinuto.Size = new System.Drawing.Size(45, 17);
            this.LblMinuto.TabIndex = 64;
            this.LblMinuto.Text = "Minuto";
            // 
            // LblTipodeAnotacion
            // 
            this.LblTipodeAnotacion.AutoSize = true;
            this.LblTipodeAnotacion.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipodeAnotacion.Location = new System.Drawing.Point(66, 151);
            this.LblTipodeAnotacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTipodeAnotacion.Name = "LblTipodeAnotacion";
            this.LblTipodeAnotacion.Size = new System.Drawing.Size(104, 17);
            this.LblTipodeAnotacion.TabIndex = 65;
            this.LblTipodeAnotacion.Text = "tipo de anotación";
            // 
            // TxtIdAnotaciones
            // 
            this.TxtIdAnotaciones.Enabled = false;
            this.TxtIdAnotaciones.Location = new System.Drawing.Point(176, 86);
            this.TxtIdAnotaciones.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdAnotaciones.Name = "TxtIdAnotaciones";
            this.TxtIdAnotaciones.Size = new System.Drawing.Size(124, 20);
            this.TxtIdAnotaciones.TabIndex = 66;
            this.TxtIdAnotaciones.Visible = false;
            // 
            // TxtMinuto
            // 
            this.TxtMinuto.Location = new System.Drawing.Point(176, 119);
            this.TxtMinuto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMinuto.Name = "TxtMinuto";
            this.TxtMinuto.Size = new System.Drawing.Size(124, 20);
            this.TxtMinuto.TabIndex = 67;
            // 
            // TxtTipodeAnotacion
            // 
            this.TxtTipodeAnotacion.Location = new System.Drawing.Point(190, 148);
            this.TxtTipodeAnotacion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTipodeAnotacion.Name = "TxtTipodeAnotacion";
            this.TxtTipodeAnotacion.Size = new System.Drawing.Size(91, 20);
            this.TxtTipodeAnotacion.TabIndex = 68;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(66, 336);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(71, 17);
            this.LblDescripcion.TabIndex = 69;
            this.LblDescripcion.Text = "Descripción";
            this.LblDescripcion.Click += new System.EventHandler(this.LblDescripcion_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(139, 334);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(161, 20);
            this.TxtDescripcion.TabIndex = 70;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // LblIdPartido
            // 
            this.LblIdPartido.AutoSize = true;
            this.LblIdPartido.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdPartido.Location = new System.Drawing.Point(66, 212);
            this.LblIdPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIdPartido.Name = "LblIdPartido";
            this.LblIdPartido.Size = new System.Drawing.Size(68, 17);
            this.LblIdPartido.TabIndex = 71;
            this.LblIdPartido.Text = "Id_Partido";
            // 
            // LblJugador
            // 
            this.LblJugador.AutoSize = true;
            this.LblJugador.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJugador.Location = new System.Drawing.Point(66, 266);
            this.LblJugador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblJugador.Name = "LblJugador";
            this.LblJugador.Size = new System.Drawing.Size(70, 17);
            this.LblJugador.TabIndex = 72;
            this.LblJugador.Text = "Id_Jugador";
            // 
            // LblAsistencia
            // 
            this.LblAsistencia.AutoSize = true;
            this.LblAsistencia.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsistencia.Location = new System.Drawing.Point(66, 300);
            this.LblAsistencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAsistencia.Name = "LblAsistencia";
            this.LblAsistencia.Size = new System.Drawing.Size(80, 17);
            this.LblAsistencia.TabIndex = 73;
            this.LblAsistencia.Text = "Id_Asistencia";
            // 
            // TxtIdPartido
            // 
            this.TxtIdPartido.Location = new System.Drawing.Point(190, 208);
            this.TxtIdPartido.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdPartido.Name = "TxtIdPartido";
            this.TxtIdPartido.Size = new System.Drawing.Size(91, 20);
            this.TxtIdPartido.TabIndex = 74;
            // 
            // TxtIdJugador
            // 
            this.TxtIdJugador.Location = new System.Drawing.Point(190, 266);
            this.TxtIdJugador.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdJugador.Name = "TxtIdJugador";
            this.TxtIdJugador.Size = new System.Drawing.Size(91, 20);
            this.TxtIdJugador.TabIndex = 75;
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Haettenschweiler", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.Color.White;
            this.BtnVer.Location = new System.Drawing.Point(477, 396);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(130, 32);
            this.BtnVer.TabIndex = 77;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(628, 394);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(130, 33);
            this.BtnLimpiar.TabIndex = 78;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // CmbTipoAnotacion
            // 
            this.CmbTipoAnotacion.FormattingEnabled = true;
            this.CmbTipoAnotacion.Location = new System.Drawing.Point(176, 148);
            this.CmbTipoAnotacion.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTipoAnotacion.Name = "CmbTipoAnotacion";
            this.CmbTipoAnotacion.Size = new System.Drawing.Size(124, 21);
            this.CmbTipoAnotacion.TabIndex = 79;
            // 
            // CmbPartido
            // 
            this.CmbPartido.FormattingEnabled = true;
            this.CmbPartido.Location = new System.Drawing.Point(176, 208);
            this.CmbPartido.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPartido.Name = "CmbPartido";
            this.CmbPartido.Size = new System.Drawing.Size(124, 21);
            this.CmbPartido.TabIndex = 80;
            this.CmbPartido.SelectedIndexChanged += new System.EventHandler(this.CmbPartido_SelectedIndexChanged);
            // 
            // CmbJugador
            // 
            this.CmbJugador.FormattingEnabled = true;
            this.CmbJugador.Location = new System.Drawing.Point(176, 266);
            this.CmbJugador.Margin = new System.Windows.Forms.Padding(2);
            this.CmbJugador.Name = "CmbJugador";
            this.CmbJugador.Size = new System.Drawing.Size(124, 21);
            this.CmbJugador.TabIndex = 81;
            this.CmbJugador.SelectedIndexChanged += new System.EventHandler(this.CmbJugador_SelectedIndexChanged);
            // 
            // CmbAsistencia
            // 
            this.CmbAsistencia.FormattingEnabled = true;
            this.CmbAsistencia.Location = new System.Drawing.Point(176, 300);
            this.CmbAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.CmbAsistencia.Name = "CmbAsistencia";
            this.CmbAsistencia.Size = new System.Drawing.Size(124, 21);
            this.CmbAsistencia.TabIndex = 82;
            // 
            // CmbCampeonato
            // 
            this.CmbCampeonato.FormattingEnabled = true;
            this.CmbCampeonato.Location = new System.Drawing.Point(150, 178);
            this.CmbCampeonato.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCampeonato.Name = "CmbCampeonato";
            this.CmbCampeonato.Size = new System.Drawing.Size(150, 21);
            this.CmbCampeonato.TabIndex = 108;
            this.CmbCampeonato.Text = "Selecciona un campeonato...";
            this.CmbCampeonato.SelectedIndexChanged += new System.EventHandler(this.CmbCampeonato_SelectedIndexChanged);
            // 
            // LblCampeonato
            // 
            this.LblCampeonato.AutoSize = true;
            this.LblCampeonato.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F);
            this.LblCampeonato.Location = new System.Drawing.Point(66, 181);
            this.LblCampeonato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCampeonato.Name = "LblCampeonato";
            this.LblCampeonato.Size = new System.Drawing.Size(76, 17);
            this.LblCampeonato.TabIndex = 107;
            this.LblCampeonato.Text = "Campeonato";
            // 
            // CmbEquipo
            // 
            this.CmbEquipo.Enabled = false;
            this.CmbEquipo.FormattingEnabled = true;
            this.CmbEquipo.Location = new System.Drawing.Point(139, 238);
            this.CmbEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.CmbEquipo.Name = "CmbEquipo";
            this.CmbEquipo.Size = new System.Drawing.Size(161, 21);
            this.CmbEquipo.TabIndex = 110;
            this.CmbEquipo.Text = "Selecciona un equipo...";
            this.CmbEquipo.SelectedIndexChanged += new System.EventHandler(this.CmbEquipo_SelectedIndexChanged);
            // 
            // LblEquipo
            // 
            this.LblEquipo.AutoSize = true;
            this.LblEquipo.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F);
            this.LblEquipo.Location = new System.Drawing.Point(66, 238);
            this.LblEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEquipo.Name = "LblEquipo";
            this.LblEquipo.Size = new System.Drawing.Size(46, 17);
            this.LblEquipo.TabIndex = 109;
            this.LblEquipo.Text = "Equipo";
            // 
            // BtnTablaMejoresJugs
            // 
            this.BtnTablaMejoresJugs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTablaMejoresJugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnTablaMejoresJugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTablaMejoresJugs.Font = new System.Drawing.Font("Haettenschweiler", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablaMejoresJugs.ForeColor = System.Drawing.Color.White;
            this.BtnTablaMejoresJugs.Location = new System.Drawing.Point(105, 386);
            this.BtnTablaMejoresJugs.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTablaMejoresJugs.Name = "BtnTablaMejoresJugs";
            this.BtnTablaMejoresJugs.Size = new System.Drawing.Size(130, 56);
            this.BtnTablaMejoresJugs.TabIndex = 111;
            this.BtnTablaMejoresJugs.Text = "TABLA MEJORES JUGADORES";
            this.BtnTablaMejoresJugs.UseVisualStyleBackColor = false;
            this.BtnTablaMejoresJugs.Click += new System.EventHandler(this.BtnTablaMejoresJugs_Click);
            // 
            // DgvJugs
            // 
            this.DgvJugs.AllowUserToAddRows = false;
            this.DgvJugs.AllowUserToDeleteRows = false;
            this.DgvJugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvJugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvJugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJugs.Location = new System.Drawing.Point(328, 102);
            this.DgvJugs.Margin = new System.Windows.Forms.Padding(2);
            this.DgvJugs.Name = "DgvJugs";
            this.DgvJugs.RowHeadersWidth = 51;
            this.DgvJugs.RowTemplate.Height = 24;
            this.DgvJugs.Size = new System.Drawing.Size(430, 249);
            this.DgvJugs.TabIndex = 112;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Haettenschweiler", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyuda.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAyuda.Location = new System.Drawing.Point(748, 9);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(38, 32);
            this.BtnAyuda.TabIndex = 113;
            this.BtnAyuda.Text = "?";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FormAnotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(794, 531);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.DgvJugs);
            this.Controls.Add(this.BtnTablaMejoresJugs);
            this.Controls.Add(this.CmbEquipo);
            this.Controls.Add(this.LblEquipo);
            this.Controls.Add(this.CmbCampeonato);
            this.Controls.Add(this.LblCampeonato);
            this.Controls.Add(this.CmbAsistencia);
            this.Controls.Add(this.CmbJugador);
            this.Controls.Add(this.CmbPartido);
            this.Controls.Add(this.CmbTipoAnotacion);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.TxtIdJugador);
            this.Controls.Add(this.TxtIdPartido);
            this.Controls.Add(this.LblAsistencia);
            this.Controls.Add(this.LblJugador);
            this.Controls.Add(this.LblIdPartido);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtTipodeAnotacion);
            this.Controls.Add(this.TxtMinuto);
            this.Controls.Add(this.TxtIdAnotaciones);
            this.Controls.Add(this.LblTipodeAnotacion);
            this.Controls.Add(this.LblMinuto);
            this.Controls.Add(this.LblIdAnotaciones);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblAnotaciones);
            this.Controls.Add(this.DgvAnotaciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAnotaciones";
            this.Text = "FormAnotaciones";
            this.Load += new System.EventHandler(this.FormAnotaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnotaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblAnotaciones;
        private System.Windows.Forms.DataGridView DgvAnotaciones;
        private System.Windows.Forms.Label LblIdAnotaciones;
        private System.Windows.Forms.Label LblMinuto;
        private System.Windows.Forms.Label LblTipodeAnotacion;
        private System.Windows.Forms.TextBox TxtIdAnotaciones;
        private System.Windows.Forms.TextBox TxtMinuto;
        private System.Windows.Forms.TextBox TxtTipodeAnotacion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblIdPartido;
        private System.Windows.Forms.Label LblJugador;
        private System.Windows.Forms.Label LblAsistencia;
        private System.Windows.Forms.TextBox TxtIdPartido;
        private System.Windows.Forms.TextBox TxtIdJugador;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ComboBox CmbTipoAnotacion;
        private System.Windows.Forms.ComboBox CmbPartido;
        private System.Windows.Forms.ComboBox CmbJugador;
        private System.Windows.Forms.ComboBox CmbAsistencia;
        private System.Windows.Forms.ComboBox CmbCampeonato;
        private System.Windows.Forms.Label LblCampeonato;
        private System.Windows.Forms.ComboBox CmbEquipo;
        private System.Windows.Forms.Label LblEquipo;
        private System.Windows.Forms.Button BtnTablaMejoresJugs;
        private System.Windows.Forms.DataGridView DgvJugs;
        private System.Windows.Forms.Button BtnAyuda;
    }
}