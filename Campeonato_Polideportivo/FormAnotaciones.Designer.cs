﻿
namespace Campeonato_Polideportivo
{
    partial class FormAnotaciones
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
            this.LblAnotaciones = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblIdAnotaciones = new System.Windows.Forms.Label();
            this.LblMinuto = new System.Windows.Forms.Label();
            this.LblTipodeAnotacion = new System.Windows.Forms.Label();
            this.TxtIdAnotaciones = new System.Windows.Forms.TextBox();
            this.TxtMinuto = new System.Windows.Forms.TextBox();
            this.TxtTipodeAnotacion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblIdPartido = new System.Windows.Forms.Label();
            this.LblJugador = new System.Windows.Forms.Label();
            this.LblAsistencia = new System.Windows.Forms.Label();
            this.TxtIdPartido = new System.Windows.Forms.TextBox();
            this.TxtIdJugador = new System.Windows.Forms.TextBox();
            this.TxtAsistencia = new System.Windows.Forms.TextBox();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(636, 467);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(174, 41);
            this.BtnEliminar.TabIndex = 62;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Location = new System.Drawing.Point(244, 538);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(174, 41);
            this.BtnModificar.TabIndex = 61;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.Black;
            this.BtnIngresar.Location = new System.Drawing.Point(244, 467);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(174, 41);
            this.BtnIngresar.TabIndex = 60;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblAnotaciones
            // 
            this.LblAnotaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblAnotaciones.AutoSize = true;
            this.LblAnotaciones.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnotaciones.ForeColor = System.Drawing.Color.Black;
            this.LblAnotaciones.Location = new System.Drawing.Point(400, 47);
            this.LblAnotaciones.Name = "LblAnotaciones";
            this.LblAnotaciones.Size = new System.Drawing.Size(229, 50);
            this.LblAnotaciones.TabIndex = 57;
            this.LblAnotaciones.Text = "ANOTACIONES";
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
            this.dataGridView1.Location = new System.Drawing.Point(420, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 144);
            this.dataGridView1.TabIndex = 56;
            // 
            // LblIdAnotaciones
            // 
            this.LblIdAnotaciones.AutoSize = true;
            this.LblIdAnotaciones.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdAnotaciones.Location = new System.Drawing.Point(92, 169);
            this.LblIdAnotaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIdAnotaciones.Name = "LblIdAnotaciones";
            this.LblIdAnotaciones.Size = new System.Drawing.Size(109, 20);
            this.LblIdAnotaciones.TabIndex = 63;
            this.LblIdAnotaciones.Text = "Id_anotaciones";
            // 
            // LblMinuto
            // 
            this.LblMinuto.AutoSize = true;
            this.LblMinuto.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinuto.Location = new System.Drawing.Point(92, 209);
            this.LblMinuto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMinuto.Name = "LblMinuto";
            this.LblMinuto.Size = new System.Drawing.Size(52, 20);
            this.LblMinuto.TabIndex = 64;
            this.LblMinuto.Text = "Minuto";
            // 
            // LblTipodeAnotacion
            // 
            this.LblTipodeAnotacion.AutoSize = true;
            this.LblTipodeAnotacion.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipodeAnotacion.Location = new System.Drawing.Point(92, 248);
            this.LblTipodeAnotacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTipodeAnotacion.Name = "LblTipodeAnotacion";
            this.LblTipodeAnotacion.Size = new System.Drawing.Size(122, 20);
            this.LblTipodeAnotacion.TabIndex = 65;
            this.LblTipodeAnotacion.Text = "tipo de anotación";
            // 
            // TxtIdAnotaciones
            // 
            this.TxtIdAnotaciones.Location = new System.Drawing.Point(257, 169);
            this.TxtIdAnotaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtIdAnotaciones.Name = "TxtIdAnotaciones";
            this.TxtIdAnotaciones.Size = new System.Drawing.Size(120, 22);
            this.TxtIdAnotaciones.TabIndex = 66;
            // 
            // TxtMinuto
            // 
            this.TxtMinuto.Location = new System.Drawing.Point(257, 209);
            this.TxtMinuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMinuto.Name = "TxtMinuto";
            this.TxtMinuto.Size = new System.Drawing.Size(120, 22);
            this.TxtMinuto.TabIndex = 67;
            // 
            // TxtTipodeAnotacion
            // 
            this.TxtTipodeAnotacion.Location = new System.Drawing.Point(257, 245);
            this.TxtTipodeAnotacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTipodeAnotacion.Name = "TxtTipodeAnotacion";
            this.TxtTipodeAnotacion.Size = new System.Drawing.Size(120, 22);
            this.TxtTipodeAnotacion.TabIndex = 68;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(92, 407);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(84, 20);
            this.LblDescripcion.TabIndex = 69;
            this.LblDescripcion.Text = "Descripción";
            this.LblDescripcion.Click += new System.EventHandler(this.LblDescripcion_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(257, 407);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(120, 22);
            this.TxtDescripcion.TabIndex = 70;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // LblIdPartido
            // 
            this.LblIdPartido.AutoSize = true;
            this.LblIdPartido.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdPartido.Location = new System.Drawing.Point(92, 288);
            this.LblIdPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIdPartido.Name = "LblIdPartido";
            this.LblIdPartido.Size = new System.Drawing.Size(79, 20);
            this.LblIdPartido.TabIndex = 71;
            this.LblIdPartido.Text = "Id_Partido";
            // 
            // LblJugador
            // 
            this.LblJugador.AutoSize = true;
            this.LblJugador.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJugador.Location = new System.Drawing.Point(92, 323);
            this.LblJugador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblJugador.Name = "LblJugador";
            this.LblJugador.Size = new System.Drawing.Size(82, 20);
            this.LblJugador.TabIndex = 72;
            this.LblJugador.Text = "Id_Jugador";
            // 
            // LblAsistencia
            // 
            this.LblAsistencia.AutoSize = true;
            this.LblAsistencia.Font = new System.Drawing.Font("Bernard MT Condensed", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsistencia.Location = new System.Drawing.Point(92, 363);
            this.LblAsistencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAsistencia.Name = "LblAsistencia";
            this.LblAsistencia.Size = new System.Drawing.Size(95, 20);
            this.LblAsistencia.TabIndex = 73;
            this.LblAsistencia.Text = "Id_Asistencia";
            // 
            // TxtIdPartido
            // 
            this.TxtIdPartido.Location = new System.Drawing.Point(257, 288);
            this.TxtIdPartido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtIdPartido.Name = "TxtIdPartido";
            this.TxtIdPartido.Size = new System.Drawing.Size(120, 22);
            this.TxtIdPartido.TabIndex = 74;
            // 
            // TxtIdJugador
            // 
            this.TxtIdJugador.Location = new System.Drawing.Point(257, 323);
            this.TxtIdJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtIdJugador.Name = "TxtIdJugador";
            this.TxtIdJugador.Size = new System.Drawing.Size(120, 22);
            this.TxtIdJugador.TabIndex = 75;
            // 
            // TxtAsistencia
            // 
            this.TxtAsistencia.Location = new System.Drawing.Point(257, 363);
            this.TxtAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtAsistencia.Name = "TxtAsistencia";
            this.TxtAsistencia.Size = new System.Drawing.Size(120, 22);
            this.TxtAsistencia.TabIndex = 76;
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.BackColor = System.Drawing.Color.LightCyan;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Haettenschweiler", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.Color.Black;
            this.BtnVer.Location = new System.Drawing.Point(452, 495);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(150, 40);
            this.BtnVer.TabIndex = 77;
            this.BtnVer.Text = "Ver ";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(636, 538);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(174, 41);
            this.BtnLimpiar.TabIndex = 78;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FormAnotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1059, 653);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.TxtAsistencia);
            this.Controls.Add(this.TxtIdJugador);
            this.Controls.Add(this.TxtIdPartido);
            this.Controls.Add(this.LblAsistencia);
            this.Controls.Add(this.LblJugador);
            this.Controls.Add(this.LblIdPartido);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtTipodeAnotacion);
            this.Controls.Add(this.TxtMinuto);
            this.Controls.Add(this.TxtIdAnotaciones);
            this.Controls.Add(this.LblTipodeAnotacion);
            this.Controls.Add(this.LblMinuto);
            this.Controls.Add(this.LblIdAnotaciones);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblAnotaciones);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAnotaciones";
            this.Text = "FormAnotaciones";
            this.Load += new System.EventHandler(this.FormAnotaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblAnotaciones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblIdAnotaciones;
        private System.Windows.Forms.Label LblMinuto;
        private System.Windows.Forms.Label LblTipodeAnotacion;
        private System.Windows.Forms.TextBox TxtIdAnotaciones;
        private System.Windows.Forms.TextBox TxtMinuto;
        private System.Windows.Forms.TextBox TxtTipodeAnotacion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblIdPartido;
        private System.Windows.Forms.Label LblJugador;
        private System.Windows.Forms.Label LblAsistencia;
        private System.Windows.Forms.TextBox TxtIdPartido;
        private System.Windows.Forms.TextBox TxtIdJugador;
        private System.Windows.Forms.TextBox TxtAsistencia;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}