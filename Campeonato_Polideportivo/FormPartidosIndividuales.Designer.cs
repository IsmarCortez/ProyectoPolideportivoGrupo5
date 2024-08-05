
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
            this.pkidsesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkdeportistalocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkdeportistavisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkidtorneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbLocal = new System.Windows.Forms.ComboBox();
            this.CmbVis = new System.Windows.Forms.ComboBox();
            this.CmbTorneo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridVer)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(132, 166);
            this.TxtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(129, 20);
            this.TxtId.TabIndex = 246;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 238;
            this.label3.Text = "ID_Torneo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 237;
            this.label2.Text = "Deportista Visitante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 236;
            this.label9.Text = "ID_Sesion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 235;
            this.label1.Text = "Deportista Local";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEliminar.Location = new System.Drawing.Point(615, 416);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 33);
            this.BtnEliminar.TabIndex = 234;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnModificar.Location = new System.Drawing.Point(446, 416);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 33);
            this.BtnModificar.TabIndex = 233;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnVer.Location = new System.Drawing.Point(265, 416);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(130, 33);
            this.BtnVer.TabIndex = 232;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnIngresar.Location = new System.Drawing.Point(108, 416);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(130, 33);
            this.BtnIngresar.TabIndex = 231;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblBeisbol
            // 
            this.LblBeisbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblBeisbol.AutoSize = true;
            this.LblBeisbol.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBeisbol.Location = new System.Drawing.Point(358, 50);
            this.LblBeisbol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBeisbol.Name = "LblBeisbol";
            this.LblBeisbol.Size = new System.Drawing.Size(310, 40);
            this.LblBeisbol.TabIndex = 229;
            this.LblBeisbol.Text = "PARTIDOS INDIVIDUALES";
            // 
            // GridVer
            // 
            this.GridVer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidsesion,
            this.fkdeportistalocal,
            this.fkdeportistavisitante,
            this.fkidtorneo});
            this.GridVer.Location = new System.Drawing.Point(265, 128);
            this.GridVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridVer.Name = "GridVer";
            this.GridVer.RowHeadersWidth = 51;
            this.GridVer.RowTemplate.Height = 24;
            this.GridVer.Size = new System.Drawing.Size(480, 273);
            this.GridVer.TabIndex = 228;
            this.GridVer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVer_CellContentClick);
            // 
            // pkidsesion
            // 
            this.pkidsesion.DataPropertyName = "pkidsesion";
            this.pkidsesion.HeaderText = "ID_Sesion";
            this.pkidsesion.MinimumWidth = 6;
            this.pkidsesion.Name = "pkidsesion";
            // 
            // fkdeportistalocal
            // 
            this.fkdeportistalocal.DataPropertyName = "fkdeportistalocal";
            this.fkdeportistalocal.HeaderText = "Deportista Local";
            this.fkdeportistalocal.MinimumWidth = 6;
            this.fkdeportistalocal.Name = "fkdeportistalocal";
            // 
            // fkdeportistavisitante
            // 
            this.fkdeportistavisitante.DataPropertyName = "fkdeportistavisitante";
            this.fkdeportistavisitante.HeaderText = "Deportista Visitante";
            this.fkdeportistavisitante.MinimumWidth = 6;
            this.fkdeportistavisitante.Name = "fkdeportistavisitante";
            // 
            // fkidtorneo
            // 
            this.fkidtorneo.DataPropertyName = "fkidtorneo";
            this.fkidtorneo.HeaderText = "ID_Torneo";
            this.fkidtorneo.MinimumWidth = 6;
            this.fkidtorneo.Name = "fkidtorneo";
            // 
            // CmbLocal
            // 
            this.CmbLocal.FormattingEnabled = true;
            this.CmbLocal.Location = new System.Drawing.Point(132, 193);
            this.CmbLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbLocal.Name = "CmbLocal";
            this.CmbLocal.Size = new System.Drawing.Size(129, 21);
            this.CmbLocal.TabIndex = 250;
            // 
            // CmbVis
            // 
            this.CmbVis.FormattingEnabled = true;
            this.CmbVis.Location = new System.Drawing.Point(132, 219);
            this.CmbVis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbVis.Name = "CmbVis";
            this.CmbVis.Size = new System.Drawing.Size(129, 21);
            this.CmbVis.TabIndex = 251;
            // 
            // CmbTorneo
            // 
            this.CmbTorneo.FormattingEnabled = true;
            this.CmbTorneo.Location = new System.Drawing.Point(132, 250);
            this.CmbTorneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbTorneo.Name = "CmbTorneo";
            this.CmbTorneo.Size = new System.Drawing.Size(129, 21);
            this.CmbTorneo.TabIndex = 252;
            // 
            // FormPartidosIndividuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 531);
            this.Controls.Add(this.CmbTorneo);
            this.Controls.Add(this.CmbVis);
            this.Controls.Add(this.CmbLocal);
            this.Controls.Add(this.TxtId);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPartidosIndividuales";
            this.Text = "FormPartidosIndividuales";
            this.Load += new System.EventHandler(this.FormPartidosIndividuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtId;
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
        private System.Windows.Forms.ComboBox CmbLocal;
        private System.Windows.Forms.ComboBox CmbVis;
        private System.Windows.Forms.ComboBox CmbTorneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidsesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkdeportistalocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkdeportistavisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkidtorneo;
    }
}