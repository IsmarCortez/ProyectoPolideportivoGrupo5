
namespace Campeonato_Polideportivo
{
    partial class FormJugador
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
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.CmbEquipo = new System.Windows.Forms.ComboBox();
            this.LblJugador = new System.Windows.Forms.Label();
            this.DgvFutbolista = new System.Windows.Forms.DataGridView();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblPosicion = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblNacionalidad = new System.Windows.Forms.Label();
            this.LblTitular = new System.Windows.Forms.Label();
            this.LblFotografia = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtPosicion = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.TxtTitular = new System.Windows.Forms.TextBox();
            this.PicFotografia = new System.Windows.Forms.PictureBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnSeleccionarFoto = new System.Windows.Forms.Button();
            this.LblGoles = new System.Windows.Forms.Label();
            this.TxtGoles = new System.Windows.Forms.TextBox();
            this.BtnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFutbolista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFotografia)).BeginInit();
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
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEliminar.Location = new System.Drawing.Point(787, 518);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(173, 41);
            this.BtnEliminar.TabIndex = 34;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.BtnVer.Location = new System.Drawing.Point(313, 518);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(173, 41);
            this.BtnVer.TabIndex = 33;
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
            this.BtnIngresar.Location = new System.Drawing.Point(101, 518);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(173, 41);
            this.BtnIngresar.TabIndex = 32;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // CmbEquipo
            // 
            this.CmbEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmbEquipo.FormattingEnabled = true;
            this.CmbEquipo.Location = new System.Drawing.Point(340, 123);
            this.CmbEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEquipo.Name = "CmbEquipo";
            this.CmbEquipo.Size = new System.Drawing.Size(381, 24);
            this.CmbEquipo.TabIndex = 31;
            this.CmbEquipo.Text = "Selecciona un equipo...";
            this.CmbEquipo.SelectedIndexChanged += new System.EventHandler(this.CmbEquipo_SelectedIndexChanged);
            // 
            // LblJugador
            // 
            this.LblJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblJugador.AutoSize = true;
            this.LblJugador.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblJugador.Location = new System.Drawing.Point(375, 49);
            this.LblJugador.Name = "LblJugador";
            this.LblJugador.Size = new System.Drawing.Size(346, 50);
            this.LblJugador.TabIndex = 29;
            this.LblJugador.Text = "JUGADOR FUTBOLISTA";
            // 
            // DgvFutbolista
            // 
            this.DgvFutbolista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFutbolista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFutbolista.Location = new System.Drawing.Point(384, 158);
            this.DgvFutbolista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvFutbolista.Name = "DgvFutbolista";
            this.DgvFutbolista.RowHeadersWidth = 51;
            this.DgvFutbolista.RowTemplate.Height = 24;
            this.DgvFutbolista.Size = new System.Drawing.Size(587, 336);
            this.DgvFutbolista.TabIndex = 28;
            this.DgvFutbolista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVer_CellContentClick);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(29, 126);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 35;
            this.LblNombre.Text = "Nombre";
            this.LblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(176, 123);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(140, 22);
            this.TxtNombre.TabIndex = 36;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(29, 158);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 17);
            this.LblApellido.TabIndex = 35;
            this.LblApellido.Text = "Apellido";
            this.LblApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(29, 194);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(141, 17);
            this.LblFechaNacimiento.TabIndex = 35;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento";
            this.LblFechaNacimiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblPosicion
            // 
            this.LblPosicion.AutoSize = true;
            this.LblPosicion.Location = new System.Drawing.Point(29, 224);
            this.LblPosicion.Name = "LblPosicion";
            this.LblPosicion.Size = new System.Drawing.Size(61, 17);
            this.LblPosicion.TabIndex = 35;
            this.LblPosicion.Text = "Posicion";
            this.LblPosicion.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(29, 254);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(58, 17);
            this.LblNumero.TabIndex = 35;
            this.LblNumero.Text = "Numero";
            this.LblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblNacionalidad
            // 
            this.LblNacionalidad.AutoSize = true;
            this.LblNacionalidad.Location = new System.Drawing.Point(29, 282);
            this.LblNacionalidad.Name = "LblNacionalidad";
            this.LblNacionalidad.Size = new System.Drawing.Size(90, 17);
            this.LblNacionalidad.TabIndex = 35;
            this.LblNacionalidad.Text = "Nacionalidad";
            this.LblNacionalidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblTitular
            // 
            this.LblTitular.AutoSize = true;
            this.LblTitular.Location = new System.Drawing.Point(29, 316);
            this.LblTitular.Name = "LblTitular";
            this.LblTitular.Size = new System.Drawing.Size(48, 17);
            this.LblTitular.TabIndex = 35;
            this.LblTitular.Text = "Titular";
            this.LblTitular.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblFotografia
            // 
            this.LblFotografia.AutoSize = true;
            this.LblFotografia.Location = new System.Drawing.Point(29, 354);
            this.LblFotografia.Name = "LblFotografia";
            this.LblFotografia.Size = new System.Drawing.Size(72, 17);
            this.LblFotografia.TabIndex = 35;
            this.LblFotografia.Text = "Fotografia";
            this.LblFotografia.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(176, 158);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(140, 22);
            this.TxtApellido.TabIndex = 36;
            // 
            // TxtPosicion
            // 
            this.TxtPosicion.Location = new System.Drawing.Point(176, 222);
            this.TxtPosicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPosicion.Name = "TxtPosicion";
            this.TxtPosicion.Size = new System.Drawing.Size(140, 22);
            this.TxtPosicion.TabIndex = 36;
            this.TxtPosicion.TextChanged += new System.EventHandler(this.TxtPosicion_TextChanged);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(176, 251);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(140, 22);
            this.TxtNumero.TabIndex = 36;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtPosicion_TextChanged);
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Location = new System.Drawing.Point(176, 279);
            this.TxtNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(140, 22);
            this.TxtNacionalidad.TabIndex = 36;
            this.TxtNacionalidad.TextChanged += new System.EventHandler(this.TxtPosicion_TextChanged);
            // 
            // TxtTitular
            // 
            this.TxtTitular.Location = new System.Drawing.Point(176, 316);
            this.TxtTitular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTitular.Name = "TxtTitular";
            this.TxtTitular.Size = new System.Drawing.Size(140, 22);
            this.TxtTitular.TabIndex = 36;
            this.TxtTitular.TextChanged += new System.EventHandler(this.TxtPosicion_TextChanged);
            // 
            // PicFotografia
            // 
            this.PicFotografia.Location = new System.Drawing.Point(125, 345);
            this.PicFotografia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicFotografia.Name = "PicFotografia";
            this.PicFotografia.Size = new System.Drawing.Size(169, 102);
            this.PicFotografia.TabIndex = 38;
            this.PicFotografia.TabStop = false;
            this.PicFotografia.Click += new System.EventHandler(this.PicFotografia_Click);
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
            this.BtnModificar.Location = new System.Drawing.Point(545, 518);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(173, 41);
            this.BtnModificar.TabIndex = 33;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(29, 92);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 17);
            this.LblId.TabIndex = 35;
            this.LblId.Text = "ID";
            this.LblId.Visible = false;
            this.LblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(176, 89);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(140, 22);
            this.TxtId.TabIndex = 36;
            this.TxtId.Visible = false;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(176, 190);
            this.DtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaNacimiento.TabIndex = 39;
            this.DtpFechaNacimiento.ValueChanged += new System.EventHandler(this.DtpFechaNacimiento_ValueChanged);
            // 
            // BtnSeleccionarFoto
            // 
            this.BtnSeleccionarFoto.Location = new System.Drawing.Point(300, 370);
            this.BtnSeleccionarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeleccionarFoto.Name = "BtnSeleccionarFoto";
            this.BtnSeleccionarFoto.Size = new System.Drawing.Size(76, 46);
            this.BtnSeleccionarFoto.TabIndex = 40;
            this.BtnSeleccionarFoto.Text = "Subir Foto";
            this.BtnSeleccionarFoto.UseVisualStyleBackColor = true;
            this.BtnSeleccionarFoto.Click += new System.EventHandler(this.BtnSeleccionarFoto_Click_1);
            // 
            // LblGoles
            // 
            this.LblGoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblGoles.AutoSize = true;
            this.LblGoles.Location = new System.Drawing.Point(32, 475);
            this.LblGoles.Name = "LblGoles";
            this.LblGoles.Size = new System.Drawing.Size(45, 17);
            this.LblGoles.TabIndex = 41;
            this.LblGoles.Text = "Goles";
            // 
            // TxtGoles
            // 
            this.TxtGoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtGoles.Location = new System.Drawing.Point(157, 470);
            this.TxtGoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtGoles.Name = "TxtGoles";
            this.TxtGoles.Size = new System.Drawing.Size(100, 22);
            this.TxtGoles.TabIndex = 42;
            this.TxtGoles.TextChanged += new System.EventHandler(this.TxtGoles_TextChanged);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Haettenschweiler", 16.2F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnAyuda.Location = new System.Drawing.Point(926, 11);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(45, 45);
            this.BtnAyuda.TabIndex = 328;
            this.BtnAyuda.Text = "?";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FormJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(995, 654);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.TxtGoles);
            this.Controls.Add(this.LblGoles);
            this.Controls.Add(this.BtnSeleccionarFoto);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.PicFotografia);
            this.Controls.Add(this.TxtTitular);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtPosicion);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblFotografia);
            this.Controls.Add(this.LblTitular);
            this.Controls.Add(this.LblNacionalidad);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblPosicion);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.CmbEquipo);
            this.Controls.Add(this.LblJugador);
            this.Controls.Add(this.DgvFutbolista);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormJugador";
            this.Text = "FormJugador";
            this.Load += new System.EventHandler(this.FormJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFutbolista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.ComboBox CmbEquipo;
        private System.Windows.Forms.Label LblJugador;
        private System.Windows.Forms.DataGridView DgvFutbolista;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblPosicion;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblNacionalidad;
        private System.Windows.Forms.Label LblTitular;
        private System.Windows.Forms.Label LblFotografia;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtPosicion;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.TextBox TxtTitular;
        private System.Windows.Forms.PictureBox PicFotografia;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Button BtnSeleccionarFoto;
        private System.Windows.Forms.Label LblGoles;
        private System.Windows.Forms.TextBox TxtGoles;
        private System.Windows.Forms.Button BtnAyuda;
    }
}