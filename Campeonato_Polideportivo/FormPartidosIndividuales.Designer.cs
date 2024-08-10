
namespace Campeonato_Polideportivo
{
    partial class FormPartidosIndividuales
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
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblIDTorneo = new System.Windows.Forms.Label();
            this.LblDeportistaVisitante = new System.Windows.Forms.Label();
            this.LblIDSesion = new System.Windows.Forms.Label();
            this.LblDeportistaLocal = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblPartidosIndividual = new System.Windows.Forms.Label();
            this.DgvPartidosIndividuales = new System.Windows.Forms.DataGridView();
            this.CmbLocal = new System.Windows.Forms.ComboBox();
            this.CmbVis = new System.Windows.Forms.ComboBox();
            this.CmbTorneo = new System.Windows.Forms.ComboBox();
            this.BtnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPartidosIndividuales)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(176, 204);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(171, 22);
            this.TxtId.TabIndex = 246;
            this.TxtId.Visible = false;
            // 
            // LblIDTorneo
            // 
            this.LblIDTorneo.AutoSize = true;
            this.LblIDTorneo.Location = new System.Drawing.Point(29, 308);
            this.LblIDTorneo.Name = "LblIDTorneo";
            this.LblIDTorneo.Size = new System.Drawing.Size(71, 16);
            this.LblIDTorneo.TabIndex = 238;
            this.LblIDTorneo.Text = "ID_Torneo";
            // 
            // LblDeportistaVisitante
            // 
            this.LblDeportistaVisitante.AutoSize = true;
            this.LblDeportistaVisitante.Location = new System.Drawing.Point(29, 272);
            this.LblDeportistaVisitante.Name = "LblDeportistaVisitante";
            this.LblDeportistaVisitante.Size = new System.Drawing.Size(123, 16);
            this.LblDeportistaVisitante.TabIndex = 237;
            this.LblDeportistaVisitante.Text = "Deportista Visitante";
            // 
            // LblIDSesion
            // 
            this.LblIDSesion.AutoSize = true;
            this.LblIDSesion.Location = new System.Drawing.Point(29, 207);
            this.LblIDSesion.Name = "LblIDSesion";
            this.LblIDSesion.Size = new System.Drawing.Size(69, 16);
            this.LblIDSesion.TabIndex = 236;
            this.LblIDSesion.Text = "ID_Sesion";
            this.LblIDSesion.Visible = false;
            // 
            // LblDeportistaLocal
            // 
            this.LblDeportistaLocal.AutoSize = true;
            this.LblDeportistaLocal.Location = new System.Drawing.Point(29, 241);
            this.LblDeportistaLocal.Name = "LblDeportistaLocal";
            this.LblDeportistaLocal.Size = new System.Drawing.Size(105, 16);
            this.LblDeportistaLocal.TabIndex = 235;
            this.LblDeportistaLocal.Text = "Deportista Local";
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
            this.BtnEliminar.Location = new System.Drawing.Point(820, 512);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(173, 41);
            this.BtnEliminar.TabIndex = 234;
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
            this.BtnModificar.Location = new System.Drawing.Point(595, 512);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(173, 41);
            this.BtnModificar.TabIndex = 233;
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
            this.BtnVer.Location = new System.Drawing.Point(353, 512);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(173, 41);
            this.BtnVer.TabIndex = 232;
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
            this.BtnIngresar.Location = new System.Drawing.Point(144, 512);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(173, 41);
            this.BtnIngresar.TabIndex = 231;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblPartidosIndividual
            // 
            this.LblPartidosIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblPartidosIndividual.AutoSize = true;
            this.LblPartidosIndividual.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartidosIndividual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblPartidosIndividual.Location = new System.Drawing.Point(477, 62);
            this.LblPartidosIndividual.Name = "LblPartidosIndividual";
            this.LblPartidosIndividual.Size = new System.Drawing.Size(377, 50);
            this.LblPartidosIndividual.TabIndex = 229;
            this.LblPartidosIndividual.Text = "PARTIDOS INDIVIDUALES";
            // 
            // DgvPartidosIndividuales
            // 
            this.DgvPartidosIndividuales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPartidosIndividuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPartidosIndividuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPartidosIndividuales.Location = new System.Drawing.Point(353, 158);
            this.DgvPartidosIndividuales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvPartidosIndividuales.Name = "DgvPartidosIndividuales";
            this.DgvPartidosIndividuales.RowHeadersWidth = 51;
            this.DgvPartidosIndividuales.RowTemplate.Height = 24;
            this.DgvPartidosIndividuales.Size = new System.Drawing.Size(640, 336);
            this.DgvPartidosIndividuales.TabIndex = 228;
            this.DgvPartidosIndividuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVer_CellContentClick);
            // 
            // CmbLocal
            // 
            this.CmbLocal.FormattingEnabled = true;
            this.CmbLocal.Location = new System.Drawing.Point(176, 238);
            this.CmbLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbLocal.Name = "CmbLocal";
            this.CmbLocal.Size = new System.Drawing.Size(171, 24);
            this.CmbLocal.TabIndex = 250;
            // 
            // CmbVis
            // 
            this.CmbVis.FormattingEnabled = true;
            this.CmbVis.Location = new System.Drawing.Point(176, 270);
            this.CmbVis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbVis.Name = "CmbVis";
            this.CmbVis.Size = new System.Drawing.Size(171, 24);
            this.CmbVis.TabIndex = 251;
            // 
            // CmbTorneo
            // 
            this.CmbTorneo.FormattingEnabled = true;
            this.CmbTorneo.Location = new System.Drawing.Point(176, 308);
            this.CmbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTorneo.Name = "CmbTorneo";
            this.CmbTorneo.Size = new System.Drawing.Size(171, 24);
            this.CmbTorneo.TabIndex = 252;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Haettenschweiler", 16.2F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnAyuda.Location = new System.Drawing.Point(948, 62);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(45, 33);
            this.BtnAyuda.TabIndex = 330;
            this.BtnAyuda.Text = "?";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FormPartidosIndividuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 654);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.CmbTorneo);
            this.Controls.Add(this.CmbVis);
            this.Controls.Add(this.CmbLocal);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblIDTorneo);
            this.Controls.Add(this.LblDeportistaVisitante);
            this.Controls.Add(this.LblIDSesion);
            this.Controls.Add(this.LblDeportistaLocal);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblPartidosIndividual);
            this.Controls.Add(this.DgvPartidosIndividuales);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPartidosIndividuales";
            this.Text = "FormPartidosIndividuales";
            this.Load += new System.EventHandler(this.FormPartidosIndividuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPartidosIndividuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblIDTorneo;
        private System.Windows.Forms.Label LblDeportistaVisitante;
        private System.Windows.Forms.Label LblIDSesion;
        private System.Windows.Forms.Label LblDeportistaLocal;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblPartidosIndividual;
        private System.Windows.Forms.DataGridView DgvPartidosIndividuales;
        private System.Windows.Forms.ComboBox CmbLocal;
        private System.Windows.Forms.ComboBox CmbVis;
        private System.Windows.Forms.ComboBox CmbTorneo;
        private System.Windows.Forms.Button BtnAyuda;
    }
}