
namespace Campeonato_Polideportivo
{
    partial class Form3
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
            this.button4 = new System.Windows.Forms.Button();
            this.CmbDeporte = new System.Windows.Forms.ComboBox();
            this.LblEquipos = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificacion = new System.Windows.Forms.Button();
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbEquipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CmbDeporte
            // 
            this.CmbDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmbDeporte.FormattingEnabled = true;
            this.CmbDeporte.Location = new System.Drawing.Point(295, 108);
            this.CmbDeporte.Name = "CmbDeporte";
            this.CmbDeporte.Size = new System.Drawing.Size(381, 24);
            this.CmbDeporte.TabIndex = 16;
            this.CmbDeporte.Text = "Selecciona un deporte...";
            // 
            // LblEquipos
            // 
            this.LblEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblEquipos.AutoSize = true;
            this.LblEquipos.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEquipos.Location = new System.Drawing.Point(425, 36);
            this.LblEquipos.Name = "LblEquipos";
            this.LblEquipos.Size = new System.Drawing.Size(150, 48);
            this.LblEquipos.TabIndex = 15;
            this.LblEquipos.Text = "Equipos";
            this.LblEquipos.Click += new System.EventHandler(this.LblCampeonatos_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.Location = new System.Drawing.Point(665, 529);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(174, 27);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificacion
            // 
            this.BtnModificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificacion.Location = new System.Drawing.Point(405, 529);
            this.BtnModificacion.Name = "BtnModificacion";
            this.BtnModificacion.Size = new System.Drawing.Size(174, 27);
            this.BtnModificacion.TabIndex = 12;
            this.BtnModificacion.Text = "Modificacion";
            this.BtnModificacion.UseVisualStyleBackColor = true;
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngreso.Location = new System.Drawing.Point(150, 529);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(174, 27);
            this.BtnIngreso.TabIndex = 11;
            this.BtnIngreso.Text = "Ingreso";
            this.BtnIngreso.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 315);
            this.dataGridView1.TabIndex = 10;
            // 
            // CmbEquipo
            // 
            this.CmbEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmbEquipo.FormattingEnabled = true;
            this.CmbEquipo.Location = new System.Drawing.Point(295, 138);
            this.CmbEquipo.Name = "CmbEquipo";
            this.CmbEquipo.Size = new System.Drawing.Size(381, 24);
            this.CmbEquipo.TabIndex = 17;
            this.CmbEquipo.Text = "Selecciona un equipo...";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(995, 653);
            this.Controls.Add(this.CmbEquipo);
            this.Controls.Add(this.CmbDeporte);
            this.Controls.Add(this.LblEquipos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificacion);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox CmbDeporte;
        private System.Windows.Forms.Label LblEquipos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificacion;
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbEquipo;
    }
}