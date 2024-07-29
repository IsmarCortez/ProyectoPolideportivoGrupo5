
namespace Campeonato_Polideportivo
{
    partial class FormEquipo
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
            this.BtnVer = new System.Windows.Forms.Button();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtEstadio = new System.Windows.Forms.TextBox();
            this.TxtNombreEquipo = new System.Windows.Forms.TextBox();
            this.TxtIdEquipo = new System.Windows.Forms.TextBox();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblEstadio = new System.Windows.Forms.Label();
            this.LblNombreEquipo = new System.Windows.Forms.Label();
            this.LblIdEquipo = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblDeportes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Haettenschweiler", 16.2F);
            this.BtnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnVer.Location = new System.Drawing.Point(380, 465);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(174, 41);
            this.BtnVer.TabIndex = 57;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(243, 326);
            this.TxtCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(159, 22);
            this.TxtCiudad.TabIndex = 56;
            // 
            // TxtEstadio
            // 
            this.TxtEstadio.Location = new System.Drawing.Point(243, 293);
            this.TxtEstadio.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEstadio.Name = "TxtEstadio";
            this.TxtEstadio.Size = new System.Drawing.Size(159, 22);
            this.TxtEstadio.TabIndex = 55;
            // 
            // TxtNombreEquipo
            // 
            this.TxtNombreEquipo.Location = new System.Drawing.Point(243, 260);
            this.TxtNombreEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreEquipo.Name = "TxtNombreEquipo";
            this.TxtNombreEquipo.Size = new System.Drawing.Size(159, 22);
            this.TxtNombreEquipo.TabIndex = 54;
            // 
            // TxtIdEquipo
            // 
            this.TxtIdEquipo.Location = new System.Drawing.Point(243, 229);
            this.TxtIdEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdEquipo.Name = "TxtIdEquipo";
            this.TxtIdEquipo.Size = new System.Drawing.Size(159, 22);
            this.TxtIdEquipo.TabIndex = 53;
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.Location = new System.Drawing.Point(63, 322);
            this.LblCiudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(61, 26);
            this.LblCiudad.TabIndex = 52;
            this.LblCiudad.Text = "Ciudad";
            // 
            // LblEstadio
            // 
            this.LblEstadio.AutoSize = true;
            this.LblEstadio.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadio.Location = new System.Drawing.Point(63, 293);
            this.LblEstadio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEstadio.Name = "LblEstadio";
            this.LblEstadio.Size = new System.Drawing.Size(67, 26);
            this.LblEstadio.TabIndex = 51;
            this.LblEstadio.Text = "Estadio";
            // 
            // LblNombreEquipo
            // 
            this.LblNombreEquipo.AutoSize = true;
            this.LblNombreEquipo.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEquipo.Location = new System.Drawing.Point(63, 260);
            this.LblNombreEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombreEquipo.Name = "LblNombreEquipo";
            this.LblNombreEquipo.Size = new System.Drawing.Size(144, 26);
            this.LblNombreEquipo.TabIndex = 50;
            this.LblNombreEquipo.Text = "Nombre de Equipo";
            // 
            // LblIdEquipo
            // 
            this.LblIdEquipo.AutoSize = true;
            this.LblIdEquipo.Font = new System.Drawing.Font("Haettenschweiler", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdEquipo.Location = new System.Drawing.Point(63, 225);
            this.LblIdEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIdEquipo.Name = "LblIdEquipo";
            this.LblIdEquipo.Size = new System.Drawing.Size(82, 26);
            this.LblIdEquipo.TabIndex = 49;
            this.LblIdEquipo.Text = "Id_Equipo";
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
            this.BtnEliminar.Location = new System.Drawing.Point(640, 540);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(174, 41);
            this.BtnEliminar.TabIndex = 48;
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
            this.BtnModificar.Location = new System.Drawing.Point(380, 540);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(174, 41);
            this.BtnModificar.TabIndex = 47;
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
            this.BtnIngresar.Location = new System.Drawing.Point(125, 540);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(174, 41);
            this.BtnIngresar.TabIndex = 46;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblDeportes
            // 
            this.LblDeportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDeportes.AutoSize = true;
            this.LblDeportes.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeportes.Location = new System.Drawing.Point(406, 71);
            this.LblDeportes.Name = "LblDeportes";
            this.LblDeportes.Size = new System.Drawing.Size(126, 50);
            this.LblDeportes.TabIndex = 45;
            this.LblDeportes.Text = "EQUIPO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(471, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(469, 291);
            this.dataGridView1.TabIndex = 44;
            // 
            // FormEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 653);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtEstadio);
            this.Controls.Add(this.TxtNombreEquipo);
            this.Controls.Add(this.TxtIdEquipo);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.LblEstadio);
            this.Controls.Add(this.LblNombreEquipo);
            this.Controls.Add(this.LblIdEquipo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblDeportes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEquipo";
            this.Text = "Ingreso Equipo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtEstadio;
        private System.Windows.Forms.TextBox TxtNombreEquipo;
        private System.Windows.Forms.TextBox TxtIdEquipo;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblEstadio;
        private System.Windows.Forms.Label LblNombreEquipo;
        private System.Windows.Forms.Label LblIdEquipo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblDeportes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}