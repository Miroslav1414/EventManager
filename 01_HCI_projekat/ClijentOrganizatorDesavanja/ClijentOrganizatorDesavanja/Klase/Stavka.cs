using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClijentOrganizatorDesavanja
{
    class Stavka
    {
        public string vrsta { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string lokacija { get; set; }
        public string datumPocetka { get; set; }
        public string datumZavrsetka { get; set; }
        public string vrijemePocetka { get; set; }
        public string vrijemeZavrsetka { get; set; }
        public string id { get; set; }
        public List<Element> listaElemenata;

        public Stavka(string naziv, string vrsta, string lokacija, string opis,
            string datumPocetka, string vrijemePocetka, string datumZavrsetka,
            string vrijemeZavrsetka, string id)
        {
            this.vrsta = vrsta;
            this.naziv = naziv;
            this.opis = opis;
            this.lokacija = lokacija;
            this.datumPocetka = datumPocetka.Split(' ')[0]; ;
            this.datumZavrsetka = datumZavrsetka.Split(' ')[0]; ;
            this.vrijemePocetka = vrijemePocetka;
            this.vrijemeZavrsetka = vrijemeZavrsetka;
            this.id = id;
            listaElemenata = new List<Element>();
        }




    }
}
