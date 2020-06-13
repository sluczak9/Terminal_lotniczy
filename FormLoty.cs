using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal_lotniczy
{
    public partial class FormLoty : Form
    {
        bool wyjscie = false;
        public FormLoty()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Lot.ListaLotów.Count>0)
            {
                foreach (Lot lo in Lot.ListaLotów)
                {
                    listBox1.Items.Add(lo);
                }
                    
            }
        }

        private void ButtonLot_Click(object sender, EventArgs e)
        {
            Lot l = new Lot();
            bool brakNazwy = string.IsNullOrWhiteSpace(textBoxKierunek.Text);
            bool brakNazwy2 = string.IsNullOrWhiteSpace(textBoxLinia.Text);
            if (brakNazwy)
            {
                MessageBox.Show("Pole Kierunek nie może być puste");
            }
            else
            {
                if (brakNazwy2)
                {
                    MessageBox.Show("Pole Model nie może być puste");
                }
                else
                {
                    if (dateTimePickerLotData.Value.Date + dateTimePickerLotCzas.Value.TimeOfDay < DateTime.Now)
                    {
                        MessageBox.Show("Lot nie może odbyć się w przeszłości! To niemożliwe");
                    }
                    else
                    {
                        l.Linia = textBoxLinia.Text;
                        l.Kierunek = textBoxKierunek.Text;
                        l.DataLotu = dateTimePickerLotData.Value.Date + dateTimePickerLotCzas.Value.TimeOfDay;
                        l.Cena = (int)numericUpDownCena.Value;
                        l.CzasLotu = (int)numericUpDownCzas.Value;
                        Lot.ListaLotów.Add(l);

                        listBox1.Items.Add(l);
                        wyświetl();
                    }

                }
            }


        }

        void wyświetl()
        {
            //listBox1.Items.Clear();
            textBoxLinia.Clear();
            textBoxKierunek.Clear();
            dateTimePickerLotData.Value = DateTime.Today;
            numericUpDownCena.Value = 100;
            numericUpDownCzas.Value = 30;
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            wyjscie = true;
            FormTerminal o1 = new FormTerminal();
            o1.Show();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ButtonUsun_Click(object sender, EventArgs e)
        {
            int pozycja = listBox1.SelectedIndex;
            if (pozycja > -1 && listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(pozycja);
                Lot.ListaLotów.RemoveAt(pozycja);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
