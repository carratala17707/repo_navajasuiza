namespace NavajaSuiza.Aplicación_2
{
    partial class FrmAplicacion2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAplicacion2));
            this.botonAppMultiplos = new System.Windows.Forms.Button();
            this.etiqIntroducNumApp2 = new System.Windows.Forms.Label();
            this.textIntroducNumApp2 = new System.Windows.Forms.TextBox();
            this.etiqDescApp2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonAppMultiplos
            // 
            this.botonAppMultiplos.Location = new System.Drawing.Point(270, 317);
            this.botonAppMultiplos.Name = "botonAppMultiplos";
            this.botonAppMultiplos.Size = new System.Drawing.Size(120, 51);
            this.botonAppMultiplos.TabIndex = 0;
            this.botonAppMultiplos.Text = "Calcular";
            this.botonAppMultiplos.UseVisualStyleBackColor = true;
            this.botonAppMultiplos.Click += new System.EventHandler(this.botonAppMultiplos_Click);
            // 
            // etiqIntroducNumApp2
            // 
            this.etiqIntroducNumApp2.AutoSize = true;
            this.etiqIntroducNumApp2.Location = new System.Drawing.Point(140, 221);
            this.etiqIntroducNumApp2.Name = "etiqIntroducNumApp2";
            this.etiqIntroducNumApp2.Size = new System.Drawing.Size(169, 20);
            this.etiqIntroducNumApp2.TabIndex = 1;
            this.etiqIntroducNumApp2.Text = "Introduzca un número:";
            // 
            // textIntroducNumApp2
            // 
            this.textIntroducNumApp2.Location = new System.Drawing.Point(358, 218);
            this.textIntroducNumApp2.MaxLength = 9;
            this.textIntroducNumApp2.Name = "textIntroducNumApp2";
            this.textIntroducNumApp2.Size = new System.Drawing.Size(172, 26);
            this.textIntroducNumApp2.TabIndex = 2;
            // 
            // etiqDescApp2
            // 
            this.etiqDescApp2.AutoSize = true;
            this.etiqDescApp2.Location = new System.Drawing.Point(30, 90);
            this.etiqDescApp2.Name = "etiqDescApp2";
            this.etiqDescApp2.Size = new System.Drawing.Size(671, 60);
            this.etiqDescApp2.TabIndex = 3;
            this.etiqDescApp2.Text = resources.GetString("etiqDescApp2.Text");
            // 
            // FrmAplicacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 544);
            this.Controls.Add(this.etiqDescApp2);
            this.Controls.Add(this.textIntroducNumApp2);
            this.Controls.Add(this.etiqIntroducNumApp2);
            this.Controls.Add(this.botonAppMultiplos);
            this.Name = "FrmAplicacion2";
            this.Text = "Aplicación 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAppMultiplos;
        private System.Windows.Forms.Label etiqIntroducNumApp2;
        private System.Windows.Forms.TextBox textIntroducNumApp2;
        private System.Windows.Forms.Label etiqDescApp2;
    }
}

