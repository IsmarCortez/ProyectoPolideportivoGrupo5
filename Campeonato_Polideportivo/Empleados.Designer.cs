
namespace Campeonato_Polideportivo
{
    partial class Empleados
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
            this.LblCampeonato = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblAvenida = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblNumCasa = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtAvenida = new System.Windows.Forms.TextBox();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtNumCasa = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.BtnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCampeonato
            // 
            this.LblCampeonato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCampeonato.AutoSize = true;
            this.LblCampeonato.Font = new System.Drawing.Font("Haettenschweiler", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampeonato.Location = new System.Drawing.Point(284, 34);
            this.LblCampeonato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCampeonato.Name = "LblCampeonato";
            this.LblCampeonato.Size = new System.Drawing.Size(231, 40);
            this.LblCampeonato.TabIndex = 52;
            this.LblCampeonato.Text = "NUEVO EMPLEADO";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Location = new System.Drawing.Point(28, 102);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(93, 13);
            this.lblIdEmpleado.TabIndex = 78;
            this.lblIdEmpleado.Text = "Codigo Empleado:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 79;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 168);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 80;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(28, 208);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(43, 13);
            this.lblPuesto.TabIndex = 81;
            this.lblPuesto.Text = "Puesto:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(28, 242);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(145, 13);
            this.lblIdUsuario.TabIndex = 82;
            this.lblIdUsuario.Text = "Usuario que realiza incersión:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(28, 273);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 83;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdEmpleado.Location = new System.Drawing.Point(157, 99);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(227, 20);
            this.txtIdEmpleado.TabIndex = 84;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(157, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 20);
            this.txtNombre.TabIndex = 85;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Location = new System.Drawing.Point(157, 165);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(227, 20);
            this.txtApellido.TabIndex = 86;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Administrador",
            "Gerente"});
            this.cmbPuesto.Location = new System.Drawing.Point(157, 205);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(227, 21);
            this.cmbPuesto.TabIndex = 87;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(157, 239);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 20);
            this.txtUsuario.TabIndex = 88;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Location = new System.Drawing.Point(157, 270);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(227, 20);
            this.txtTelefono.TabIndex = 89;
            // 
            // lblCalle
            // 
            this.lblCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(415, 102);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 90;
            this.lblCalle.Text = "Calle:";
            // 
            // lblAvenida
            // 
            this.lblAvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvenida.AutoSize = true;
            this.lblAvenida.Location = new System.Drawing.Point(415, 133);
            this.lblAvenida.Name = "lblAvenida";
            this.lblAvenida.Size = new System.Drawing.Size(49, 13);
            this.lblAvenida.TabIndex = 91;
            this.lblAvenida.Text = "Avenida:";
            // 
            // lblZona
            // 
            this.lblZona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(415, 168);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(35, 13);
            this.lblZona.TabIndex = 92;
            this.lblZona.Text = "Zona:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(415, 208);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 93;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(415, 242);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(74, 13);
            this.lblCodPostal.TabIndex = 94;
            this.lblCodPostal.Text = "Código postal:";
            // 
            // lblNumCasa
            // 
            this.lblNumCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumCasa.AutoSize = true;
            this.lblNumCasa.Location = new System.Drawing.Point(415, 273);
            this.lblNumCasa.Name = "lblNumCasa";
            this.lblNumCasa.Size = new System.Drawing.Size(89, 13);
            this.lblNumCasa.TabIndex = 95;
            this.lblNumCasa.Text = "Número de Casa:";
            // 
            // txtCalle
            // 
            this.txtCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalle.Location = new System.Drawing.Point(507, 99);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(227, 20);
            this.txtCalle.TabIndex = 96;
            // 
            // txtAvenida
            // 
            this.txtAvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAvenida.Location = new System.Drawing.Point(507, 130);
            this.txtAvenida.Name = "txtAvenida";
            this.txtAvenida.Size = new System.Drawing.Size(227, 20);
            this.txtAvenida.TabIndex = 97;
            // 
            // txtZona
            // 
            this.txtZona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtZona.Location = new System.Drawing.Point(507, 165);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(227, 20);
            this.txtZona.TabIndex = 98;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Alta Verapaz",
            "Baja Verapaz",
            "Chimaltenango",
            "Chiquimula",
            "El Progreso",
            "Escuintla",
            "Guatemala",
            "Huehuetenango",
            "Izabal",
            "Jalapa",
            "Jutiapa",
            "Petén",
            "Quetzaltenango",
            "Quiché",
            "Retalhuleu",
            "Sacatepéquez",
            "San Marcos",
            "Santa Rosa",
            "Sololá",
            "Suchitepéquez",
            "Totonicapán",
            "Zacapa"});
            this.cmbDepartamento.Location = new System.Drawing.Point(507, 205);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(227, 21);
            this.cmbDepartamento.TabIndex = 99;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodPostal.Location = new System.Drawing.Point(507, 239);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(227, 20);
            this.txtCodPostal.TabIndex = 100;
            // 
            // txtNumCasa
            // 
            this.txtNumCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumCasa.Location = new System.Drawing.Point(507, 270);
            this.txtNumCasa.Name = "txtNumCasa";
            this.txtNumCasa.Size = new System.Drawing.Size(227, 20);
            this.txtNumCasa.TabIndex = 101;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnIngresar.Location = new System.Drawing.Point(604, 312);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(130, 33);
            this.btnIngresar.TabIndex = 102;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(31, 312);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(556, 144);
            this.dgvEmpleados.TabIndex = 103;
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
            this.BtnVer.Location = new System.Drawing.Point(604, 375);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(130, 33);
            this.BtnVer.TabIndex = 104;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 531);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNumCasa);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.txtAvenida);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblNumCasa);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.lblAvenida);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.LblCampeonato);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCampeonato;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblAvenida;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblNumCasa;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtAvenida;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtNumCasa;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button BtnVer;
    }
}