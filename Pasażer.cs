using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_lotniczy
{
    class Pasażer
    {
        private string imie, nazwisko;
        private DateTime dataUrodzenia, dataWaznosciPaszportu;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public DateTime DataWaznosciPaszportu { get => dataWaznosciPaszportu; set => dataWaznosciPaszportu = value; }
    }
}
