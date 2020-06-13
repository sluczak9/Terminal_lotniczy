namespace Terminal_lotniczy
{
    partial class FormTerminal
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTerminal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPromocja = new System.Windows.Forms.Label();
            this.labelNajniższa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(287, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rejestracja lotów";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(287, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rejestracja pasażerów";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // labelPromocja
            // 
            this.labelPromocja.AutoSize = true;
            this.labelPromocja.Location = new System.Drawing.Point(70, 206);
            this.labelPromocja.Name = "labelPromocja";
            this.labelPromocja.Size = new System.Drawing.Size(0, 20);
            this.labelPromocja.TabIndex = 3;
            // 
            // labelNajniższa
            // 
            this.labelNajniższa.AutoSize = true;
            this.labelNajniższa.Location = new System.Drawing.Point(277, 206);
            this.labelNajniższa.Name = "labelNajniższa";
            this.labelNajniższa.Size = new System.Drawing.Size(0, 20);
            this.labelNajniższa.TabIndex = 4;
            this.labelNajniższa.Click += new System.EventHandler(this.labelNajniższa_Click);
            // 
            // FormTerminal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(651, 235);
            this.Controls.Add(this.labelNajniższa);
            this.Controls.Add(this.labelPromocja);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormTerminal";
            this.Text = "Terminal lotniczy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTerminal_FormClosing);
            this.Load += new System.EventHandler(this.FormTerminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelPromocja;
        private System.Windows.Forms.Label labelNajniższa;
    }
}

