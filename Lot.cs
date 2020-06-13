using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_lotniczy
{
    class Lot
    {
        static List<Lot> listaLotów = new List<Lot>();
        private string linia, kierunek;
        private DateTime dataLotu;
        private int cena, czasLotu;

        internal static List<Lot> ListaLotów { get => listaLotów; set => listaLotów = value; }
        public string Linia { get => linia; set => linia = value; }
        public string Kierunek { get => kierunek; set => kierunek = value; }
        public DateTime DataLotu { get => dataLotu; set => dataLotu = value; }
        public int Cena { get => cena; set => cena = value; }
        public int CzasLotu { get => czasLotu; set => czasLotu = value; }

        public override string ToString()
        {
            return "Kierunek: " + Kierunek + " Linia: " + Linia + " Data lotu: " + DataLotu + " Cena: " + Cena + "zł Czas lotu" + CzasLotu + "min"; 
        }

    }
}
