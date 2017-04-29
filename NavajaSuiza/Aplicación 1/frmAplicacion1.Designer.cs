namespace NavajaSuiza.Aplicación_1
{
    partial class FrmAplicacion1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonAppPrimos = new System.Windows.Forms.Button();
            this.textIntroducNumApp1 = new System.Windows.Forms.TextBox();
            this.etiqIntroducNumApp1 = new System.Windows.Forms.Label();
            this.etiqDescApp1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonAppPrimos
            // 
            this.botonAppPrimos.Location = new System.Drawing.Point(146, 249);
            this.botonAppPrimos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonAppPrimos.Name = "botonAppPrimos";
            this.botonAppPrimos.Size = new System.Drawing.Size(112, 35);
            this.botonAppPrimos.TabIndex = 0;
            this.botonAppPrimos.Text = "¿Es primo?";
            this.botonAppPrimos.UseVisualStyleBackColor = true;
            this.botonAppPrimos.Click += new System.EventHandler(this.botonAppPrimo_Click);
            // 
            // textIntroducNumApp1
            // 
            this.textIntroducNumApp1.Location = new System.Drawing.Point(216, 149);
            this.textIntroducNumApp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textIntroducNumApp1.MaxLength = 9;
            this.textIntroducNumApp1.Name = "textIntroducNumApp1";
            this.textIntroducNumApp1.Size = new System.Drawing.Size(148, 26);
            this.textIntroducNumApp1.TabIndex = 1;
            // 
            // etiqIntroducNumApp1
            // 
            this.etiqIntroducNumApp1.AutoSize = true;
            this.etiqIntroducNumApp1.Location = new System.Drawing.Point(39, 152);
            this.etiqIntroducNumApp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etiqIntroducNumApp1.Name = "etiqIntroducNumApp1";
            this.etiqIntroducNumApp1.Size = new System.Drawing.Size(169, 20);
            this.etiqIntroducNumApp1.TabIndex = 2;
            this.etiqIntroducNumApp1.Text = "Introduzca un número:";
            // 
            // etiqDescApp1
            // 
            this.etiqDescApp1.AutoSize = true;
            this.etiqDescApp1.Location = new System.Drawing.Point(39, 55);
            this.etiqDescApp1.Name = "etiqDescApp1";
            this.etiqDescApp1.Size = new System.Drawing.Size(336, 40);
            this.etiqDescApp1.TabIndex = 3;
            this.etiqDescApp1.Text = "Programa que nos indica si un número positivo\r\nintroducido es o no primo. ";
            // 
            // FrmAplicacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.etiqDescApp1);
            this.Controls.Add(this.etiqIntroducNumApp1);
            this.Controls.Add(this.textIntroducNumApp1);
            this.Controls.Add(this.botonAppPrimos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAplicacion1";
            this.Text = "Aplicación 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAppPrimos;
        private System.Windows.Forms.TextBox textIntroducNumApp1;
        private System.Windows.Forms.Label etiqIntroducNumApp1;
        private System.Windows.Forms.Label etiqDescApp1;
    }
}

