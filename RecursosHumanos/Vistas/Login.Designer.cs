namespace RecursosHumanos.Vistas
{
    partial class Login
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
            this._TextBoxUsuario = new System.Windows.Forms.TextBox();
            this._TextBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._ButtonAcceser = new System.Windows.Forms.Button();
            this._ButtonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _TextBoxUsuario
            // 
            this._TextBoxUsuario.Location = new System.Drawing.Point(103, 16);
            this._TextBoxUsuario.Name = "_TextBoxUsuario";
            this._TextBoxUsuario.Size = new System.Drawing.Size(170, 20);
            this._TextBoxUsuario.TabIndex = 1;
            // 
            // _TextBoxPass
            // 
            this._TextBoxPass.Location = new System.Drawing.Point(103, 59);
            this._TextBoxPass.Name = "_TextBoxPass";
            this._TextBoxPass.Size = new System.Drawing.Size(170, 20);
            this._TextBoxPass.TabIndex = 2;
            this._TextBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextBoxPass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // _ButtonAcceser
            // 
            this._ButtonAcceser.Location = new System.Drawing.Point(31, 101);
            this._ButtonAcceser.Name = "_ButtonAcceser";
            this._ButtonAcceser.Size = new System.Drawing.Size(96, 23);
            this._ButtonAcceser.TabIndex = 5;
            this._ButtonAcceser.Text = "Acceder";
            this._ButtonAcceser.UseVisualStyleBackColor = true;
            this._ButtonAcceser.Click += new System.EventHandler(this._ButtonAcceser_Click);
            // 
            // _ButtonSalir
            // 
            this._ButtonSalir.Location = new System.Drawing.Point(161, 101);
            this._ButtonSalir.Name = "_ButtonSalir";
            this._ButtonSalir.Size = new System.Drawing.Size(112, 23);
            this._ButtonSalir.TabIndex = 6;
            this._ButtonSalir.Text = "Salir";
            this._ButtonSalir.UseVisualStyleBackColor = true;
            this._ButtonSalir.Click += new System.EventHandler(this._ButtonSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 136);
            this.Controls.Add(this._ButtonSalir);
            this.Controls.Add(this._ButtonAcceser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._TextBoxPass);
            this.Controls.Add(this._TextBoxUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _TextBoxUsuario;
        private System.Windows.Forms.TextBox _TextBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _ButtonAcceser;
        private System.Windows.Forms.Button _ButtonSalir;
    }
}