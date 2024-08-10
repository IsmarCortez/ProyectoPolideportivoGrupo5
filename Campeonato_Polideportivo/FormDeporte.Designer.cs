
namespace Campeonato_Polideportivo
{
    partial class FormDeporte
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
            this.LblDeportes = new System.Windows.Forms.Label();
            this.DgvDeporte = new System.Windows.Forms.DataGridView();
            this.BtnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeporte)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDeportes
            // 
            this.LblDeportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblDeportes.AutoSize = true;
            this.LblDeportes.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LblDeportes.Location = new System.Drawing.Point(407, 17);
            this.LblDeportes.Name = "LblDeportes";
            this.LblDeportes.Size = new System.Drawing.Size(167, 50);
            this.LblDeportes.TabIndex = 37;
            this.LblDeportes.Text = "DEPORTES";
            // 
            // DgvDeporte
            // 
            this.DgvDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDeporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDeporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDeporte.Location = new System.Drawing.Point(85, 115);
            this.DgvDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvDeporte.Name = "DgvDeporte";
            this.DgvDeporte.RowHeadersWidth = 51;
            this.DgvDeporte.RowTemplate.Height = 24;
            this.DgvDeporte.Size = new System.Drawing.Size(818, 338);
            this.DgvDeporte.TabIndex = 36;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Haettenschweiler", 16.2F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnAyuda.Location = new System.Drawing.Point(468, 534);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAyuda.Name = "BtnAyuda";
<<<<<<< HEAD
            this.BtnAyuda.Size = new System.Drawing.Size(45, 38);
=======
            this.BtnAyuda.Size = new System.Drawing.Size(45, 33);
>>>>>>> 8d353b13ca83f321132d3d10cee8f15da9bbaec0
            this.BtnAyuda.TabIndex = 323;
            this.BtnAyuda.Text = "?";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FormDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(995, 654);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.LblDeportes);
            this.Controls.Add(this.DgvDeporte);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDeporte";
            this.Text = "Ingreso Deporte";
            this.Load += new System.EventHandler(this.FormDeporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblDeportes;
        private System.Windows.Forms.DataGridView DgvDeporte;
        private System.Windows.Forms.Button BtnAyuda;
    }
}