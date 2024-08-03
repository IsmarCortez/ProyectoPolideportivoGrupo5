
namespace Campeonato_Polideportivo
{
    partial class FormAsistencia
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
            this.CmbJugador = new System.Windows.Forms.ComboBox();
            this.LblAsistencia = new System.Windows.Forms.Label();
            this.DgvAsistencia = new System.Windows.Forms.DataGridView();
            this.BtnVer = new System.Windows.Forms.Button();
            this.TxtIdAsistencia = new System.Windows.Forms.TextBox();
            this.LblIdAsistencia = new System.Windows.Forms.Label();
            this.TxtMinuto = new System.Windows.Forms.TextBox();
            this.LblMinuto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsistencia)).BeginInit();
            this.SuspendLayout();
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
            this.BtnEliminar.Location = new System.Drawing.Point(574, 470);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 33);
            this.BtnEliminar.TabIndex = 55;
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
            this.BtnModificar.Location = new System.Drawing.Point(409, 470);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 33);
            this.BtnModificar.TabIndex = 54;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.BtnIngresar.Location = new System.Drawing.Point(252, 470);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(130, 33);
            this.BtnIngresar.TabIndex = 53;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // CmbEquipo
            // 
            this.CmbEquipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbEquipo.FormattingEnabled = true;
            this.CmbEquipo.Location = new System.Drawing.Point(252, 106);
            this.CmbEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.CmbEquipo.Name = "CmbEquipo";
            this.CmbEquipo.Size = new System.Drawing.Size(287, 21);
            this.CmbEquipo.TabIndex = 52;
            this.CmbEquipo.Text = "Selecciona un equipo...";
            this.CmbEquipo.SelectedIndexChanged += new System.EventHandler(this.CmbEquipo_SelectedIndexChanged);
            // 
            // CmbJugador
            // 
<<<<<<< HEAD
            this.CmbJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbJugador.FormattingEnabled = true;
            this.CmbJugador.Location = new System.Drawing.Point(252, 148);
            this.CmbJugador.Margin = new System.Windows.Forms.Padding(2);
            this.CmbJugador.Name = "CmbJugador";
            this.CmbJugador.Size = new System.Drawing.Size(287, 21);
            this.CmbJugador.TabIndex = 51;
            this.CmbJugador.Text = "Selecciona un jugador...";
=======
            this.CmbJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmbJugador.FormattingEnabled = true;
            this.CmbJugador.Location = new System.Drawing.Point(304, 143);
            this.CmbJugador.Name = "CmbJugador";
            this.CmbJugador.Size = new System.Drawing.Size(381, 24);
            this.CmbJugador.TabIndex = 51;
            this.CmbJugador.Text = "Selecciona un deporte...";
            this.CmbJugador.SelectedIndexChanged += new System.EventHandler(this.CmbJugador_SelectedIndexChanged);
>>>>>>> 9726fba8a8f9896ab163378b34db0ee10eb1d4db
            // 
            // LblAsistencia
            // 
            this.LblAsistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAsistencia.AutoSize = true;
            this.LblAsistencia.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsistencia.Location = new System.Drawing.Point(297, 42);
            this.LblAsistencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAsistencia.Name = "LblAsistencia";
            this.LblAsistencia.Size = new System.Drawing.Size(160, 40);
            this.LblAsistencia.TabIndex = 50;
            this.LblAsistencia.Text = "ASISTENCIA";
            // 
            // DgvAsistencia
            // 
<<<<<<< HEAD
            this.DgvAsistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsistencia.Location = new System.Drawing.Point(252, 188);
            this.DgvAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.DgvAsistencia.Name = "DgvAsistencia";
            this.DgvAsistencia.RowHeadersWidth = 51;
            this.DgvAsistencia.RowTemplate.Height = 24;
            this.DgvAsistencia.Size = new System.Drawing.Size(452, 168);
            this.DgvAsistencia.TabIndex = 49;
            this.DgvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAsistencia_CellContentClick);
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
            this.BtnVer.Location = new System.Drawing.Point(102, 470);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(130, 33);
            this.BtnVer.TabIndex = 56;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // TxtIdAsistencia
            // 
            this.TxtIdAsistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtIdAsistencia.Location = new System.Drawing.Point(132, 234);
            this.TxtIdAsistencia.Name = "TxtIdAsistencia";
            this.TxtIdAsistencia.Size = new System.Drawing.Size(100, 20);
            this.TxtIdAsistencia.TabIndex = 57;
            this.TxtIdAsistencia.TextChanged += new System.EventHandler(this.TxtIdAsistencia_TextChanged);
            // 
            // LblIdAsistencia
            // 
            this.LblIdAsistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblIdAsistencia.AutoSize = true;
            this.LblIdAsistencia.Location = new System.Drawing.Point(31, 234);
            this.LblIdAsistencia.Name = "LblIdAsistencia";
            this.LblIdAsistencia.Size = new System.Drawing.Size(68, 13);
            this.LblIdAsistencia.TabIndex = 58;
            this.LblIdAsistencia.Text = "ID asistencia";
            // 
            // TxtMinuto
            // 
            this.TxtMinuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMinuto.Location = new System.Drawing.Point(132, 301);
            this.TxtMinuto.Name = "TxtMinuto";
            this.TxtMinuto.Size = new System.Drawing.Size(100, 20);
            this.TxtMinuto.TabIndex = 59;
            // 
            // LblMinuto
            // 
            this.LblMinuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMinuto.AutoSize = true;
            this.LblMinuto.Location = new System.Drawing.Point(31, 304);
            this.LblMinuto.Name = "LblMinuto";
            this.LblMinuto.Size = new System.Drawing.Size(39, 13);
            this.LblMinuto.TabIndex = 60;
            this.LblMinuto.Text = "Minuto";
=======
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 293);
            this.dataGridView1.TabIndex = 49;
>>>>>>> 9726fba8a8f9896ab163378b34db0ee10eb1d4db
            // 
            // FormAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 531);
            this.Controls.Add(this.LblMinuto);
            this.Controls.Add(this.TxtMinuto);
            this.Controls.Add(this.LblIdAsistencia);
            this.Controls.Add(this.TxtIdAsistencia);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.CmbEquipo);
            this.Controls.Add(this.CmbJugador);
            this.Controls.Add(this.LblAsistencia);
            this.Controls.Add(this.DgvAsistencia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAsistencia";
            this.Text = "FormAsistencia";
            this.Load += new System.EventHandler(this.FormAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.ComboBox CmbEquipo;
        private System.Windows.Forms.ComboBox CmbJugador;
        private System.Windows.Forms.Label LblAsistencia;
        private System.Windows.Forms.DataGridView DgvAsistencia;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.TextBox TxtIdAsistencia;
        private System.Windows.Forms.Label LblIdAsistencia;
        private System.Windows.Forms.TextBox TxtMinuto;
        private System.Windows.Forms.Label LblMinuto;
    }
}