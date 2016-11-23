namespace RecursosHumanos.Vistas.UserControls
{
    partial class Evento
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
            this._ButtonActualizarEvento = new System.Windows.Forms.Button();
            this._PanelControlEvento = new System.Windows.Forms.Panel();
            this._ButtonAsignarPersonal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._LabelEvento = new System.Windows.Forms.Label();
            this._TableLayoutPanelEvento = new System.Windows.Forms.TableLayoutPanel();
            this._DGV_Evento = new System.Windows.Forms.DataGridView();
            this.panel1E = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._PanelControlEvento.SuspendLayout();
            this.panel2.SuspendLayout();
            this._TableLayoutPanelEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Evento)).BeginInit();
            this.panel1E.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ButtonActualizarEvento
            // 
            this._ButtonActualizarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ButtonActualizarEvento.Location = new System.Drawing.Point(364, 34);
            this._ButtonActualizarEvento.Name = "_ButtonActualizarEvento";
            this._ButtonActualizarEvento.Size = new System.Drawing.Size(109, 35);
            this._ButtonActualizarEvento.TabIndex = 1;
            this._ButtonActualizarEvento.Text = "Actualizar";
            this._ButtonActualizarEvento.UseVisualStyleBackColor = true;
            this._ButtonActualizarEvento.Click += new System.EventHandler(this._ButtonActualizarEvento_Click);
            // 
            // _PanelControlEvento
            // 
            this._PanelControlEvento.Controls.Add(this._ButtonAsignarPersonal);
            this._PanelControlEvento.Controls.Add(this._ButtonActualizarEvento);
            this._PanelControlEvento.Location = new System.Drawing.Point(3, 3);
            this._PanelControlEvento.Name = "_PanelControlEvento";
            this._PanelControlEvento.Size = new System.Drawing.Size(528, 118);
            this._PanelControlEvento.TabIndex = 3;
            // 
            // _ButtonAsignarPersonal
            // 
            this._ButtonAsignarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ButtonAsignarPersonal.Location = new System.Drawing.Point(101, 35);
            this._ButtonAsignarPersonal.Name = "_ButtonAsignarPersonal";
            this._ButtonAsignarPersonal.Size = new System.Drawing.Size(169, 34);
            this._ButtonAsignarPersonal.TabIndex = 0;
            this._ButtonAsignarPersonal.Text = "Asignar Personal";
            this._ButtonAsignarPersonal.UseVisualStyleBackColor = true;
            this._ButtonAsignarPersonal.Click += new System.EventHandler(this._ButtonAgregarEvento_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this._PanelControlEvento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(826, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 564);
            this.panel2.TabIndex = 2;
            // 
            // _LabelEvento
            // 
            this._LabelEvento.AutoSize = true;
            this._LabelEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LabelEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this._LabelEvento.Location = new System.Drawing.Point(196, 76);
            this._LabelEvento.Name = "_LabelEvento";
            this._LabelEvento.Size = new System.Drawing.Size(209, 59);
            this._LabelEvento.TabIndex = 0;
            this._LabelEvento.Text = "Eventos";
            // 
            // _TableLayoutPanelEvento
            // 
            this._TableLayoutPanelEvento.BackColor = System.Drawing.Color.White;
            this._TableLayoutPanelEvento.ColumnCount = 2;
            this._TableLayoutPanelEvento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.58823F));
            this._TableLayoutPanelEvento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.41177F));
            this._TableLayoutPanelEvento.Controls.Add(this._DGV_Evento, 0, 1);
            this._TableLayoutPanelEvento.Controls.Add(this.panel1E, 1, 0);
            this._TableLayoutPanelEvento.Controls.Add(this.panel2, 1, 1);
            this._TableLayoutPanelEvento.Controls.Add(this.panel1, 0, 0);
            this._TableLayoutPanelEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPanelEvento.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPanelEvento.Name = "_TableLayoutPanelEvento";
            this._TableLayoutPanelEvento.RowCount = 2;
            this._TableLayoutPanelEvento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78125F));
            this._TableLayoutPanelEvento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.21875F));
            this._TableLayoutPanelEvento.Size = new System.Drawing.Size(1360, 768);
            this._TableLayoutPanelEvento.TabIndex = 1;
            // 
            // _DGV_Evento
            // 
            this._DGV_Evento.AllowUserToAddRows = false;
            this._DGV_Evento.AllowUserToDeleteRows = false;
            this._DGV_Evento.AllowUserToOrderColumns = true;
            this._DGV_Evento.BackgroundColor = System.Drawing.Color.White;
            this._DGV_Evento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DGV_Evento.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DGV_Evento.Location = new System.Drawing.Point(3, 201);
            this._DGV_Evento.Name = "_DGV_Evento";
            this._DGV_Evento.ReadOnly = true;
            this._DGV_Evento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DGV_Evento.Size = new System.Drawing.Size(817, 564);
            this._DGV_Evento.TabIndex = 0;
            // 
            // panel1E
            // 
            this.panel1E.BackColor = System.Drawing.Color.White;
            this.panel1E.Controls.Add(this._LabelEvento);
            this.panel1E.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1E.Location = new System.Drawing.Point(826, 3);
            this.panel1E.Name = "panel1E";
            this.panel1E.Size = new System.Drawing.Size(531, 192);
            this.panel1E.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(239, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 58);
            this.label8.TabIndex = 17;
            this.label8.Text = "Vive El Club";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::RecursosHumanos.Properties.Resources.fondo4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 192);
            this.panel1.TabIndex = 3;
            // 
            // Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._TableLayoutPanelEvento);
            this.Name = "Evento";
            this.Size = new System.Drawing.Size(1360, 768);
            this._PanelControlEvento.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._TableLayoutPanelEvento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DGV_Evento)).EndInit();
            this.panel1E.ResumeLayout(false);
            this.panel1E.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _ButtonActualizarEvento;
        private System.Windows.Forms.Panel _PanelControlEvento;
        private System.Windows.Forms.Button _ButtonAsignarPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _LabelEvento;
        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanelEvento;
        public System.Windows.Forms.DataGridView _DGV_Evento;
        private System.Windows.Forms.Panel panel1E;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}
