namespace NavajaSuiza.Aplicación_4
{
    partial class FrmAplicacion4
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
            this.botonAppVectorReves = new System.Windows.Forms.Button();
            this.etiqDescApp4 = new System.Windows.Forms.Label();
            this.etiqIntroducNumApp4 = new System.Windows.Forms.Label();
            this.textIntroducNumApp4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonAppVectorReves
            // 
            this.botonAppVectorReves.Location = new System.Drawing.Point(155, 277);
            this.botonAppVectorReves.Name = "botonAppVectorReves";
            this.botonAppVectorReves.Size = new System.Drawing.Size(119, 46);
            this.botonAppVectorReves.TabIndex = 0;
            this.botonAppVectorReves.Text = "Mostrar";
            this.botonAppVectorReves.UseVisualStyleBackColor = true;
            this.botonAppVectorReves.Click += new System.EventHandler(this.botonAppVectorReves_Click);
            // 
            // etiqDescApp4
            // 
            this.etiqDescApp4.AutoSize = true;
            this.etiqDescApp4.Location = new System.Drawing.Point(70, 71);
            this.etiqDescApp4.Name = "etiqDescApp4";
            this.etiqDescApp4.Size = new System.Drawing.Size(305, 40);
            this.etiqDescApp4.TabIndex = 1;
            this.etiqDescApp4.Text = "Programa que lee un vector de 10 enteros\r\ny obtiene otro al revés. ";
            // 
            // etiqIntroducNumApp4
            // 
            this.etiqIntroducNumApp4.AutoSize = true;
            this.etiqIntroducNumApp4.Location = new System.Drawing.Point(30, 171);
            this.etiqIntroducNumApp4.Name = "etiqIntroducNumApp4";
            this.etiqIntroducNumApp4.Size = new System.Drawing.Size(177, 40);
            this.etiqIntroducNumApp4.TabIndex = 2;
            this.etiqIntroducNumApp4.Text = "Introduzca 10 números \r\nseparados por comas:";
            // 
            // textIntroducNumApp4
            // 
            this.textIntroducNumApp4.Location = new System.Drawing.Point(224, 185);
            this.textIntroducNumApp4.MaxLength = 30;
            this.textIntroducNumApp4.Name = "textIntroducNumApp4";
            this.textIntroducNumApp4.Size = new System.Drawing.Size(196, 26);
            this.textIntroducNumApp4.TabIndex = 3;
            // 
            // FrmAplicacion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 385);
            this.Controls.Add(this.textIntroducNumApp4);
            this.Controls.Add(this.etiqIntroducNumApp4);
            this.Controls.Add(this.etiqDescApp4);
            this.Controls.Add(this.botonAppVectorReves);
            this.Name = "FrmAplicacion4";
            this.Text = "Aplicación 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAppVectorReves;
        private System.Windows.Forms.Label etiqDescApp4;
        private System.Windows.Forms.Label etiqIntroducNumApp4;
        private System.Windows.Forms.TextBox textIntroducNumApp4;
    }
}

