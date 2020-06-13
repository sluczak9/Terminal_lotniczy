using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal_lotniczy
{
    public partial class FormRejestracja : Form
    {
        bool wyjscie = false;
        public FormRejestracja()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            bool a=false;
            foreach (Lot lo in Lot.ListaLotów)
            {
                if (0 == lo.DataLotu.Date.CompareTo(dateTimePicker3.Value.Date))
                {
                    listBox2.Items.Add(lo);
                    a = true;
                }
            }
            if (!a)
            {
                MessageBox.Show("Niestety, nie ma lotów w tym dniu");
            }




        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            wyjscie = true;
            FormTerminal o1 = new FormTerminal();
            o1.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            comboBoxLot.Items.Clear();
            int pozycja = listBox2.SelectedIndex;

            if (pozycja > -1 && listBox2.SelectedItem != null)
            {
                comboBoxLot.Items.Add(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nie został zaznaczony żaden lot");
            }
        }

        private void ButtonZakup_Click(object sender, EventArgs e)
        {
            bool brakLotu = string.IsNullOrWhiteSpace(comboBoxLot.Text);
            Rezerwacja r = new Rezerwacja();
            DateTime h;
            h = ((comboBoxLot.SelectedItem as Lot).DataLotu);
            bool brakNazwy = string.IsNullOrWhiteSpace(textBoxImie.Text);
            bool brakNazwy2 = string.IsNullOrWhiteSpace(textBoxNazwisko.Text);
                if (comboBoxLot.Text == " ")
                {
                    MessageBox.Show("Pole wybrany lot nie może być puste");
                }
                else
            if (brakNazwy)
            {
                MessageBox.Show("Pole imie nie może być puste");
            }
            else
            {
                if (brakNazwy2)
                {
                    MessageBox.Show("Pole nazwisko nie może być puste");
                }
                else
                {
                    if (dateTimePickerUro.Value > DateTime.Now)
                    {
                        MessageBox.Show("Data urodzenia nie może być starsza od dzisiejszej daty");
                    }
                    else
                    {

                        if (h > dateTimePickerPaszport.Value)
                        {
                            MessageBox.Show("Termin ważności paszportu został przekroczony");
                        }
                            else
                            {
                                r.Pasażer = new Pasażer();
                                r.Pasażer.Imie = textBoxImie.Text;
                                r.Pasażer.Nazwisko = textBoxNazwisko.Text;
                                r.Pasażer.DataUrodzenia = dateTimePickerUro.Value.Date;
                                r.Pasażer.DataWaznosciPaszportu = dateTimePickerPaszport.Value.Date;
                                r.Lot = comboBoxLot.SelectedItem as Lot;
                                listBoxRezerwacja.Items.Add(r);
                                Rezerwacja.ListaRezerwacji.Add(r);
                            }

                    }

                }
            }


        }

        private void ButtonBilet_Click(object sender, EventArgs e)
        {
            if(listBoxRezerwacja.Items.Count == 0)
            {
                MessageBox.Show("W rezerwacjach nie ma żadnego lotu");
            }
            else
            {
                string komunikat = Rezerwacja.Podsumowanie();
                SaveFileDialog plik = new SaveFileDialog();
                DialogResult czyWybranoPlik = plik.ShowDialog();
                if (czyWybranoPlik == DialogResult.OK)
                {
                    string nazwaPliku = plik.FileName;
                    nazwaPliku = nazwaPliku + ".txt";
                    string zapisz = komunikat;
                    File.WriteAllText(nazwaPliku, komunikat);
                }
            }

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!wyjscie)
            {
                Application.Exit();
            }
            else
            {
                wyjscie = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int pozycja = listBoxRezerwacja.SelectedIndex;
            if (pozycja > -1 && listBoxRezerwacja.SelectedItem != null)
            {
                listBoxRezerwacja.Items.RemoveAt(pozycja);
                Rezerwacja.ListaRezerwacji.RemoveAt(pozycja);
            }
            else
            {
                MessageBox.Show("Nie został zaznaczony żaden lot");
            }
        }

        private void comboBoxLot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRejestracja_Load(object sender, EventArgs e)
        {

        }

        private void listBoxRezerwacja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
