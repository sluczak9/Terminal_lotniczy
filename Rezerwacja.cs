using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_lotniczy
{
    class Rezerwacja
    {
        static List<Rezerwacja> listaRezerwacji = new List<Rezerwacja>();
        Pasażer pasażer;
        Lot lot;
        private DateTime dataRezerwacji;
        
        public static string Podsumowanie()
        {
            var en = Environment.NewLine;
            int i = 0;
            string bilet = "";
            bilet = "Bilet zakupiono " + DateTime.Now + en + en;
            foreach (Rezerwacja rezerwacja in listaRezerwacji)
            {
                i++;
                bilet += "Bilet " + i + en;
                bilet += "Kierunek: " + rezerwacja.Lot.Kierunek + en;
                bilet += "Imię i nazwisko pasażera: " + rezerwacja.Pasażer.Imie + " " + rezerwacja.Pasażer.Nazwisko + en;
                bilet += "Cena przelotu: " + rezerwacja.Lot.Cena + en;
                bilet += "Data lotu: " + rezerwacja.Lot.DataLotu + en;
                bilet += "Czas lotu: " + rezerwacja.Lot.CzasLotu + " min" + en;
                bilet += "Model samlotu: " + rezerwacja.Lot.Linia + en + en;

            }
            return bilet;
        }

        internal static List<Rezerwacja> ListaRezerwacji { get => listaRezerwacji; set => listaRezerwacji = value; }
        public DateTime DataRezerwacji { get => dataRezerwacji; set => dataRezerwacji = value; }
        internal Pasażer Pasażer { get => pasażer; set => pasażer = value; }
        internal Lot Lot { get => lot; set => lot = value; }

        public override string ToString()
        {
            return  Pasażer.Imie + " " + Pasażer.Nazwisko + ", Data urodzenia: " + Pasażer.DataUrodzenia.ToShortDateString() + ", Data ważności paszportu: " + Pasażer.DataWaznosciPaszportu.ToShortDateString() + ", Kierunek: " + Lot.Kierunek + ", Model: " + Lot.Linia + ", Data lotu: " + Lot.DataLotu + ", Cena: " + Lot.Cena + "zł, Czas lotu " + Lot.CzasLotu + "min";
        }
    }
}
