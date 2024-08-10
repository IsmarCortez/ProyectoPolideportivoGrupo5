
namespace Campeonato_Polideportivo
{
    partial class FormDeportista
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
            this.PicFotografia = new System.Windows.Forms.PictureBox();
            this.TxtSexo = new System.Windows.Forms.TextBox();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblFotografia = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNacionalidad = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblDeportista = new System.Windows.Forms.Label();
            this.DgvDeportista = new System.Windows.Forms.DataGridView();
            this.pkidjugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.LblIdDeportista = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.BtnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeportista)).BeginInit();
            this.SuspendLayout();
            // 
            // PicFotografia
            // 
            this.PicFotografia.Location = new System.Drawing.Point(165, 330);
            this.PicFotografia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicFotografia.Name = "PicFotografia";
            this.PicFotografia.Size = new System.Drawing.Size(125, 108);
            this.PicFotografia.TabIndex = 200;
            this.PicFotografia.TabStop = false;
            this.PicFotografia.Click += new System.EventHandler(this.PicFotografia_Click);
            // 
            // TxtSexo
            // 
            this.TxtSexo.Location = new System.Drawing.Point(189, 276);
            this.TxtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSexo.Name = "TxtSexo";
            this.TxtSexo.Size = new System.Drawing.Size(100, 22);
            this.TxtSexo.TabIndex = 198;
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Location = new System.Drawing.Point(189, 225);
            this.TxtNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(100, 22);
            this.TxtNacionalidad.TabIndex = 197;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(189, 133);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 22);
            this.TxtApellido.TabIndex = 193;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(189, 98);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtNombre.TabIndex = 191;
            // 
            // LblFotografia
            // 
            this.LblFotografia.AutoSize = true;
            this.LblFotografia.Location = new System.Drawing.Point(43, 330);
            this.LblFotografia.Name = "LblFotografia";
            this.LblFotografia.Size = new System.Drawing.Size(68, 16);
            this.LblFotografia.TabIndex = 188;
            this.LblFotografia.Text = "Fotografia";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(43, 276);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(38, 16);
            this.LblSexo.TabIndex = 190;
            this.LblSexo.Text = "Sexo";
            // 
            // LblNacionalidad
            // 
            this.LblNacionalidad.AutoSize = true;
            this.LblNacionalidad.Location = new System.Drawing.Point(43, 225);
            this.LblNacionalidad.Name = "LblNacionalidad";
            this.LblNacionalidad.Size = new System.Drawing.Size(88, 16);
            this.LblNacionalidad.TabIndex = 187;
            this.LblNacionalidad.Text = "Nacionalidad";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(43, 177);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(135, 16);
            this.LblFechaNacimiento.TabIndex = 184;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(43, 133);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(57, 16);
            this.LblApellido.TabIndex = 183;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(43, 102);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 16);
            this.LblNombre.TabIndex = 181;
            this.LblNombre.Text = "Nombre";
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
            this.BtnEliminar.Location = new System.Drawing.Point(857, 498);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(173, 41);
            this.BtnEliminar.TabIndex = 180;
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
            this.BtnModificar.Location = new System.Drawing.Point(615, 498);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(173, 41);
            this.BtnModificar.TabIndex = 179;
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
            this.BtnVer.Location = new System.Drawing.Point(383, 498);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(173, 41);
            this.BtnVer.TabIndex = 178;
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
            this.BtnIngresar.Location = new System.Drawing.Point(136, 498);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(173, 41);
            this.BtnIngresar.TabIndex = 177;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblDeportista
            // 
            this.LblDeportista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblDeportista.AutoSize = true;
            this.LblDeportista.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeportista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblDeportista.Location = new System.Drawing.Point(619, 30);
            this.LblDeportista.Name = "LblDeportista";
            this.LblDeportista.Size = new System.Drawing.Size(200, 50);
            this.LblDeportista.TabIndex = 175;
            this.LblDeportista.Text = "DEPORTISTA";
            // 
            // DgvDeportista
            // 
            this.DgvDeportista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDeportista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDeportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDeportista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidjugador,
            this.Nombre,
            this.apellido,
            this.fechanacimiento,
            this.nacionalidad,
            this.sexo,
            this.fotografia});
            this.DgvDeportista.Location = new System.Drawing.Point(383, 102);
            this.DgvDeportista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvDeportista.Name = "DgvDeportista";
            this.DgvDeportista.ReadOnly = true;
            this.DgvDeportista.RowHeadersWidth = 51;
            this.DgvDeportista.RowTemplate.Height = 24;
            this.DgvDeportista.Size = new System.Drawing.Size(743, 336);
            this.DgvDeportista.TabIndex = 174;
            this.DgvDeportista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVer_CellContentClick);
            // 
            // pkidjugador
            // 
            this.pkidjugador.DataPropertyName = "pkidjugador";
            this.pkidjugador.HeaderText = "Id_jugador";
            this.pkidjugador.MinimumWidth = 6;
            this.pkidjugador.Name = "pkidjugador";
            this.pkidjugador.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.DataPropertyName = "fechanacimiento";
            this.fechanacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechanacimiento.MinimumWidth = 6;
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.ReadOnly = true;
            // 
            // nacionalidad
            // 
            this.nacionalidad.DataPropertyName = "nacionalidad";
            this.nacionalidad.HeaderText = "Nacionalidad";
            this.nacionalidad.MinimumWidth = 6;
            this.nacionalidad.Name = "nacionalidad";
            this.nacionalidad.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // fotografia
            // 
            this.fotografia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fotografia.DataPropertyName = "fotografia";
            this.fotografia.HeaderText = "Fotografia";
            this.fotografia.MinimumWidth = 6;
            this.fotografia.Name = "fotografia";
            this.fotografia.ReadOnly = true;
            this.fotografia.Width = 74;
            // 
            // BtnFoto
            // 
            this.BtnFoto.Location = new System.Drawing.Point(301, 330);
            this.BtnFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(75, 50);
            this.BtnFoto.TabIndex = 201;
            this.BtnFoto.Text = "Subir Foto";
            this.BtnFoto.UseVisualStyleBackColor = true;
            this.BtnFoto.Click += new System.EventHandler(this.BtnFoto_Click);
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(189, 177);
            this.DtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(172, 22);
            this.DtpFechaNacimiento.TabIndex = 202;
            // 
            // LblIdDeportista
            // 
            this.LblIdDeportista.AutoSize = true;
            this.LblIdDeportista.Location = new System.Drawing.Point(45, 63);
            this.LblIdDeportista.Name = "LblIdDeportista";
            this.LblIdDeportista.Size = new System.Drawing.Size(75, 16);
            this.LblIdDeportista.TabIndex = 203;
            this.LblIdDeportista.Text = "Id_Jugador";
            this.LblIdDeportista.Visible = false;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(189, 57);
            this.textID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 22);
            this.textID.TabIndex = 204;
            this.textID.Visible = false;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Haettenschweiler", 16.2F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnAyuda.Location = new System.Drawing.Point(564, 572);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(45, 33);
            this.BtnAyuda.TabIndex = 324;
            this.BtnAyuda.Text = "?";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FormDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 654);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.LblIdDeportista);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.BtnFoto);
            this.Controls.Add(this.PicFotografia);
            this.Controls.Add(this.TxtSexo);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblFotografia);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblNacionalidad);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblDeportista);
            this.Controls.Add(this.DgvDeportista);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDeportista";
            this.Text = "FormDeportista";
            this.Load += new System.EventHandler(this.FormDeportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeportista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicFotografia;
        private System.Windows.Forms.TextBox TxtSexo;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblFotografia;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblNacionalidad;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblDeportista;
        private System.Windows.Forms.DataGridView DgvDeportista;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidjugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewImageColumn fotografia;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Label LblIdDeportista;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button BtnAyuda;
    }
}