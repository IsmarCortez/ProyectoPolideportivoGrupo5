﻿
namespace Campeonato_Polideportivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.BtnEquipos = new System.Windows.Forms.Button();
            this.BtnCampeonatos = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelEquipos = new System.Windows.Forms.Panel();
            this.BtnEntrenadores = new System.Windows.Forms.Button();
            this.PanelConsultar = new System.Windows.Forms.Panel();
            this.BtnFechas = new System.Windows.Forms.Button();
            this.BtnJugadores = new System.Windows.Forms.Button();
            this.BtnPosiciones = new System.Windows.Forms.Button();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PanelLateral.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelEquipos.SuspendLayout();
            this.PanelConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.AutoScroll = true;
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.PanelLateral.Controls.Add(this.PanelConsultar);
            this.PanelLateral.Controls.Add(this.BtnConsultar);
            this.PanelLateral.Controls.Add(this.BtnEmpleados);
            this.PanelLateral.Controls.Add(this.PanelEquipos);
            this.PanelLateral.Controls.Add(this.BtnEquipos);
            this.PanelLateral.Controls.Add(this.BtnCampeonatos);
            this.PanelLateral.Controls.Add(this.PanelLogo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(187, 653);
            this.PanelLateral.TabIndex = 0;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnConsultar.Location = new System.Drawing.Point(0, 363);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConsultar.Size = new System.Drawing.Size(187, 45);
            this.BtnConsultar.TabIndex = 6;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.button16_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEmpleados.Location = new System.Drawing.Point(0, 318);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEmpleados.Size = new System.Drawing.Size(187, 45);
            this.BtnEmpleados.TabIndex = 4;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnEquipos
            // 
            this.BtnEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEquipos.FlatAppearance.BorderSize = 0;
            this.BtnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnEquipos.Location = new System.Drawing.Point(0, 190);
            this.BtnEquipos.Name = "BtnEquipos";
            this.BtnEquipos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEquipos.Size = new System.Drawing.Size(187, 45);
            this.BtnEquipos.TabIndex = 2;
            this.BtnEquipos.Text = "Equipos";
            this.BtnEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEquipos.UseVisualStyleBackColor = true;
            this.BtnEquipos.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnCampeonatos
            // 
            this.BtnCampeonatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCampeonatos.FlatAppearance.BorderSize = 0;
            this.BtnCampeonatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCampeonatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnCampeonatos.Location = new System.Drawing.Point(0, 145);
            this.BtnCampeonatos.Name = "BtnCampeonatos";
            this.BtnCampeonatos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCampeonatos.Size = new System.Drawing.Size(187, 45);
            this.BtnCampeonatos.TabIndex = 0;
            this.BtnCampeonatos.Text = "Campeonatos";
            this.BtnCampeonatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCampeonatos.UseVisualStyleBackColor = true;
            this.BtnCampeonatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox2);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(187, 145);
            this.PanelLogo.TabIndex = 0;
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.PanelForm.Controls.Add(this.LblTitulo);
            this.PanelForm.Controls.Add(this.pictureBox1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(187, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(995, 653);
            this.PanelForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Campeonato_Polideportivo.Properties.Resources.fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Campeonato_Polideportivo.Properties.Resources.logotipo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PanelEquipos
            // 
            this.PanelEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.PanelEquipos.Controls.Add(this.BtnJugadores);
            this.PanelEquipos.Controls.Add(this.BtnEntrenadores);
            this.PanelEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEquipos.Location = new System.Drawing.Point(0, 235);
            this.PanelEquipos.Name = "PanelEquipos";
            this.PanelEquipos.Size = new System.Drawing.Size(187, 83);
            this.PanelEquipos.TabIndex = 3;
            // 
            // BtnEntrenadores
            // 
            this.BtnEntrenadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnEntrenadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEntrenadores.FlatAppearance.BorderSize = 0;
            this.BtnEntrenadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrenadores.Location = new System.Drawing.Point(0, 0);
            this.BtnEntrenadores.Name = "BtnEntrenadores";
            this.BtnEntrenadores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnEntrenadores.Size = new System.Drawing.Size(187, 40);
            this.BtnEntrenadores.TabIndex = 0;
            this.BtnEntrenadores.Text = "Entrenadores";
            this.BtnEntrenadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntrenadores.UseVisualStyleBackColor = false;
            // 
            // PanelConsultar
            // 
            this.PanelConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.PanelConsultar.Controls.Add(this.BtnEstadisticas);
            this.PanelConsultar.Controls.Add(this.BtnPosiciones);
            this.PanelConsultar.Controls.Add(this.BtnFechas);
            this.PanelConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelConsultar.Location = new System.Drawing.Point(0, 408);
            this.PanelConsultar.Name = "PanelConsultar";
            this.PanelConsultar.Size = new System.Drawing.Size(187, 126);
            this.PanelConsultar.TabIndex = 7;
            // 
            // BtnFechas
            // 
            this.BtnFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnFechas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFechas.FlatAppearance.BorderSize = 0;
            this.BtnFechas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechas.Location = new System.Drawing.Point(0, 0);
            this.BtnFechas.Name = "BtnFechas";
            this.BtnFechas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnFechas.Size = new System.Drawing.Size(187, 40);
            this.BtnFechas.TabIndex = 0;
            this.BtnFechas.Text = "Fechas";
            this.BtnFechas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFechas.UseVisualStyleBackColor = false;
            // 
            // BtnJugadores
            // 
            this.BtnJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJugadores.FlatAppearance.BorderSize = 0;
            this.BtnJugadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJugadores.Location = new System.Drawing.Point(0, 40);
            this.BtnJugadores.Name = "BtnJugadores";
            this.BtnJugadores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnJugadores.Size = new System.Drawing.Size(187, 43);
            this.BtnJugadores.TabIndex = 1;
            this.BtnJugadores.Text = "Jugadores";
            this.BtnJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJugadores.UseVisualStyleBackColor = false;
            // 
            // BtnPosiciones
            // 
            this.BtnPosiciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnPosiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPosiciones.FlatAppearance.BorderSize = 0;
            this.BtnPosiciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnPosiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPosiciones.Location = new System.Drawing.Point(0, 40);
            this.BtnPosiciones.Name = "BtnPosiciones";
            this.BtnPosiciones.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnPosiciones.Size = new System.Drawing.Size(187, 40);
            this.BtnPosiciones.TabIndex = 1;
            this.BtnPosiciones.Text = "Posiciones";
            this.BtnPosiciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPosiciones.UseVisualStyleBackColor = false;
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BtnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstadisticas.FlatAppearance.BorderSize = 0;
            this.BtnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadisticas.Location = new System.Drawing.Point(0, 80);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnEstadisticas.Size = new System.Drawing.Size(187, 40);
            this.BtnEstadisticas.TabIndex = 2;
            this.BtnEstadisticas.Text = "Estadisticas";
            this.BtnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstadisticas.UseVisualStyleBackColor = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.LightGray;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(336, 35);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(348, 41);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Campeonato Deportivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLateral.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelEquipos.ResumeLayout(false);
            this.PanelConsultar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button BtnCampeonatos;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnEquipos;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelEquipos;
        private System.Windows.Forms.Button BtnEntrenadores;
        private System.Windows.Forms.Panel PanelConsultar;
        private System.Windows.Forms.Button BtnFechas;
        private System.Windows.Forms.Button BtnJugadores;
        private System.Windows.Forms.Button BtnEstadisticas;
        private System.Windows.Forms.Button BtnPosiciones;
        private System.Windows.Forms.Label LblTitulo;
    }
}

