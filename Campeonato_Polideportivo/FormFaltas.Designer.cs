
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
            this.BtnVer.Location = new System.Drawing.Point(311, 553);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(173, 41);
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
            this.BtnEliminar.Location = new System.Drawing.Point(733, 553);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(173, 41);
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
            this.BtnModificar.Location = new System.Drawing.Point(521, 553);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(173, 41);
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
            this.BtnIngresar.Location = new System.Drawing.Point(101, 553);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(173, 41);
            this.BtnIngresar.TabIndex = 85;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtMinuto
            // 
            this.TxtMinuto.Location = new System.Drawing.Point(153, 95);
            this.TxtMinuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMinuto.Name = "TxtMinuto";
            this.TxtMinuto.Size = new System.Drawing.Size(249, 22);
            this.TxtMinuto.TabIndex = 83;
            // 
            // TxtIdFaltas
            // 
            this.TxtIdFaltas.Enabled = false;
            this.TxtIdFaltas.Location = new System.Drawing.Point(153, 46);
            this.TxtIdFaltas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIdFaltas.Name = "TxtIdFaltas";
            this.TxtIdFaltas.Size = new System.Drawing.Size(100, 22);
            this.TxtIdFaltas.TabIndex = 82;
            // 
            // LblTipoFalta
            // 
            this.LblTipoFalta.AutoSize = true;
            this.LblTipoFalta.Location = new System.Drawing.Point(57, 193);
            this.LblTipoFalta.Name = "LblTipoFalta";
            this.LblTipoFalta.Size = new System.Drawing.Size(91, 17);
            this.LblTipoFalta.TabIndex = 77;
            this.LblTipoFalta.Text = "Tipo de Falta";
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.Location = new System.Drawing.Point(59, 146);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(53, 17);
            this.LblTarjeta.TabIndex = 76;
            this.LblTarjeta.Text = "Tarjeta";
            // 
            // LblMinuto
            // 
            this.LblMinuto.AutoSize = true;
            this.LblMinuto.Location = new System.Drawing.Point(59, 95);
            this.LblMinuto.Name = "LblMinuto";
            this.LblMinuto.Size = new System.Drawing.Size(50, 17);
            this.LblMinuto.TabIndex = 75;
            this.LblMinuto.Text = "Minuto";
            // 
            // LblIdCampeonato
            // 
            this.LblIdCampeonato.AutoSize = true;
            this.LblIdCampeonato.Location = new System.Drawing.Point(59, 49);
            this.LblIdCampeonato.Name = "LblIdCampeonato";
            this.LblIdCampeonato.Size = new System.Drawing.Size(21, 17);
            this.LblIdCampeonato.TabIndex = 74;
            this.LblIdCampeonato.Text = "ID";
            // 
            // CmbFalta
            // 
            this.CmbFalta.FormattingEnabled = true;
            this.CmbFalta.Location = new System.Drawing.Point(153, 193);
            this.CmbFalta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbFalta.Name = "CmbFalta";
            this.CmbFalta.Size = new System.Drawing.Size(249, 24);
            this.CmbFalta.TabIndex = 73;
            this.CmbFalta.Text = "Selecciona un tipo de falta...";
            // 
            // LblFaltas
            // 
            this.LblFaltas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblFaltas.AutoSize = true;
            this.LblFaltas.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFaltas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblFaltas.Location = new System.Drawing.Point(421, 20);
            this.LblFaltas.Name = "LblFaltas";
            this.LblFaltas.Size = new System.Drawing.Size(135, 50);
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
            this.DgvFaltas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFaltas.Location = new System.Drawing.Point(431, 98);
            this.DgvFaltas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvFaltas.Name = "DgvFaltas";
            this.DgvFaltas.ReadOnly = true;
            this.DgvFaltas.RowHeadersWidth = 51;
            this.DgvFaltas.RowTemplate.Height = 24;
            this.DgvFaltas.Size = new System.Drawing.Size(521, 411);
            this.DgvFaltas.TabIndex = 71;
            this.DgvFaltas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFaltas_CellContentClick);
            // 
            // CmbTarjeta
            // 
            this.CmbTarjeta.FormattingEnabled = true;
            this.CmbTarjeta.Location = new System.Drawing.Point(153, 144);
            this.CmbTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTarjeta.Name = "CmbTarjeta";
            this.CmbTarjeta.Size = new System.Drawing.Size(249, 24);
            this.CmbTarjeta.TabIndex = 89;
            this.CmbTarjeta.Text = "Selecciona una tarjeta...";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(153, 242);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(249, 22);
            this.TxtDescripcion.TabIndex = 91;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(59, 242);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.LblDescripcion.TabIndex = 90;
            this.LblDescripcion.Text = "Descripción";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(153, 290);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(249, 22);
            this.DtpFecha.TabIndex = 93;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(59, 290);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(47, 17);
            this.LblFecha.TabIndex = 92;
            this.LblFecha.Text = "Fecha";
            // 
            // LblIdPartido
            // 
            this.LblIdPartido.AutoSize = true;
            this.LblIdPartido.Location = new System.Drawing.Point(59, 341);
            this.LblIdPartido.Name = "LblIdPartido";
            this.LblIdPartido.Size = new System.Drawing.Size(93, 17);
            this.LblIdPartido.TabIndex = 94;
            this.LblIdPartido.Text = "ID del Partido";
            // 
            // LblIdJugador
            // 
            this.LblIdJugador.AutoSize = true;
            this.LblIdJugador.Location = new System.Drawing.Point(51, 441);
            this.LblIdJugador.Name = "LblIdJugador";
            this.LblIdJugador.Size = new System.Drawing.Size(60, 17);
            this.LblIdJugador.TabIndex = 96;
            this.LblIdJugador.Text = "Jugador";
            // 
            // LblEquipo
            // 
            this.LblEquipo.AutoSize = true;
            this.LblEquipo.Location = new System.Drawing.Point(57, 391);
            this.LblEquipo.Name = "LblEquipo";
            this.LblEquipo.Size = new System.Drawing.Size(52, 17);
            this.LblEquipo.TabIndex = 98;
            this.LblEquipo.Text = "Equipo";
            // 
            // CmbPartido
            // 
            this.CmbPartido.FormattingEnabled = true;
            this.CmbPartido.Location = new System.Drawing.Point(153, 338);
            this.CmbPartido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbPartido.Name = "CmbPartido";
            this.CmbPartido.Size = new System.Drawing.Size(249, 24);
            this.CmbPartido.TabIndex = 100;
            this.CmbPartido.Text = "Selecciona un partido...";
            this.CmbPartido.SelectedIndexChanged += new System.EventHandler(this.CmbPartido_SelectedIndexChanged);
            // 
            // CmbEquipo
            // 
            this.CmbEquipo.Enabled = false;
            this.CmbEquipo.FormattingEnabled = true;
            this.CmbEquipo.Location = new System.Drawing.Point(153, 389);
            this.CmbEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEquipo.Name = "CmbEquipo";
            this.CmbEquipo.Size = new System.Drawing.Size(249, 24);
            this.CmbEquipo.TabIndex = 101;
            this.CmbEquipo.Text = "Selecciona un equipo...";
            this.CmbEquipo.SelectedIndexChanged += new System.EventHandler(this.CmbEquipo_SelectedIndexChanged);
            // 
            // CmbJugador
            // 
            this.CmbJugador.Enabled = false;
            this.CmbJugador.FormattingEnabled = true;
            this.CmbJugador.Location = new System.Drawing.Point(153, 437);
            this.CmbJugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbJugador.Name = "CmbJugador";
            this.CmbJugador.Size = new System.Drawing.Size(249, 24);
            this.CmbJugador.TabIndex = 102;
            this.CmbJugador.Text = "Selecciona un jugador...";
            this.CmbJugador.SelectedIndexChanged += new System.EventHandler(this.CmbJugador_SelectedIndexChanged);
            // 
            // CmbArbitro
            // 
            this.CmbArbitro.FormattingEnabled = true;
            this.CmbArbitro.Location = new System.Drawing.Point(153, 485);
            this.CmbArbitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbArbitro.Name = "CmbArbitro";
            this.CmbArbitro.Size = new System.Drawing.Size(249, 24);
            this.CmbArbitro.TabIndex = 104;
            this.CmbArbitro.Text = "Selecciona un arbitro...";
            // 
            // LblArbitro
            // 
            this.LblArbitro.AutoSize = true;
            this.LblArbitro.Location = new System.Drawing.Point(59, 485);
            this.LblArbitro.Name = "LblArbitro";
            this.LblArbitro.Size = new System.Drawing.Size(50, 17);
            this.LblArbitro.TabIndex = 103;
            this.LblArbitro.Text = "Arbitro";
            // 
            // FormFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 654);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}