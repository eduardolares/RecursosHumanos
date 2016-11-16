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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this._ButtonAsistencia = new System.Windows.Forms.Button();
            this._LabelAsistencia = new System.Windows.Forms.Label();
            this._TableLayoutPanelAsistencia = new System.Windows.Forms.TableLayoutPanel();
            this._DGV_Asistencia = new System.Windows.Forms.DataGridView();
            this.panel1A = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2A.SuspendLayout();
            this._PanelControlAsistencia.SuspendLayout();
            this._TableLayoutPanelAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Asistencia)).BeginInit();
            this.panel1A.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2A
            // 
            this.panel2A.Controls.Add(this._PanelControlAsistencia);
            this.panel2A.Controls.Add(this._ButtonAsistencia);
            this.panel2A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2A.Location = new System.Drawing.Point(962, 93);
            this.panel2A.Name = "panel2A";
            this.panel2A.Size = new System.Drawing.Size(395, 672);
            this.panel2A.TabIndex = 2;
            // 
            // _PanelControlAsistencia
            // 
            this._PanelControlAsistencia.Controls.Add(this.comboBox1);
            this._PanelControlAsistencia.Controls.Add(this.dateTimePicker1);
            this._PanelControlAsistencia.Location = new System.Drawing.Point(3, 3);
            this._PanelControlAsistencia.Name = "_PanelControlAsistencia";
            this._PanelControlAsistencia.Size = new System.Drawing.Size(424, 118);
            this._PanelControlAsistencia.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Asistencia",
            "Falta",
            "Falta Justificada",
            "Retardo",
            "Retardo Justificado",
            "Festivo",
            "Feriado"});
            this.comboBox1.Location = new System.Drawing.Point(234, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Seleccione Opción";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // _ButtonAsistencia
            // 
            this._ButtonAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ButtonAsistencia.Location = new System.Drawing.Point(152, 510);
            this._ButtonAsistencia.Name = "_ButtonAsistencia";
            this._ButtonAsistencia.Size = new System.Drawing.Size(109, 35);
            this._ButtonAsistencia.TabIndex = 1;
            this._ButtonAsistencia.Text = "Actualizar";
            this._ButtonAsistencia.UseVisualStyleBackColor = true;
            // 
            // _LabelAsistencia
            // 
            this._LabelAsistencia.AutoSize = true;
            this._LabelAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LabelAsistencia.Location = new System.Drawing.Point(131, 15);
            this._LabelAsistencia.Name = "_LabelAsistencia";
            this._LabelAsistencia.Size = new System.Drawing.Size(130, 30);
            this._LabelAsistencia.TabIndex = 0;
            this._LabelAsistencia.Text = "Asistencia";
            // 
            // _TableLayoutPanelAsistencia
            // 
            this._TableLayoutPanelAsistencia.ColumnCount = 2;
            this._TableLayoutPanelAsistencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.51471F));
            this._TableLayoutPanelAsistencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.48529F));
            this._TableLayoutPanelAsistencia.Controls.Add(this._DGV_Asistencia, 0, 1);
            this._TableLayoutPanelAsistencia.Controls.Add(this.panel1A, 1, 0);
            this._TableLayoutPanelAsistencia.Controls.Add(this.panel2A, 1, 1);
            this._TableLayoutPanelAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPanelAsistencia.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPanelAsistencia.Name = "_TableLayoutPanelAsistencia";
            this._TableLayoutPanelAsistencia.RowCount = 2;
            this._TableLayoutPanelAsistencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75468F));
            this._TableLayoutPanelAsistencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.24532F));
            this._TableLayoutPanelAsistencia.Size = new System.Drawing.Size(1360, 768);
            this._TableLayoutPanelAsistencia.TabIndex = 2;
            // 
            // _DGV_Asistencia
            // 
            this._DGV_Asistencia.AllowUserToAddRows = false;
            this._DGV_Asistencia.AllowUserToDeleteRows = false;
            this._DGV_Asistencia.AllowUserToOrderColumns = true;
            this._DGV_Asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DGV_Asistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DGV_Asistencia.Location = new System.Drawing.Point(3, 93);
            this._DGV_Asistencia.Name = "_DGV_Asistencia";
            this._DGV_Asistencia.ReadOnly = true;
            this._DGV_Asistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DGV_Asistencia.Size = new System.Drawing.Size(953, 672);
            this._DGV_Asistencia.TabIndex = 0;
            // 
            // panel1A
            // 
            this.panel1A.Controls.Add(this._LabelAsistencia);
            this.panel1A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1A.Location = new System.Drawing.Point(962, 3);
            this.panel1A.Name = "panel1A";
            this.panel1A.Size = new System.Drawing.Size(395, 84);
            this.panel1A.TabIndex = 1;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._TableLayoutPanelAsistencia);
            this.Name = "Asistencia";
            this.Size = new System.Drawing.Size(1360, 768);
            this.panel2A.ResumeLayout(false);
            this._PanelControlAsistencia.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
