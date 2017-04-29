namespace NavajaSuiza.Aplicación_3
{
    partial class FrmAplicacion3
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
            this.botonAppRepetidos = new System.Windows.Forms.Button();
            this.etiqDescApp3 = new System.Windows.Forms.Label();
            this.etiqIntroducNumApp3 = new System.Windows.Forms.Label();
            this.textIntroducNumApp3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonAppRepetidos
            // 
            this.botonAppRepetidos.Location = new System.Drawing.Point(219, 345);
            this.botonAppRepetidos.Name = "botonAppRepetidos";
            this.botonAppRepetidos.Size = new System.Drawing.Size(149, 57);
            this.botonAppRepetidos.TabIndex = 0;
            this.botonAppRepetidos.Text = "Mostrar";
            this.botonAppRepetidos.UseVisualStyleBackColor = true;
            this.botonAppRepetidos.Click += new System.EventHandler(this.botonAppRepetidos_Click);
            // 
            // etiqDescApp3
            // 
            this.etiqDescApp3.AutoSize = true;
            this.etiqDescApp3.Location = new System.Drawing.Point(47, 105);
            this.etiqDescApp3.Name = "etiqDescApp3";
            this.etiqDescApp3.Size = new System.Drawing.Size(512, 60);
            this.etiqDescApp3.TabIndex = 1;
            this.etiqDescApp3.Text = "Programa que lee un vector de números enteros positivos introducidos. \r\nSustituye" +
    " cada valor repetido por el –1 y devuelve el número de valores \r\nmodificados. ";
            // 
            // etiqIntroducNumApp3
            // 
            this.etiqIntroducNumApp3.AutoSize = true;
            this.etiqIntroducNumApp3.Location = new System.Drawing.Point(75, 215);
            this.etiqIntroducNumApp3.Name = "etiqIntroducNumApp3";
            this.etiqIntroducNumApp3.Size = new System.Drawing.Size(177, 40);
            this.etiqIntroducNumApp3.TabIndex = 2;
            this.etiqIntroducNumApp3.Text = "Introduzca 10 números \r\nseparados por comas:";
            // 
            // textIntroducNumApp3
            // 
            this.textIntroducNumApp3.Location = new System.Drawing.Point(258, 229);
            this.textIntroducNumApp3.MaxLength = 30;
            this.textIntroducNumApp3.Name = "textIntroducNumApp3";
            this.textIntroducNumApp3.Size = new System.Drawing.Size(216, 26);
            this.textIntroducNumApp3.TabIndex = 3;
            // 
            // FrmAplicacion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 517);
            this.Controls.Add(this.textIntroducNumApp3);
            this.Controls.Add(this.etiqIntroducNumApp3);
            this.Controls.Add(this.etiqDescApp3);
            this.Controls.Add(this.botonAppRepetidos);
            this.Name = "FrmAplicacion3";
            this.Text = "Aplicación 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAppRepetidos;
        private System.Windows.Forms.Label etiqDescApp3;
        private System.Windows.Forms.Label etiqIntroducNumApp3;
        private System.Windows.Forms.TextBox textIntroducNumApp3;
    }
}

