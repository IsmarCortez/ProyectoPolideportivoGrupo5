
namespace Campeonato_Polideportivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.BtnEquipo = new System.Windows.Forms.Button();
            this.BtnDeporte = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.LblTitulo2 = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnJugador = new System.Windows.Forms.Button();
            this.BtnEntrenador = new System.Windows.Forms.Button();
            this.BtnArbitro = new System.Windows.Forms.Button();
            this.BtnCampeonato = new System.Windows.Forms.Button();
            this.BtnAsistencia = new System.Windows.Forms.Button();
            this.BtnAnotaciones = new System.Windows.Forms.Button();
            this.BtnFaltas = new System.Windows.Forms.Button();
            this.PanelIngresar = new System.Windows.Forms.Panel();
            this.BtnEquipo2 = new System.Windows.Forms.Button();
            this.BtnDeporte1 = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.PanelEquipos = new System.Windows.Forms.Panel();
            this.BtnJugadores = new System.Windows.Forms.Button();
            this.BtnEntrenadores = new System.Windows.Forms.Button();
            this.BtnEquipos = new System.Windows.Forms.Button();
            this.PanelLateral.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelIngresar.SuspendLayout();
            this.PanelEquipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.AutoScroll = true;
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.PanelLateral.Controls.Add(this.PanelEquipos);
            this.PanelLateral.Controls.Add(this.BtnEquipos);
            this.PanelLateral.Controls.Add(this.PanelIngresar);
            this.PanelLateral.Controls.Add(this.BtnIngresar);
            this.PanelLateral.Controls.Add(this.BtnFaltas);
            this.PanelLateral.Controls.Add(this.BtnAnotaciones);
            this.PanelLateral.Controls.Add(this.BtnAsistencia);
            this.PanelLateral.Controls.Add(this.BtnCampeonato);
            this.PanelLateral.Controls.Add(this.BtnArbitro);
            this.PanelLateral.Controls.Add(this.BtnEntrenador);
            this.PanelLateral.Controls.Add(this.BtnJugador);
            this.PanelLateral.Controls.Add(this.BtnEquipo);
            this.PanelLateral.Controls.Add(this.BtnDeporte);
            this.PanelLateral.Controls.Add(this.BtnInicio);
            this.PanelLateral.Controls.Add(this.PanelLogo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(187, 653);
            this.PanelLateral.TabIndex = 0;
            // 
            // BtnEquipo
            // 
            this.BtnEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEquipo.FlatAppearance.BorderSize = 0;
            this.BtnEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEquipo.Location = new System.Drawing.Point(0, 235);
            this.BtnEquipo.Name = "BtnEquipo";
            this.BtnEquipo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEquipo.Size = new System.Drawing.Size(166, 45);
            this.BtnEquipo.TabIndex = 12;
            this.BtnEquipo.Text = "Equipo";
            this.BtnEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEquipo.UseVisualStyleBackColor = true;
            this.BtnEquipo.Click += new System.EventHandler(this.BtnEquipo_Click_1);
            // 
            // BtnDeporte
            // 
            this.BtnDeporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDeporte.FlatAppearance.BorderSize = 0;
            this.BtnDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnDeporte.Location = new System.Drawing.Point(0, 190);
            this.BtnDeporte.Name = "BtnDeporte";
            this.BtnDeporte.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnDeporte.Size = new System.Drawing.Size(166, 45);
            this.BtnDeporte.TabIndex = 11;
            this.BtnDeporte.Text = "Deporte";
            this.BtnDeporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeporte.UseVisualStyleBackColor = true;
            this.BtnDeporte.Click += new System.EventHandler(this.BtnEmpleados_Click_1);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnInicio.Location = new System.Drawing.Point(0, 145);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnInicio.Size = new System.Drawing.Size(166, 45);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox2);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(166, 145);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Campeonato_Polideportivo.Properties.Resources.logotipo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.PanelForm.Controls.Add(this.LblTitulo2);
            this.PanelForm.Controls.Add(this.LblTitulo);
            this.PanelForm.Controls.Add(this.pictureBox1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(187, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(995, 653);
            this.PanelForm.TabIndex = 1;
            // 
            // LblTitulo2
            // 
            this.LblTitulo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitulo2.AutoSize = true;
            this.LblTitulo2.BackColor = System.Drawing.Color.LightGray;
            this.LblTitulo2.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo2.Location = new System.Drawing.Point(365, 320);
            this.LblTitulo2.Name = "LblTitulo2";
            this.LblTitulo2.Size = new System.Drawing.Size(296, 62);
            this.LblTitulo2.TabIndex = 4;
            this.LblTitulo2.Text = "POLIDEPORTIVO";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.LightGray;
            this.LblTitulo.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(378, 247);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(270, 62);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "CAMPEONATO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Campeonato_Polideportivo.Properties.Resources.fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnJugador
            // 
            this.BtnJugador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJugador.FlatAppearance.BorderSize = 0;
            this.BtnJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnJugador.Location = new System.Drawing.Point(0, 280);
            this.BtnJugador.Name = "BtnJugador";
            this.BtnJugador.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnJugador.Size = new System.Drawing.Size(166, 45);
            this.BtnJugador.TabIndex = 18;
            this.BtnJugador.Text = "Jugador";
            this.BtnJugador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJugador.UseVisualStyleBackColor = true;
            this.BtnJugador.Click += new System.EventHandler(this.BtnJugador_Click);
            // 
            // BtnEntrenador
            // 
            this.BtnEntrenador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEntrenador.FlatAppearance.BorderSize = 0;
            this.BtnEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEntrenador.Location = new System.Drawing.Point(0, 325);
            this.BtnEntrenador.Name = "BtnEntrenador";
            this.BtnEntrenador.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEntrenador.Size = new System.Drawing.Size(166, 45);
            this.BtnEntrenador.TabIndex = 19;
            this.BtnEntrenador.Text = "Entrenador";
            this.BtnEntrenador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntrenador.UseVisualStyleBackColor = true;
            this.BtnEntrenador.Click += new System.EventHandler(this.BtnEntrenador_Click);
            // 
            // BtnArbitro
            // 
            this.BtnArbitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnArbitro.FlatAppearance.BorderSize = 0;
            this.BtnArbitro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArbitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnArbitro.Location = new System.Drawing.Point(0, 370);
            this.BtnArbitro.Name = "BtnArbitro";
            this.BtnArbitro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnArbitro.Size = new System.Drawing.Size(166, 45);
            this.BtnArbitro.TabIndex = 20;
            this.BtnArbitro.Text = "Arbitro";
            this.BtnArbitro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArbitro.UseVisualStyleBackColor = true;
            this.BtnArbitro.Click += new System.EventHandler(this.BtnArbitro_Click);
            // 
            // BtnCampeonato
            // 
            this.BtnCampeonato.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCampeonato.FlatAppearance.BorderSize = 0;
            this.BtnCampeonato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCampeonato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnCampeonato.Location = new System.Drawing.Point(0, 415);
            this.BtnCampeonato.Name = "BtnCampeonato";
            this.BtnCampeonato.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCampeonato.Size = new System.Drawing.Size(166, 45);
            this.BtnCampeonato.TabIndex = 21;
            this.BtnCampeonato.Text = "Campeonato";
            this.BtnCampeonato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCampeonato.UseVisualStyleBackColor = true;
            this.BtnCampeonato.Click += new System.EventHandler(this.BtnCampeonato_Click);
            // 
            // BtnAsistencia
            // 
            this.BtnAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAsistencia.FlatAppearance.BorderSize = 0;
            this.BtnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnAsistencia.Location = new System.Drawing.Point(0, 460);
            this.BtnAsistencia.Name = "BtnAsistencia";
            this.BtnAsistencia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAsistencia.Size = new System.Drawing.Size(166, 45);
            this.BtnAsistencia.TabIndex = 22;
            this.BtnAsistencia.Text = "Asistencia";
            this.BtnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAsistencia.UseVisualStyleBackColor = true;
            this.BtnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // BtnAnotaciones
            // 
            this.BtnAnotaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAnotaciones.FlatAppearance.BorderSize = 0;
            this.BtnAnotaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnotaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnAnotaciones.Location = new System.Drawing.Point(0, 505);
            this.BtnAnotaciones.Name = "BtnAnotaciones";
            this.BtnAnotaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAnotaciones.Size = new System.Drawing.Size(166, 45);
            this.BtnAnotaciones.TabIndex = 23;
            this.BtnAnotaciones.Text = "Anotaciones";
            this.BtnAnotaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnotaciones.UseVisualStyleBackColor = true;
            this.BtnAnotaciones.Click += new System.EventHandler(this.BtnAnotaciones_Click);
            // 
            // BtnFaltas
            // 
            this.BtnFaltas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFaltas.FlatAppearance.BorderSize = 0;
            this.BtnFaltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaltas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnFaltas.Location = new System.Drawing.Point(0, 550);
            this.BtnFaltas.Name = "BtnFaltas";
            this.BtnFaltas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnFaltas.Size = new System.Drawing.Size(166, 45);
            this.BtnFaltas.TabIndex = 24;
            this.BtnFaltas.Text = "Faltas";
            this.BtnFaltas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFaltas.UseVisualStyleBackColor = true;
            this.BtnFaltas.Click += new System.EventHandler(this.BtnFaltas_Click);
            // 
            // PanelIngresar
            // 
            this.PanelIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.PanelIngresar.Controls.Add(this.BtnEquipo2);
            this.PanelIngresar.Controls.Add(this.BtnDeporte1);
            this.PanelIngresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelIngresar.Location = new System.Drawing.Point(0, 640);
            this.PanelIngresar.Name = "PanelIngresar";
            this.PanelIngresar.Size = new System.Drawing.Size(166, 374);
            this.PanelIngresar.TabIndex = 27;
            // 
            // BtnEquipo2
            // 
            this.BtnEquipo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnEquipo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEquipo2.FlatAppearance.BorderSize = 0;
            this.BtnEquipo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnEquipo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipo2.Location = new System.Drawing.Point(0, 40);
            this.BtnEquipo2.Name = "BtnEquipo2";
            this.BtnEquipo2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnEquipo2.Size = new System.Drawing.Size(166, 40);
            this.BtnEquipo2.TabIndex = 1;
            this.BtnEquipo2.Text = "Equipo";
            this.BtnEquipo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEquipo2.UseVisualStyleBackColor = false;
            // 
            // BtnDeporte1
            // 
            this.BtnDeporte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnDeporte1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDeporte1.FlatAppearance.BorderSize = 0;
            this.BtnDeporte1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnDeporte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeporte1.Location = new System.Drawing.Point(0, 0);
            this.BtnDeporte1.Name = "BtnDeporte1";
            this.BtnDeporte1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnDeporte1.Size = new System.Drawing.Size(166, 40);
            this.BtnDeporte1.TabIndex = 0;
            this.BtnDeporte1.Text = "Deporte";
            this.BtnDeporte1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeporte1.UseVisualStyleBackColor = false;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnIngresar.Location = new System.Drawing.Point(0, 595);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnIngresar.Size = new System.Drawing.Size(166, 45);
            this.BtnIngresar.TabIndex = 26;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // PanelEquipos
            // 
            this.PanelEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.PanelEquipos.Controls.Add(this.BtnJugadores);
            this.PanelEquipos.Controls.Add(this.BtnEntrenadores);
            this.PanelEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEquipos.Location = new System.Drawing.Point(0, 1059);
            this.PanelEquipos.Name = "PanelEquipos";
            this.PanelEquipos.Size = new System.Drawing.Size(166, 83);
            this.PanelEquipos.TabIndex = 29;
            // 
            // BtnJugadores
            // 
            this.BtnJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJugadores.FlatAppearance.BorderSize = 0;
            this.BtnJugadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJugadores.Location = new System.Drawing.Point(0, 40);
            this.BtnJugadores.Name = "BtnJugadores";
            this.BtnJugadores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnJugadores.Size = new System.Drawing.Size(166, 43);
            this.BtnJugadores.TabIndex = 1;
            this.BtnJugadores.Text = "Jugadores";
            this.BtnJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJugadores.UseVisualStyleBackColor = false;
            // 
            // BtnEntrenadores
            // 
            this.BtnEntrenadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnEntrenadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEntrenadores.FlatAppearance.BorderSize = 0;
            this.BtnEntrenadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrenadores.Location = new System.Drawing.Point(0, 0);
            this.BtnEntrenadores.Name = "BtnEntrenadores";
            this.BtnEntrenadores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnEntrenadores.Size = new System.Drawing.Size(166, 40);
            this.BtnEntrenadores.TabIndex = 0;
            this.BtnEntrenadores.Text = "Entrenadores";
            this.BtnEntrenadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntrenadores.UseVisualStyleBackColor = false;
            // 
            // BtnEquipos
            // 
            this.BtnEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEquipos.FlatAppearance.BorderSize = 0;
            this.BtnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEquipos.Location = new System.Drawing.Point(0, 1014);
            this.BtnEquipos.Name = "BtnEquipos";
            this.BtnEquipos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEquipos.Size = new System.Drawing.Size(166, 45);
            this.BtnEquipos.TabIndex = 28;
            this.BtnEquipos.Text = "Equipos";
            this.BtnEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEquipos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "Campeonato Polideportivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLateral.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelIngresar.ResumeLayout(false);
            this.PanelEquipos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnDeporte;
        private System.Windows.Forms.Label LblTitulo2;
        private System.Windows.Forms.Button BtnEquipo;
        private System.Windows.Forms.Panel PanelEquipos;
        private System.Windows.Forms.Button BtnJugadores;
        private System.Windows.Forms.Button BtnEntrenadores;
        private System.Windows.Forms.Button BtnEquipos;
        private System.Windows.Forms.Panel PanelIngresar;
        private System.Windows.Forms.Button BtnEquipo2;
        private System.Windows.Forms.Button BtnDeporte1;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnFaltas;
        private System.Windows.Forms.Button BtnAnotaciones;
        private System.Windows.Forms.Button BtnAsistencia;
        private System.Windows.Forms.Button BtnCampeonato;
        private System.Windows.Forms.Button BtnArbitro;
        private System.Windows.Forms.Button BtnEntrenador;
        private System.Windows.Forms.Button BtnJugador;
    }
}

