using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClijentOrganizatorDesavanja
{
    class Desavanje
    {
        public string vrsta { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string lokacija { get; set; }
        public string datumPocetka { get; set; }
        public string datumZavrsetka { get; set; }
        public string vrijemePocetka { get; set; }
        public string vrijemeZavrsetka { get; set; }
        public string privatno { get; set; }
        public string id { get; set; }
        public List<Stavka> listaStavki { get; set; }

        public Desavanje(string naziv, string vrsta, string lokacija, string opis, string privatno,
            string datumPocetka, string vrijemePocetka, string datumZavrsetka, 
            string vrijemeZavrsetka,string id) {
            this.vrsta = vrsta;
            this.naziv = naziv;
            this.opis = opis;
            this.lokacija = lokacija;
            this.datumPocetka = datumPocetka.Split(' ')[0];
            this.datumZavrsetka = datumZavrsetka.Split(' ')[0];
            this.vrijemePocetka = vrijemePocetka;
            this.vrijemeZavrsetka = vrijemeZavrsetka;
            this.privatno = privatno;
            this.id = id;
            listaStavki = new List<Stavka>();
    }




    }
}
