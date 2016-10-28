namespace RecursosHumanos.Vistas.UserControls
{
    partial class Personal
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._DGV_Personal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this._Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._PanelFormulario = new System.Windows.Forms.Panel();
            this._ButtonAccion = new System.Windows.Forms.Button();
            this._ComboBoxSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._TextBoxDireccion = new System.Windows.Forms.TextBox();
            this._TextBoxCorreo = new System.Windows.Forms.TextBox();
            this._TextBoxTelefono = new System.Windows.Forms.TextBox();
            this._TextBoxEdad = new System.Windows.Forms.TextBox();
            this._TextBoxNombre = new System.Windows.Forms.TextBox();
            this._PanelControl = new System.Windows.Forms.Panel();
            this._ButtonAgregar = new System.Windows.Forms.Button();
            this._ButtonModificar = new System.Windows.Forms.Button();
            this._TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Personal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this._PanelFormulario.SuspendLayout();
            this._PanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // _TableLayoutPanel
            // 
            this._TableLayoutPanel.ColumnCount = 2;
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.51471F));
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.48529F));
            this._TableLayoutPanel.Controls.Add(this._DGV_Personal, 0, 1);
            this._TableLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this._TableLayoutPanel.Controls.Add(this.panel2, 1, 1);
            this._TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPanel.Name = "_TableLayoutPanel";
            this._TableLayoutPanel.RowCount = 2;
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75468F));
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.24532F));
            this._TableLayoutPanel.Size = new System.Drawing.Size(1360, 768);
            this._TableLayoutPanel.TabIndex = 0;
            // 
            // _DGV_Personal
            // 
            this._DGV_Personal.AllowUserToAddRows = false;
            this._DGV_Personal.AllowUserToDeleteRows = false;
            this._DGV_Personal.AllowUserToOrderColumns = true;
            this._DGV_Personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DGV_Personal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DGV_Personal.Location = new System.Drawing.Point(3, 93);
            this._DGV_Personal.Name = "_DGV_Personal";
            this._DGV_Personal.ReadOnly = true;
            this._DGV_Personal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DGV_Personal.Size = new System.Drawing.Size(953, 672);
            this._DGV_Personal.TabIndex = 0;
            this._DGV_Personal.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._DGV_Personal_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(962, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 84);
            this.panel1.TabIndex = 1;
            // 
            // _Label
            // 
            this._Label.AutoSize = true;
            this._Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label.Location = new System.Drawing.Point(131, 15);
            this._Label.Name = "_Label";
            this._Label.Size = new System.Drawing.Size(114, 30);
            this._Label.TabIndex = 0;
            this._Label.Text = "Personal";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._PanelFormulario);
            this.panel2.Controls.Add(this._PanelControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(962, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 672);
            this.panel2.TabIndex = 2;
            // 
            // _PanelFormulario
            // 
            this._PanelFormulario.Controls.Add(this._ButtonAccion);
            this._PanelFormulario.Controls.Add(this._ComboBoxSexo);
            this._PanelFormulario.Controls.Add(this.label6);
            this._PanelFormulario.Controls.Add(this.label5);
            this._PanelFormulario.Controls.Add(this.label4);
            this._PanelFormulario.Controls.Add(this.label3);
            this._PanelFormulario.Controls.Add(this.label2);
            this._PanelFormulario.Controls.Add(this.label1);
            this._PanelFormulario.Controls.Add(this._TextBoxDireccion);
            this._PanelFormulario.Controls.Add(this._TextBoxCorreo);
            this._PanelFormulario.Controls.Add(this._TextBoxTelefono);
            this._PanelFormulario.Controls.Add(this._TextBoxEdad);
            this._PanelFormulario.Controls.Add(this._TextBoxNombre);
            this._PanelFormulario.Location = new System.Drawing.Point(3, 138);
            this._PanelFormulario.Name = "_PanelFormulario";
            this._PanelFormulario.Size = new System.Drawing.Size(432, 531);
            this._PanelFormulario.TabIndex = 4;
            this._PanelFormulario.Visible = false;
            // 
            // _ButtonAccion
            // 
            this._ButtonAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ButtonAccion.Location = new System.Drawing.Point(36, 301);
            this._ButtonAccion.Name = "_ButtonAccion";
            this._ButtonAccion.Size = new System.Drawing.Size(151, 56);
            this._ButtonAccion.TabIndex = 13;
            this._ButtonAccion.Text = "<placeholder>";
            this._ButtonAccion.UseVisualStyleBackColor = false;
            this._ButtonAccion.Click += new System.EventHandler(this._ButtonAccion_Click);
            // 
            // _ComboBoxSexo
            // 
            this._ComboBoxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComboBoxSexo.FormattingEnabled = true;
            this._ComboBoxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this._ComboBoxSexo.Location = new System.Drawing.Point(36, 166);
            this._ComboBoxSexo.Name = "_ComboBoxSexo";
            this._ComboBoxSexo.Size = new System.Drawing.Size(151, 28);
            this._ComboBoxSexo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // _TextBoxDireccion
            // 
            this._TextBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TextBoxDireccion.Location = new System.Drawing.Point(36, 265);
            this._TextBoxDireccion.Name = "_TextBoxDireccion";
            this._TextBoxDireccion.Size = new System.Drawing.Size(151, 26);
            this._TextBoxDireccion.TabIndex = 5;
            // 
            // _TextBoxCorreo
            // 
            this._TextBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TextBoxCorreo.Location = new System.Drawing.Point(36, 215);
            this._TextBoxCorreo.Name = "_TextBoxCorreo";
            this._TextBoxCorreo.Size = new System.Drawing.Size(151, 26);
            this._TextBoxCorreo.TabIndex = 4;
            // 
            // _TextBoxTelefono
            // 
            this._TextBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TextBoxTelefono.Location = new System.Drawing.Point(36, 115);
            this._TextBoxTelefono.Name = "_TextBoxTelefono";
            this._TextBoxTelefono.Size = new System.Drawing.Size(151, 26);
            this._TextBoxTelefono.TabIndex = 2;
            // 
            // _TextBoxEdad
            // 
            this._TextBoxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TextBoxEdad.Location = new System.Drawing.Point(36, 64);
            this._TextBoxEdad.Name = "_TextBoxEdad";
            this._TextBoxEdad.Size = new System.Drawing.Size(151, 26);
            this._TextBoxEdad.TabIndex = 1;
            // 
            // _TextBoxNombre
            // 
            this._TextBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TextBoxNombre.Location = new System.Drawing.Point(36, 19);
            this._TextBoxNombre.Name = "_TextBoxNombre";
            this._TextBoxNombre.Size = new System.Drawing.Size(151, 26);
            this._TextBoxNombre.TabIndex = 8;
            // 
            // _PanelControl
            // 
            this._PanelControl.Controls.Add(this._ButtonAgregar);
            this._PanelControl.Controls.Add(this._ButtonModificar);
            this._PanelControl.Location = new System.Drawing.Point(3, 3);
            this._PanelControl.Name = "_PanelControl";
            this._PanelControl.Size = new System.Drawing.Size(424, 118);
            this._PanelControl.TabIndex = 3;
            // 
            // _ButtonAgregar
            // 
            this._ButtonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ButtonAgregar.Location = new System.Drawing.Point(51, 18);
            this._ButtonAgregar.Name = "_ButtonAgregar";
            this._ButtonAgregar.Size = new System.Drawing.Size(109, 34);
            this._ButtonAgregar.TabIndex = 0;
            this._ButtonAgregar.Text = "Agregar";
            this._ButtonAgregar.UseVisualStyleBackColor = true;
            this._ButtonAgregar.Click += new System.EventHandler(this._ButtonAgregar_Click);
            // 
            // _ButtonModificar
            // 
            this._ButtonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ButtonModificar.Location = new System.Drawing.Point(209, 17);
            this._ButtonModificar.Name = "_ButtonModificar";
            this._ButtonModificar.Size = new System.Drawing.Size(109, 35);
            this._ButtonModificar.TabIndex = 1;
            this._ButtonModificar.Text = "Modificar";
            this._ButtonModificar.UseVisualStyleBackColor = true;
            this._ButtonModificar.Click += new System.EventHandler(this._ButtonModificar_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._TableLayoutPanel);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1360, 768);
            this._TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Personal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this._PanelFormulario.ResumeLayout(false);
            this._PanelFormulario.PerformLayout();
            this._PanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _ButtonModificar;
        private System.Windows.Forms.Button _ButtonAgregar;
        public System.Windows.Forms.DataGridView _DGV_Personal;
        private System.Windows.Forms.Panel _PanelFormulario;
        private System.Windows.Forms.TextBox _TextBoxDireccion;
        private System.Windows.Forms.TextBox _TextBoxCorreo;
        private System.Windows.Forms.TextBox _TextBoxTelefono;
        private System.Windows.Forms.TextBox _TextBoxEdad;
        private System.Windows.Forms.TextBox _TextBoxNombre;
        private System.Windows.Forms.Panel _PanelControl;
        private System.Windows.Forms.ComboBox _ComboBoxSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _ButtonAccion;
    }
}
