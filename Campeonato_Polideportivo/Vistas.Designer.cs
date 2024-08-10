
namespace Campeonato_Polideportivo
{
    partial class Vistas
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
            this.DgvVistas = new System.Windows.Forms.DataGridView();
            this.LblVistas = new System.Windows.Forms.Label();
            this.BtnEquipos = new System.Windows.Forms.Button();
            this.BtnJugador = new System.Windows.Forms.Button();
            this.BtnFutbol = new System.Windows.Forms.Button();
            this.BtnBasket = new System.Windows.Forms.Button();
            this.BtnBaseball = new System.Windows.Forms.Button();
            this.BtnVoleybol = new System.Windows.Forms.Button();
            this.BtnSuspendido = new System.Windows.Forms.Button();
            this.BtnPerJugador = new System.Windows.Forms.Button();
            this.BtnPdf = new System.Windows.Forms.Button();
            this.BtnBitacora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVistas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVistas
            // 
            this.DgvVistas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvVistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVistas.Location = new System.Drawing.Point(13, 207);
            this.DgvVistas.Name = "DgvVistas";
            this.DgvVistas.RowHeadersWidth = 51;
            this.DgvVistas.Size = new System.Drawing.Size(721, 198);
            this.DgvVistas.TabIndex = 0;
            // 
            // LblVistas
            // 
            this.LblVistas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblVistas.AutoSize = true;
            this.LblVistas.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVistas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblVistas.Location = new System.Drawing.Point(250, 38);
            this.LblVistas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblVistas.Name = "LblVistas";
            this.LblVistas.Size = new System.Drawing.Size(259, 40);
            this.LblVistas.TabIndex = 176;
            this.LblVistas.Text = "VISTAS Y REPORTES";
            // 
            // BtnEquipos
            // 
            this.BtnEquipos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnEquipos.FlatAppearance.BorderSize = 0;
            this.BtnEquipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipos.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEquipos.Location = new System.Drawing.Point(13, 114);
            this.BtnEquipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEquipos.Name = "BtnEquipos";
            this.BtnEquipos.Size = new System.Drawing.Size(198, 33);
            this.BtnEquipos.TabIndex = 178;
            this.BtnEquipos.Text = "EQUIPOS POR CAMPEONATO";
            this.BtnEquipos.UseVisualStyleBackColor = false;
            this.BtnEquipos.Click += new System.EventHandler(this.BtnEquipos_Click);
            // 
            // BtnJugador
            // 
            this.BtnJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnJugador.FlatAppearance.BorderSize = 0;
            this.BtnJugador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnJugador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJugador.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnJugador.Location = new System.Drawing.Point(257, 114);
            this.BtnJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnJugador.Name = "BtnJugador";
            this.BtnJugador.Size = new System.Drawing.Size(198, 33);
            this.BtnJugador.TabIndex = 179;
            this.BtnJugador.Text = "JUGADOR POR EQUIPO";
            this.BtnJugador.UseVisualStyleBackColor = false;
            this.BtnJugador.Click += new System.EventHandler(this.BtnJugador_Click);
            // 
            // BtnFutbol
            // 
            this.BtnFutbol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFutbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnFutbol.FlatAppearance.BorderSize = 0;
            this.BtnFutbol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnFutbol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnFutbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFutbol.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFutbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnFutbol.Location = new System.Drawing.Point(13, 425);
            this.BtnFutbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnFutbol.Name = "BtnFutbol";
            this.BtnFutbol.Size = new System.Drawing.Size(160, 33);
            this.BtnFutbol.TabIndex = 180;
            this.BtnFutbol.Text = "PARTIDOS FUTBOL";
            this.BtnFutbol.UseVisualStyleBackColor = false;
            this.BtnFutbol.Click += new System.EventHandler(this.BtnFutbol_Click);
            // 
            // BtnBasket
            // 
            this.BtnBasket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnBasket.FlatAppearance.BorderSize = 0;
            this.BtnBasket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnBasket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBasket.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBasket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnBasket.Location = new System.Drawing.Point(196, 425);
            this.BtnBasket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBasket.Name = "BtnBasket";
            this.BtnBasket.Size = new System.Drawing.Size(160, 33);
            this.BtnBasket.TabIndex = 181;
            this.BtnBasket.Text = "PARTIDOS BASKETBOL";
            this.BtnBasket.UseVisualStyleBackColor = false;
            this.BtnBasket.Click += new System.EventHandler(this.BtnBasket_Click);
            // 
            // BtnBaseball
            // 
            this.BtnBaseball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBaseball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnBaseball.FlatAppearance.BorderSize = 0;
            this.BtnBaseball.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnBaseball.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBaseball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaseball.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaseball.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnBaseball.Location = new System.Drawing.Point(387, 425);
            this.BtnBaseball.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBaseball.Name = "BtnBaseball";
            this.BtnBaseball.Size = new System.Drawing.Size(160, 33);
            this.BtnBaseball.TabIndex = 182;
            this.BtnBaseball.Text = "PARTIDOS BASEBOL";
            this.BtnBaseball.UseVisualStyleBackColor = false;
            this.BtnBaseball.Click += new System.EventHandler(this.BtnBaseball_Click);
            // 
            // BtnVoleybol
            // 
            this.BtnVoleybol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVoleybol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnVoleybol.FlatAppearance.BorderSize = 0;
            this.BtnVoleybol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnVoleybol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVoleybol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoleybol.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoleybol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnVoleybol.Location = new System.Drawing.Point(574, 425);
            this.BtnVoleybol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVoleybol.Name = "BtnVoleybol";
            this.BtnVoleybol.Size = new System.Drawing.Size(160, 33);
            this.BtnVoleybol.TabIndex = 183;
            this.BtnVoleybol.Text = "PARTIDOS VOLEYBOL";
            this.BtnVoleybol.UseVisualStyleBackColor = false;
            this.BtnVoleybol.Click += new System.EventHandler(this.BtnVoleybol_Click);
            // 
            // BtnSuspendido
            // 
            this.BtnSuspendido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSuspendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnSuspendido.FlatAppearance.BorderSize = 0;
            this.BtnSuspendido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnSuspendido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSuspendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuspendido.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuspendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnSuspendido.Location = new System.Drawing.Point(536, 114);
            this.BtnSuspendido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSuspendido.Name = "BtnSuspendido";
            this.BtnSuspendido.Size = new System.Drawing.Size(198, 33);
            this.BtnSuspendido.TabIndex = 184;
            this.BtnSuspendido.Text = "JUGADORES SUSPENDIDOS";
            this.BtnSuspendido.UseVisualStyleBackColor = false;
            this.BtnSuspendido.Click += new System.EventHandler(this.BtnSuspendido_Click);
            // 
            // BtnPerJugador
            // 
            this.BtnPerJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPerJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnPerJugador.FlatAppearance.BorderSize = 0;
            this.BtnPerJugador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnPerJugador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPerJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPerJugador.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPerJugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnPerJugador.Location = new System.Drawing.Point(257, 160);
            this.BtnPerJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPerJugador.Name = "BtnPerJugador";
            this.BtnPerJugador.Size = new System.Drawing.Size(198, 33);
            this.BtnPerJugador.TabIndex = 185;
            this.BtnPerJugador.Text = "DATOS JUGADOR";
            this.BtnPerJugador.UseVisualStyleBackColor = false;
            this.BtnPerJugador.Click += new System.EventHandler(this.BtnPerJugador_Click);
            // 
            // BtnPdf
            // 
            this.BtnPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnPdf.FlatAppearance.BorderSize = 0;
            this.BtnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPdf.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnPdf.Location = new System.Drawing.Point(534, 160);
            this.BtnPdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPdf.Name = "BtnPdf";
            this.BtnPdf.Size = new System.Drawing.Size(198, 33);
            this.BtnPdf.TabIndex = 186;
            this.BtnPdf.Text = "PDF";
            this.BtnPdf.UseVisualStyleBackColor = false;
            this.BtnPdf.Click += new System.EventHandler(this.BtnPdf_Click);
            // 
            // BtnBitacora
            // 
            this.BtnBitacora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.BtnBitacora.FlatAppearance.BorderSize = 0;
            this.BtnBitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBitacora.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnBitacora.Location = new System.Drawing.Point(13, 160);
            this.BtnBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBitacora.Name = "BtnBitacora";
            this.BtnBitacora.Size = new System.Drawing.Size(198, 33);
            this.BtnBitacora.TabIndex = 187;
            this.BtnBitacora.Text = "BITACORA";
            this.BtnBitacora.UseVisualStyleBackColor = false;
            this.BtnBitacora.Click += new System.EventHandler(this.BtnBitacora_Click);
            // 
            // Vistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(746, 531);
            this.Controls.Add(this.BtnBitacora);
            this.Controls.Add(this.BtnPdf);
            this.Controls.Add(this.BtnPerJugador);
            this.Controls.Add(this.BtnSuspendido);
            this.Controls.Add(this.BtnVoleybol);
            this.Controls.Add(this.BtnBaseball);
            this.Controls.Add(this.BtnBasket);
            this.Controls.Add(this.BtnFutbol);
            this.Controls.Add(this.BtnJugador);
            this.Controls.Add(this.BtnEquipos);
            this.Controls.Add(this.LblVistas);
            this.Controls.Add(this.DgvVistas);
            this.Name = "Vistas";
            this.Text = "Vistas";
            this.Load += new System.EventHandler(this.Vistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVistas;
        private System.Windows.Forms.Label LblVistas;
        private System.Windows.Forms.Button BtnEquipos;
        private System.Windows.Forms.Button BtnJugador;
        private System.Windows.Forms.Button BtnFutbol;
        private System.Windows.Forms.Button BtnBasket;
        private System.Windows.Forms.Button BtnBaseball;
        private System.Windows.Forms.Button BtnVoleybol;
        private System.Windows.Forms.Button BtnSuspendido;
        private System.Windows.Forms.Button BtnPerJugador;
        private System.Windows.Forms.Button BtnPdf;
        private System.Windows.Forms.Button BtnBitacora;
    }
}