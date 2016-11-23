namespace RecursosHumanos.Vistas.UserControls
{
    partial class Asistencia
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
            this.panel2A = new System.Windows.Forms.Panel();
            this._PanelControlAsistencia = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._ComboBoxEvento = new System.Windows.Forms.ComboBox();
            this._ComboBoxAsistencia = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this._ButtonAsistencia = new System.Windows.Forms.Button();
            this._LabelAsistencia = new System.Windows.Forms.Label();
            this._TableLayoutPanelAsistencia = new System.Windows.Forms.TableLayoutPanel();
            this._DGV_Asistencia = new System.Windows.Forms.DataGridView();
            this.panel1A = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2A.SuspendLayout();
            this._PanelControlAsistencia.SuspendLayout();
            this._TableLayoutPanelAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Asistencia)).BeginInit();
            this.panel1A.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2A
            // 
            this.panel2A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2A.Controls.Add(this.label8);
            this.panel2A.Controls.Add(this._PanelControlAsistencia);
            this.panel2A.Controls.Add(this._ButtonAsistencia);
            this.panel2A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2A.Location = new System.Drawing.Point(617, 169);
            this.panel2A.Name = "panel2A";
            this.panel2A.Size = new System.Drawing.Size(740, 596);
            this.panel2A.TabIndex = 2;
            // 
            // _PanelControlAsistencia
            // 
            this._PanelControlAsistencia.Controls.Add(this.label1);
            this._PanelControlAsistencia.Controls.Add(this._ComboBoxEvento);
            this._PanelControlAsistencia.Controls.Add(this._ComboBoxAsistencia);
            this._PanelControlAsistencia.Controls.Add(this.dateTimePicker1);
            this._PanelControlAsistencia.Location = new System.Drawing.Point(3, 3);
            this._PanelControlAsistencia.Name = "_PanelControlAsistencia";
            this._PanelControlAsistencia.Size = new System.Drawing.Size(424, 184);
            this._PanelControlAsistencia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Evento";
            // 
            // _ComboBoxEvento
            // 
            this._ComboBoxEvento.FormattingEnabled = true;
            this._ComboBoxEvento.Location = new System.Drawing.Point(13, 113);
            this._ComboBoxEvento.Name = "_ComboBoxEvento";
            this._ComboBoxEvento.Size = new System.Drawing.Size(110, 21);
            this._ComboBoxEvento.TabIndex = 5;
            this._ComboBoxEvento.TextChanged += new System.EventHandler(this._ComboBoxEvento_TextChanged);
            // 
            // _ComboBoxAsistencia
            // 
            this._ComboBoxAsistencia.FormattingEnabled = true;
            this._ComboBoxAsistencia.Items.AddRange(new object[] {
            "Asistencia",
            "Falta",
            "Falta Justificada",
            "Retardo",
            "Retardo Justificado",
            "Festivo",
            "Feriado"});
            this._ComboBoxAsistencia.Location = new System.Drawing.Point(234, 40);
            this._ComboBoxAsistencia.Name = "_ComboBoxAsistencia";
            this._ComboBoxAsistencia.Size = new System.Drawing.Size(121, 21);
            this._ComboBoxAsistencia.TabIndex = 4;
            this._ComboBoxAsistencia.Text = "Seleccione Opción";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 20, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // _ButtonAsistencia
            // 
            this._ButtonAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ButtonAsistencia.Location = new System.Drawing.Point(17, 213);
            this._ButtonAsistencia.Name = "_ButtonAsistencia";
            this._ButtonAsistencia.Size = new System.Drawing.Size(109, 35);
            this._ButtonAsistencia.TabIndex = 1;
            this._ButtonAsistencia.Text = "Registrar";
            this._ButtonAsistencia.UseVisualStyleBackColor = true;
            this._ButtonAsistencia.Click += new System.EventHandler(this._ButtonAsistencia_Click);
            // 
            // _LabelAsistencia
            // 
            this._LabelAsistencia.AutoSize = true;
            this._LabelAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LabelAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this._LabelAsistencia.Location = new System.Drawing.Point(6, 53);
            this._LabelAsistencia.Name = "_LabelAsistencia";
            this._LabelAsistencia.Size = new System.Drawing.Size(257, 59);
            this._LabelAsistencia.TabIndex = 0;
            this._LabelAsistencia.Text = "Asistencia";
            // 
            // _TableLayoutPanelAsistencia
            // 
            this._TableLayoutPanelAsistencia.BackColor = System.Drawing.Color.White;
            this._TableLayoutPanelAsistencia.ColumnCount = 2;
            this._TableLayoutPanelAsistencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.14706F));
            this._TableLayoutPanelAsistencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.85294F));
            this._TableLayoutPanelAsistencia.Controls.Add(this._DGV_Asistencia, 0, 1);
            this._TableLayoutPanelAsistencia.Controls.Add(this.panel1A, 1, 0);
            this._TableLayoutPanelAsistencia.Controls.Add(this.panel2A, 1, 1);
            this._TableLayoutPanelAsistencia.Controls.Add(this.panel1, 0, 0);
            this._TableLayoutPanelAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPanelAsistencia.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPanelAsistencia.Name = "_TableLayoutPanelAsistencia";
            this._TableLayoutPanelAsistencia.RowCount = 2;
            this._TableLayoutPanelAsistencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.61458F));
            this._TableLayoutPanelAsistencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.38541F));
            this._TableLayoutPanelAsistencia.Size = new System.Drawing.Size(1360, 768);
            this._TableLayoutPanelAsistencia.TabIndex = 2;
            // 
            // _DGV_Asistencia
            // 
            this._DGV_Asistencia.AllowUserToAddRows = false;
            this._DGV_Asistencia.AllowUserToDeleteRows = false;
            this._DGV_Asistencia.AllowUserToOrderColumns = true;
            this._DGV_Asistencia.BackgroundColor = System.Drawing.Color.White;
            this._DGV_Asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DGV_Asistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DGV_Asistencia.Location = new System.Drawing.Point(3, 169);
            this._DGV_Asistencia.Name = "_DGV_Asistencia";
            this._DGV_Asistencia.ReadOnly = true;
            this._DGV_Asistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DGV_Asistencia.Size = new System.Drawing.Size(608, 596);
            this._DGV_Asistencia.TabIndex = 0;
            // 
            // panel1A
            // 
            this.panel1A.Controls.Add(this._LabelAsistencia);
            this.panel1A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1A.Location = new System.Drawing.Point(617, 3);
            this.panel1A.Name = "panel1A";
            this.panel1A.Size = new System.Drawing.Size(740, 160);
            this.panel1A.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(445, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 58);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vive El Club";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RecursosHumanos.Properties.Resources.fondo4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 160);
            this.panel1.TabIndex = 3;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._TableLayoutPanelAsistencia);
            this.Name = "Asistencia";
            this.Size = new System.Drawing.Size(1360, 768);
            this.panel2A.ResumeLayout(false);
            this.panel2A.PerformLayout();
            this._PanelControlAsistencia.ResumeLayout(false);
            this._PanelControlAsistencia.PerformLayout();
            this._TableLayoutPanelAsistencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Asistencia)).EndInit();
            this.panel1A.ResumeLayout(false);
            this.panel1A.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2A;
        private System.Windows.Forms.Panel _PanelControlAsistencia;
        private System.Windows.Forms.Button _ButtonAsistencia;
        private System.Windows.Forms.Label _LabelAsistencia;
        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanelAsistencia;
        public System.Windows.Forms.DataGridView _DGV_Asistencia;
        private System.Windows.Forms.Panel panel1A;
        private System.Windows.Forms.ComboBox _ComboBoxAsistencia;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _ComboBoxEvento;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}
