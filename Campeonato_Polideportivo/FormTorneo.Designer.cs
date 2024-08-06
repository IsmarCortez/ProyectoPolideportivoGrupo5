
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblBeisbol = new System.Windows.Forms.Label();
            this.GridVer = new System.Windows.Forms.DataGridView();
            this.pkidtorneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkiddeporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechafin = new System.Windows.Forms.DateTimePicker();
            this.CmbDeporte = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridVer)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTemporada
            // 
            this.TxtTemporada.Location = new System.Drawing.Point(221, 231);
            this.TxtTemporada.Name = "TxtTemporada";
            this.TxtTemporada.Size = new System.Drawing.Size(100, 22);
            this.TxtTemporada.TabIndex = 220;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(221, 163);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 219;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(221, 197);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtNombre.TabIndex = 218;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 214;
            this.label6.Text = "Deporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 212;
            this.label4.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 211;
            this.label3.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 210;
            this.label2.Text = "Temporada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 209;
            this.label9.Text = "ID_Torneo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 208;
            this.label1.Text = "Nombre Torneo";
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
            this.BtnEliminar.Location = new System.Drawing.Point(885, 503);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(174, 41);
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
            this.BtnModificar.Location = new System.Drawing.Point(643, 503);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(174, 41);
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
            this.BtnVer.Location = new System.Drawing.Point(411, 503);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(174, 41);
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
            this.BtnIngresar.Location = new System.Drawing.Point(164, 503);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(174, 41);
            this.BtnIngresar.TabIndex = 204;
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
            this.LblBeisbol.Location = new System.Drawing.Point(473, 34);
            this.LblBeisbol.Name = "LblBeisbol";
            this.LblBeisbol.Size = new System.Drawing.Size(136, 50);
            this.LblBeisbol.TabIndex = 202;
            this.LblBeisbol.Text = "TORNEO";
            // 
            // GridVer
            // 
            this.GridVer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidtorneo,
            this.nombre,
            this.temporada,
            this.fechainicio,
            this.fechafin,
            this.fkiddeporte});
            this.GridVer.Location = new System.Drawing.Point(411, 150);
            this.GridVer.Name = "GridVer";
            this.GridVer.ReadOnly = true;
            this.GridVer.RowHeadersWidth = 51;
            this.GridVer.RowTemplate.Height = 24;
            this.GridVer.Size = new System.Drawing.Size(669, 336);
            this.GridVer.TabIndex = 201;
            this.GridVer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVer_CellContentClick);
            // 
            // pkidtorneo
            // 
            this.pkidtorneo.DataPropertyName = "pkidtorneo";
            this.pkidtorneo.HeaderText = "ID_torneo";
            this.pkidtorneo.MinimumWidth = 6;
            this.pkidtorneo.Name = "pkidtorneo";
            this.pkidtorneo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre Torneo";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // temporada
            // 
            this.temporada.DataPropertyName = "temporada";
            this.temporada.HeaderText = "Temporada";
            this.temporada.MinimumWidth = 6;
            this.temporada.Name = "temporada";
            this.temporada.ReadOnly = true;
            // 
            // fechainicio
            // 
            this.fechainicio.DataPropertyName = "fechainicio";
            this.fechainicio.HeaderText = "Fecha Inicio";
            this.fechainicio.MinimumWidth = 6;
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.ReadOnly = true;
            // 
            // fechafin
            // 
            this.fechafin.DataPropertyName = "fechafin";
            this.fechafin.HeaderText = "Fecha Fin";
            this.fechafin.MinimumWidth = 6;
            this.fechafin.Name = "fechafin";
            this.fechafin.ReadOnly = true;
            // 
            // fkiddeporte
            // 
            this.fkiddeporte.DataPropertyName = "fkiddeporte";
            this.fkiddeporte.HeaderText = "Deporte";
            this.fkiddeporte.MinimumWidth = 6;
            this.fkiddeporte.Name = "fkiddeporte";
            this.fkiddeporte.ReadOnly = true;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(221, 264);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerFechaInicio.TabIndex = 228;
            // 
            // dateTimePickerFechafin
            // 
            this.dateTimePickerFechafin.Location = new System.Drawing.Point(221, 297);
            this.dateTimePickerFechafin.Name = "dateTimePickerFechafin";
            this.dateTimePickerFechafin.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerFechafin.TabIndex = 229;
            // 
            // CmbDeporte
            // 
            this.CmbDeporte.FormattingEnabled = true;
            this.CmbDeporte.Location = new System.Drawing.Point(221, 339);
            this.CmbDeporte.Name = "CmbDeporte";
            this.CmbDeporte.Size = new System.Drawing.Size(121, 24);
            this.CmbDeporte.TabIndex = 230;
            this.CmbDeporte.SelectedIndexChanged += new System.EventHandler(this.CmbDeporte_SelectedIndexChanged);
            // 
            // FormTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 653);
            this.Controls.Add(this.CmbDeporte);
            this.Controls.Add(this.dateTimePickerFechafin);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.TxtTemporada);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblBeisbol);
            this.Controls.Add(this.GridVer);
            this.Name = "FormTorneo";
            this.Text = "FormTorneo";
            this.Load += new System.EventHandler(this.FormTorneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTemporada;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblBeisbol;
        private System.Windows.Forms.DataGridView GridVer;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechafin;
        private System.Windows.Forms.ComboBox CmbDeporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidtorneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkiddeporte;
    }
}