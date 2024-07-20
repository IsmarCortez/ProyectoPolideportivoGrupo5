
namespace Campeonato_Polideportivo
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.BtnModificacion = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblCampeonatos = new System.Windows.Forms.Label();
            this.CmbDeporte = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngreso.Location = new System.Drawing.Point(151, 526);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(174, 27);
            this.BtnIngreso.TabIndex = 1;
            this.BtnIngreso.Text = "Ingreso";
            this.BtnIngreso.UseVisualStyleBackColor = true;
            // 
            // BtnModificacion
            // 
            this.BtnModificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificacion.Location = new System.Drawing.Point(399, 526);
            this.BtnModificacion.Name = "BtnModificacion";
            this.BtnModificacion.Size = new System.Drawing.Size(174, 27);
            this.BtnModificacion.TabIndex = 2;
            this.BtnModificacion.Text = "Modificacion";
            this.BtnModificacion.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.Location = new System.Drawing.Point(651, 526);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(174, 27);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(42, 31);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(51, 27);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // LblCampeonatos
            // 
            this.LblCampeonatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCampeonatos.AutoSize = true;
            this.LblCampeonatos.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampeonatos.Location = new System.Drawing.Point(376, 31);
            this.LblCampeonatos.Name = "LblCampeonatos";
            this.LblCampeonatos.Size = new System.Drawing.Size(246, 48);
            this.LblCampeonatos.TabIndex = 5;
            this.LblCampeonatos.Text = "Campeonatos";
            // 
            // CmbDeporte
            // 
            this.CmbDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmbDeporte.FormattingEnabled = true;
            this.CmbDeporte.Location = new System.Drawing.Point(313, 103);
            this.CmbDeporte.Name = "CmbDeporte";
            this.CmbDeporte.Size = new System.Drawing.Size(381, 24);
            this.CmbDeporte.TabIndex = 6;
            this.CmbDeporte.Text = "Selecciona un deporte...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(995, 653);
            this.Controls.Add(this.CmbDeporte);
            this.Controls.Add(this.LblCampeonatos);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificacion);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.Button BtnModificacion;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblCampeonatos;
        private System.Windows.Forms.ComboBox CmbDeporte;
    }
}