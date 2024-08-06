
namespace Campeonato_Polideportivo
{
    partial class FormEntrenador
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
            this.CmbEquipo = new System.Windows.Forms.ComboBox();
            this.LblEntrenador = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnVer = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNacionalidad = new System.Windows.Forms.Label();
            this.LblEquipo = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.LblIdEntrenador = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.DtpEntrenador = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.BtnEliminar.Location = new System.Drawing.Point(716, 540);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(174, 41);
            this.BtnEliminar.TabIndex = 41;
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
            this.BtnModificar.Location = new System.Drawing.Point(503, 540);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(174, 41);
            this.BtnModificar.TabIndex = 40;
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
            this.BtnIngresar.Location = new System.Drawing.Point(84, 540);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(174, 41);
            this.BtnIngresar.TabIndex = 39;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // CmbEquipo
            // 
            this.CmbEquipo.FormattingEnabled = true;
            this.CmbEquipo.Location = new System.Drawing.Point(134, 387);
            this.CmbEquipo.Name = "CmbEquipo";
            this.CmbEquipo.Size = new System.Drawing.Size(288, 24);
            this.CmbEquipo.TabIndex = 38;
            this.CmbEquipo.Text = "Selecciona un equipo...";
            this.CmbEquipo.SelectedIndexChanged += new System.EventHandler(this.CmbEquipo_SelectedIndexChanged);
            // 
            // LblEntrenador
            // 
            this.LblEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblEntrenador.AutoSize = true;
            this.LblEntrenador.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblEntrenador.Location = new System.Drawing.Point(381, 51);
            this.LblEntrenador.Name = "LblEntrenador";
            this.LblEntrenador.Size = new System.Drawing.Size(216, 50);
            this.LblEntrenador.TabIndex = 36;
            this.LblEntrenador.Text = "ENTRENADOR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 367);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.BtnVer.Location = new System.Drawing.Point(293, 540);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(174, 41);
            this.BtnVer.TabIndex = 42;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(62, 133);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 43;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(62, 201);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 17);
            this.LblApellido.TabIndex = 44;
            this.LblApellido.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // LblNacionalidad
            // 
            this.LblNacionalidad.AutoSize = true;
            this.LblNacionalidad.Location = new System.Drawing.Point(30, 323);
            this.LblNacionalidad.Name = "LblNacionalidad";
            this.LblNacionalidad.Size = new System.Drawing.Size(90, 17);
            this.LblNacionalidad.TabIndex = 46;
            this.LblNacionalidad.Text = "Nacionalidad";
            // 
            // LblEquipo
            // 
            this.LblEquipo.AutoSize = true;
            this.LblEquipo.Location = new System.Drawing.Point(55, 387);
            this.LblEquipo.Name = "LblEquipo";
            this.LblEquipo.Size = new System.Drawing.Size(52, 17);
            this.LblEquipo.TabIndex = 47;
            this.LblEquipo.Text = "Equipo";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(134, 133);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(288, 22);
            this.TxtNombre.TabIndex = 48;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(134, 201);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(288, 22);
            this.TxtApellido.TabIndex = 49;
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Location = new System.Drawing.Point(134, 320);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(288, 22);
            this.TxtNacionalidad.TabIndex = 51;
            // 
            // LblIdEntrenador
            // 
            this.LblIdEntrenador.AutoSize = true;
            this.LblIdEntrenador.Location = new System.Drawing.Point(30, 82);
            this.LblIdEntrenador.Name = "LblIdEntrenador";
            this.LblIdEntrenador.Size = new System.Drawing.Size(96, 17);
            this.LblIdEntrenador.TabIndex = 52;
            this.LblIdEntrenador.Text = "ID Entrenador";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(134, 79);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 22);
            this.TxtID.TabIndex = 53;
            // 
            // DtpEntrenador
            // 
            this.DtpEntrenador.Location = new System.Drawing.Point(159, 260);
            this.DtpEntrenador.Name = "DtpEntrenador";
            this.DtpEntrenador.Size = new System.Drawing.Size(263, 22);
            this.DtpEntrenador.TabIndex = 54;
            // 
            // FormEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 653);
            this.Controls.Add(this.DtpEntrenador);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblIdEntrenador);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblEquipo);
            this.Controls.Add(this.LblNacionalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.CmbEquipo);
            this.Controls.Add(this.LblEntrenador);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEntrenador";
            this.Text = "FormEntrenador";
            this.Load += new System.EventHandler(this.FormEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.ComboBox CmbEquipo;
        private System.Windows.Forms.Label LblEntrenador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNacionalidad;
        private System.Windows.Forms.Label LblEquipo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.Label LblIdEntrenador;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DateTimePicker DtpEntrenador;
    }
}