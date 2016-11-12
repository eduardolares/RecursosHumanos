namespace RecursosHumanos.Vistas.UserControls
{
    partial class Asignar_Personal
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
            this._DGV_PersonalAsignar = new System.Windows.Forms.DataGridView();
            this._DGV_PersonalEvento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._ButtonAgregarEvento = new System.Windows.Forms.Button();
            this._ButtonEliminarEvento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DGV_PersonalAsignar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DGV_PersonalEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // _DGV_PersonalAsignar
            // 
            this._DGV_PersonalAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DGV_PersonalAsignar.Location = new System.Drawing.Point(45, 34);
            this._DGV_PersonalAsignar.Name = "_DGV_PersonalAsignar";
            this._DGV_PersonalAsignar.Size = new System.Drawing.Size(289, 323);
            this._DGV_PersonalAsignar.TabIndex = 0;
            // 
            // _DGV_PersonalEvento
            // 
            this._DGV_PersonalEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DGV_PersonalEvento.Location = new System.Drawing.Point(466, 34);
            this._DGV_PersonalEvento.Name = "_DGV_PersonalEvento";
            this._DGV_PersonalEvento.Size = new System.Drawing.Size(289, 323);
            this._DGV_PersonalEvento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personal de Evento";
            // 
            // _ButtonAgregarEvento
            // 
            this._ButtonAgregarEvento.Location = new System.Drawing.Point(352, 112);
            this._ButtonAgregarEvento.Name = "_ButtonAgregarEvento";
            this._ButtonAgregarEvento.Size = new System.Drawing.Size(96, 40);
            this._ButtonAgregarEvento.TabIndex = 4;
            this._ButtonAgregarEvento.Text = "Agregar a Evento";
            this._ButtonAgregarEvento.UseVisualStyleBackColor = true;
            // 
            // _ButtonEliminarEvento
            // 
            this._ButtonEliminarEvento.Location = new System.Drawing.Point(352, 191);
            this._ButtonEliminarEvento.Name = "_ButtonEliminarEvento";
            this._ButtonEliminarEvento.Size = new System.Drawing.Size(98, 37);
            this._ButtonEliminarEvento.TabIndex = 5;
            this._ButtonEliminarEvento.Text = "Eliminar de Evento";
            this._ButtonEliminarEvento.UseVisualStyleBackColor = true;
            // 
            // Asignar_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._ButtonEliminarEvento);
            this.Controls.Add(this._ButtonAgregarEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._DGV_PersonalEvento);
            this.Controls.Add(this._DGV_PersonalAsignar);
            this.Name = "Asignar_Personal";
            this.Size = new System.Drawing.Size(798, 403);
            ((System.ComponentModel.ISupportInitialize)(this._DGV_PersonalAsignar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DGV_PersonalEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _DGV_PersonalAsignar;
        private System.Windows.Forms.DataGridView _DGV_PersonalEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _ButtonAgregarEvento;
        private System.Windows.Forms.Button _ButtonEliminarEvento;
    }
}
