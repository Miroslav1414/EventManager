using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClijentOrganizatorDesavanja
{
    class Nalog
    {
        string _ime;
        string _prezime;
        string _korisnickoIme;

        public Nalog(string ime, string prezime,string korisnickoIme) {
            _ime = ime;
            _prezime = prezime;
            _korisnickoIme = korisnickoIme;
        }

        public void setIme(string ime) {
            _ime = ime;
        }
        public void setKorisnickoIme(string korisnickoIme)
        {
            _korisnickoIme = korisnickoIme;
        }
        public void setPrezime(string prezime)
        {
            _prezime = prezime;
        }
        public string getIme() {
            return _ime;
        }
        public string getPrezme()
        {
            return _prezime;
        }
        public string getKorisnickoIme()
        {
            return _korisnickoIme;
        }
    }
}
