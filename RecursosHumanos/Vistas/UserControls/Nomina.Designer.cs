namespace RecursosHumanos.Vistas.UserControls
{
    partial class Nomina
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2N = new System.Windows.Forms.Panel();
            this._TextBoxNombre = new System.Windows.Forms.TextBox();
            this._PanelControlNomina = new System.Windows.Forms.Panel();
            this._DateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this._DateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._LabelNomina = new System.Windows.Forms.Label();
            this._TableLayoutPaneNomina = new System.Windows.Forms.TableLayoutPanel();
            this._DGV_Nomina = new System.Windows.Forms.DataGridView();
            this.panel1N = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2N.SuspendLayout();
            this._PanelControlNomina.SuspendLayout();
            this._TableLayoutPaneNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Nomina)).BeginInit();
            this.panel1N.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2N
            // 
            this.panel2N.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2N.Controls.Add(this.button1);
            this.panel2N.Controls.Add(this._TextBoxNombre);
            this.panel2N.Controls.Add(this._PanelControlNomina);
            this.panel2N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2N.Location = new System.Drawing.Point(962, 93);
            this.panel2N.Name = "panel2N";
            this.panel2N.Size = new System.Drawing.Size(395, 672);
            this.panel2N.TabIndex = 2;
            // 
            // _TextBoxNombre
            // 
            this._TextBoxNombre.Location = new System.Drawing.Point(18, 142);
            this._TextBoxNombre.Name = "_TextBoxNombre";
            this._TextBoxNombre.Size = new System.Drawing.Size(200, 20);
            this._TextBoxNombre.TabIndex = 4;
            // 
            // _PanelControlNomina
            // 
            this._PanelControlNomina.Controls.Add(this._DateTimePickerInicio);
            this._PanelControlNomina.Controls.Add(this._DateTimePickerFinal);
            this._PanelControlNomina.Controls.Add(this.comboBox1);
            this._PanelControlNomina.Location = new System.Drawing.Point(3, 3);
            this._PanelControlNomina.Name = "_PanelControlNomina";
            this._PanelControlNomina.Size = new System.Drawing.Size(424, 118);
            this._PanelControlNomina.TabIndex = 3;
            // 
            // _DateTimePickerInicio
            // 
            this._DateTimePickerInicio.Location = new System.Drawing.Point(15, 37);
            this._DateTimePickerInicio.Name = "_DateTimePickerInicio";
            this._DateTimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this._DateTimePickerInicio.TabIndex = 2;
            // 
            // _DateTimePickerFinal
            // 
            this._DateTimePickerFinal.Location = new System.Drawing.Point(15, 82);
            this._DateTimePickerFinal.Name = "_DateTimePickerFinal";
            this._DateTimePickerFinal.Size = new System.Drawing.Size(200, 20);
            this._DateTimePickerFinal.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Seleccione Empleado";
            // 
            // _LabelNomina
            // 
            this._LabelNomina.AutoSize = true;
            this._LabelNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LabelNomina.Location = new System.Drawing.Point(131, 15);
            this._LabelNomina.Name = "_LabelNomina";
            this._LabelNomina.Size = new System.Drawing.Size(102, 30);
            this._LabelNomina.TabIndex = 0;
            this._LabelNomina.Text = "Nómina";
            // 
            // _TableLayoutPaneNomina
            // 
            this._TableLayoutPaneNomina.ColumnCount = 2;
            this._TableLayoutPaneNomina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.51471F));
            this._TableLayoutPaneNomina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.48529F));
            this._TableLayoutPaneNomina.Controls.Add(this._DGV_Nomina, 0, 1);
            this._TableLayoutPaneNomina.Controls.Add(this.panel1N, 1, 0);
            this._TableLayoutPaneNomina.Controls.Add(this.panel2N, 1, 1);
            this._TableLayoutPaneNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPaneNomina.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPaneNomina.Name = "_TableLayoutPaneNomina";
            this._TableLayoutPaneNomina.RowCount = 2;
            this._TableLayoutPaneNomina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75468F));
            this._TableLayoutPaneNomina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.24532F));
            this._TableLayoutPaneNomina.Size = new System.Drawing.Size(1360, 768);
            this._TableLayoutPaneNomina.TabIndex = 2;
            // 
            // _DGV_Nomina
            // 
            this._DGV_Nomina.AllowUserToAddRows = false;
            this._DGV_Nomina.AllowUserToDeleteRows = false;
            this._DGV_Nomina.AllowUserToOrderColumns = true;
            this._DGV_Nomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DGV_Nomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DGV_Nomina.Location = new System.Drawing.Point(3, 93);
            this._DGV_Nomina.Name = "_DGV_Nomina";
            this._DGV_Nomina.ReadOnly = true;
            this._DGV_Nomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DGV_Nomina.Size = new System.Drawing.Size(953, 672);
            this._DGV_Nomina.TabIndex = 0;
            // 
            // panel1N
            // 
            this.panel1N.Controls.Add(this._LabelNomina);
            this.panel1N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1N.Location = new System.Drawing.Point(962, 3);
            this.panel1N.Name = "panel1N";
            this.panel1N.Size = new System.Drawing.Size(395, 84);
            this.panel1N.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._TableLayoutPaneNomina);
            this.Name = "Nomina";
            this.Size = new System.Drawing.Size(1360, 768);
            this.panel2N.ResumeLayout(false);
            this.panel2N.PerformLayout();
            this._PanelControlNomina.ResumeLayout(false);
            this._TableLayoutPaneNomina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Nomina)).EndInit();
            this.panel1N.ResumeLayout(false);
            this.panel1N.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2N;
        private System.Windows.Forms.Panel _PanelControlNomina;
        private System.Windows.Forms.Label _LabelNomina;
        private System.Windows.Forms.TableLayoutPanel _TableLayoutPaneNomina;
        public System.Windows.Forms.DataGridView _DGV_Nomina;
        private System.Windows.Forms.Panel panel1N;
        private System.Windows.Forms.DateTimePicker _DateTimePickerFinal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker _DateTimePickerInicio;
        private System.Windows.Forms.TextBox _TextBoxNombre;
        private System.Windows.Forms.Button button1;
    }
}
