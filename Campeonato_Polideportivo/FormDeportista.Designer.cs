
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblBeisbol = new System.Windows.Forms.Label();
            this.GridVer = new System.Windows.Forms.DataGridView();
            this.pkidjugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.dateTimePickerDepor = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVer)).BeginInit();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 188;
            this.label8.Text = "Fotografia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 190;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 187;
            this.label6.Text = "Nacionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 184;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 183;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 181;
            this.label1.Text = "Nombre";
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
            // LblBeisbol
            // 
            this.LblBeisbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblBeisbol.AutoSize = true;
            this.LblBeisbol.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBeisbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblBeisbol.Location = new System.Drawing.Point(619, 30);
            this.LblBeisbol.Name = "LblBeisbol";
            this.LblBeisbol.Size = new System.Drawing.Size(203, 50);
            this.LblBeisbol.TabIndex = 175;
            this.LblBeisbol.Text = "DEPORTISTA";
            // 
            // GridVer
            // 
            this.GridVer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidjugador,
            this.Nombre,
            this.apellido,
            this.fechanacimiento,
            this.nacionalidad,
            this.sexo,
            this.fotografia});
            this.GridVer.Location = new System.Drawing.Point(383, 102);
            this.GridVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridVer.Name = "GridVer";
            this.GridVer.ReadOnly = true;
            this.GridVer.RowHeadersWidth = 51;
            this.GridVer.RowTemplate.Height = 24;
            this.GridVer.Size = new System.Drawing.Size(743, 336);
            this.GridVer.TabIndex = 174;
            this.GridVer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVer_CellContentClick);
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
            this.fotografia.Width = 78;
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
            // dateTimePickerDepor
            // 
            this.dateTimePickerDepor.Location = new System.Drawing.Point(189, 177);
            this.dateTimePickerDepor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDepor.Name = "dateTimePickerDepor";
            this.dateTimePickerDepor.Size = new System.Drawing.Size(172, 22);
            this.dateTimePickerDepor.TabIndex = 202;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 203;
            this.label4.Text = "Id_Jugador";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(189, 57);
            this.textID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 22);
            this.textID.TabIndex = 204;
            // 
            // FormDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 654);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDepor);
            this.Controls.Add(this.BtnFoto);
            this.Controls.Add(this.PicFotografia);
            this.Controls.Add(this.TxtSexo);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblBeisbol);
            this.Controls.Add(this.GridVer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDeportista";
            this.Text = "FormDeportista";
            this.Load += new System.EventHandler(this.FormDeportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicFotografia;
        private System.Windows.Forms.TextBox TxtSexo;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblBeisbol;
        private System.Windows.Forms.DataGridView GridVer;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidjugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewImageColumn fotografia;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
    }
}