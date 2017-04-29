namespace NavajaSuiza
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonApp1 = new System.Windows.Forms.Button();
            this.botonApp4 = new System.Windows.Forms.Button();
            this.botonApp3 = new System.Windows.Forms.Button();
            this.botonApp2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // botonApp1
            // 
            this.botonApp1.Location = new System.Drawing.Point(54, 77);
            this.botonApp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonApp1.Name = "botonApp1";
            this.botonApp1.Size = new System.Drawing.Size(183, 106);
            this.botonApp1.TabIndex = 1;
            this.botonApp1.Text = "Aplicación 1";
            this.botonApp1.UseVisualStyleBackColor = true;
            this.botonApp1.Click += new System.EventHandler(this.botonApp1_Click);
            // 
            // botonApp4
            // 
            this.botonApp4.Location = new System.Drawing.Point(729, 435);
            this.botonApp4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonApp4.Name = "botonApp4";
            this.botonApp4.Size = new System.Drawing.Size(183, 106);
            this.botonApp4.TabIndex = 2;
            this.botonApp4.Text = "Aplicación 4";
            this.botonApp4.UseVisualStyleBackColor = true;
            this.botonApp4.Click += new System.EventHandler(this.botonApp4_Click);
            // 
            // botonApp3
            // 
            this.botonApp3.Location = new System.Drawing.Point(54, 435);
            this.botonApp3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonApp3.Name = "botonApp3";
            this.botonApp3.Size = new System.Drawing.Size(183, 106);
            this.botonApp3.TabIndex = 3;
            this.botonApp3.Text = "Aplicación 3";
            this.botonApp3.UseVisualStyleBackColor = true;
            this.botonApp3.Click += new System.EventHandler(this.botonApp3_Click);
            // 
            // botonApp2
            // 
            this.botonApp2.Location = new System.Drawing.Point(742, 77);
            this.botonApp2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonApp2.Name = "botonApp2";
            this.botonApp2.Size = new System.Drawing.Size(183, 106);
            this.botonApp2.TabIndex = 4;
            this.botonApp2.Text = "Aplicación 2";
            this.botonApp2.UseVisualStyleBackColor = true;
            this.botonApp2.Click += new System.EventHandler(this.botonApp2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.botonApp2);
            this.Controls.Add(this.botonApp3);
            this.Controls.Add(this.botonApp4);
            this.Controls.Add(this.botonApp1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Navaja Suiza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonApp1;
        private System.Windows.Forms.Button botonApp4;
        private System.Windows.Forms.Button botonApp3;
        private System.Windows.Forms.Button botonApp2;
    }
}

