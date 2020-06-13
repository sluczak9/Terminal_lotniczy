namespace Terminal_lotniczy
{
    partial class FormLoty
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerLotCzas = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCzas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCena = new System.Windows.Forms.NumericUpDown();
            this.buttonLot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerLotData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKierunek = new System.Windows.Forms.TextBox();
            this.textBoxLinia = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCena)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(326, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(571, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerLotCzas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownCzas);
            this.groupBox1.Controls.Add(this.numericUpDownCena);
            this.groupBox1.Controls.Add(this.buttonLot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerLotData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxKierunek);
            this.groupBox1.Controls.Add(this.textBoxLinia);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarejstruj lot";
            // 
            // dateTimePickerLotCzas
            // 
            this.dateTimePickerLotCzas.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerLotCzas.Location = new System.Drawing.Point(181, 158);
            this.dateTimePickerLotCzas.Name = "dateTimePickerLotCzas";
            this.dateTimePickerLotCzas.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerLotCzas.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Czas lotu (min)";
            // 
            // numericUpDownCzas
            // 
            this.numericUpDownCzas.Location = new System.Drawing.Point(86, 286);
            this.numericUpDownCzas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCzas.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCzas.Name = "numericUpDownCzas";
            this.numericUpDownCzas.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownCzas.TabIndex = 10;
            this.numericUpDownCzas.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownCena
            // 
            this.numericUpDownCena.Location = new System.Drawing.Point(86, 228);
            this.numericUpDownCena.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCena.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCena.Name = "numericUpDownCena";
            this.numericUpDownCena.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownCena.TabIndex = 9;
            this.numericUpDownCena.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonLot
            // 
            this.buttonLot.Location = new System.Drawing.Point(9, 347);
            this.buttonLot.Name = "buttonLot";
            this.buttonLot.Size = new System.Drawing.Size(277, 23);
            this.buttonLot.TabIndex = 8;
            this.buttonLot.Text = "Zatwierdź";
            this.buttonLot.UseVisualStyleBackColor = true;
            this.buttonLot.Click += new System.EventHandler(this.ButtonLot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena lotu (zł)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data lotu";
            // 
            // dateTimePickerLotData
            // 
            this.dateTimePickerLotData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLotData.Location = new System.Drawing.Point(86, 158);
            this.dateTimePickerLotData.Name = "dateTimePickerLotData";
            this.dateTimePickerLotData.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerLotData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kierunek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa linii";
            // 
            // textBoxKierunek
            // 
            this.textBoxKierunek.Location = new System.Drawing.Point(86, 30);
            this.textBoxKierunek.Name = "textBoxKierunek";
            this.textBoxKierunek.Size = new System.Drawing.Size(200, 20);
            this.textBoxKierunek.TabIndex = 1;
            // 
            // textBoxLinia
            // 
            this.textBoxLinia.Location = new System.Drawing.Point(86, 89);
            this.textBoxLinia.Name = "textBoxLinia";
            this.textBoxLinia.Size = new System.Drawing.Size(200, 20);
            this.textBoxLinia.TabIndex = 0;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(83, 441);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(165, 23);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Powrót do Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.buttonUsun.Location = new System.Drawing.Point(555, 425);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(178, 28);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usuń zaznaczoną pozycję";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.ButtonUsun_Click);
            // 
            // FormLoty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 482);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormLoty";
            this.Text = "Rejestracja lotów";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKierunek;
        private System.Windows.Forms.TextBox textBoxLinia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerLotData;
        private System.Windows.Forms.Button buttonLot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCzas;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.DateTimePicker dateTimePickerLotCzas;
        private System.Windows.Forms.Button buttonUsun;
    }
}