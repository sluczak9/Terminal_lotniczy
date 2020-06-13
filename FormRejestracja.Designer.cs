namespace Terminal_lotniczy
{
    partial class FormRejestracja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonZakup = new System.Windows.Forms.Button();
            this.dateTimePickerPaszport = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerUro = new System.Windows.Forms.DateTimePicker();
            this.comboBoxLot = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.listBoxRezerwacja = new System.Windows.Forms.ListBox();
            this.buttonBilet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonZakup);
            this.groupBox1.Controls.Add(this.dateTimePickerPaszport);
            this.groupBox1.Controls.Add(this.dateTimePickerUro);
            this.groupBox1.Controls.Add(this.comboBoxLot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxImie);
            this.groupBox1.Controls.Add(this.textBoxNazwisko);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(625, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wpisz swoje dane";
            // 
            // buttonZakup
            // 
            this.buttonZakup.Location = new System.Drawing.Point(139, 217);
            this.buttonZakup.Name = "buttonZakup";
            this.buttonZakup.Size = new System.Drawing.Size(91, 23);
            this.buttonZakup.TabIndex = 12;
            this.buttonZakup.Text = "Zatwierdź";
            this.buttonZakup.UseVisualStyleBackColor = true;
            this.buttonZakup.Click += new System.EventHandler(this.ButtonZakup_Click);
            // 
            // dateTimePickerPaszport
            // 
            this.dateTimePickerPaszport.Location = new System.Drawing.Point(138, 119);
            this.dateTimePickerPaszport.Name = "dateTimePickerPaszport";
            this.dateTimePickerPaszport.Size = new System.Drawing.Size(384, 20);
            this.dateTimePickerPaszport.TabIndex = 11;
            // 
            // dateTimePickerUro
            // 
            this.dateTimePickerUro.Location = new System.Drawing.Point(139, 84);
            this.dateTimePickerUro.Name = "dateTimePickerUro";
            this.dateTimePickerUro.Size = new System.Drawing.Size(383, 20);
            this.dateTimePickerUro.TabIndex = 10;
            // 
            // comboBoxLot
            // 
            this.comboBoxLot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLot.FormattingEnabled = true;
            this.comboBoxLot.Location = new System.Drawing.Point(139, 154);
            this.comboBoxLot.Name = "comboBoxLot";
            this.comboBoxLot.Size = new System.Drawing.Size(383, 21);
            this.comboBoxLot.TabIndex = 9;
            this.comboBoxLot.SelectedIndexChanged += new System.EventHandler(this.comboBoxLot_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wybrany lot";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(139, 13);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(383, 20);
            this.textBoxImie.TabIndex = 7;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(139, 49);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(383, 20);
            this.textBoxNazwisko.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data ważności paszportu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data urodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj imię";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz lot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Zaznacz wybrany w dniu lot";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Wybierz lot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 90);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(600, 121);
            this.listBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sprawdź loty w tym dniu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(211, 13);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Wybierz datę lotu";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(521, 487);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(165, 23);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "Powrót do Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // listBoxRezerwacja
            // 
            this.listBoxRezerwacja.FormattingEnabled = true;
            this.listBoxRezerwacja.Location = new System.Drawing.Point(6, 300);
            this.listBoxRezerwacja.Name = "listBoxRezerwacja";
            this.listBoxRezerwacja.Size = new System.Drawing.Size(1137, 121);
            this.listBoxRezerwacja.TabIndex = 4;
            this.listBoxRezerwacja.SelectedIndexChanged += new System.EventHandler(this.listBoxRezerwacja_SelectedIndexChanged);
            // 
            // buttonBilet
            // 
            this.buttonBilet.Location = new System.Drawing.Point(521, 458);
            this.buttonBilet.Name = "buttonBilet";
            this.buttonBilet.Size = new System.Drawing.Size(165, 23);
            this.buttonBilet.TabIndex = 5;
            this.buttonBilet.Text = "Wydrukuj bilet";
            this.buttonBilet.UseVisualStyleBackColor = true;
            this.buttonBilet.Click += new System.EventHandler(this.ButtonBilet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.label8.Location = new System.Drawing.Point(516, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Podsumowanie";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Wykasuj zaznaczony lot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // FormRejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonBilet);
            this.Controls.Add(this.listBoxRezerwacja);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRejestracja";
            this.Text = "Rejestracja na lot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.FormRejestracja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaszport;
        private System.Windows.Forms.DateTimePicker dateTimePickerUro;
        private System.Windows.Forms.ComboBox comboBoxLot;
        private System.Windows.Forms.Button buttonZakup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ListBox listBoxRezerwacja;
        private System.Windows.Forms.Button buttonBilet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}