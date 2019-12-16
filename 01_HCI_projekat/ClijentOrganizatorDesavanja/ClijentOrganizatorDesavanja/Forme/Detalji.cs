using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClijentOrganizatorDesavanja
{
    public partial class Detalji : Form
    {
        public Detalji()
        {
            InitializeComponent();
        }

        public void popuniPodatke(string naziv,string vrsta, string lokacija,string vrijemePocetka,
            string vrijemeZavrsetka,string opis) {
            txtNaziv.Text = naziv;
            txtVrsta.Text = vrsta;
            txtLokacija.Text = lokacija;
            txtVrijemePocetka.Text = vrijemePocetka;
            txtVrijemeZavrsetka.Text = vrijemeZavrsetka;
            txtOpis.Text = opis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.DialogResult = DialogResult.OK;
                this.Close(); 
        }
    }
}
