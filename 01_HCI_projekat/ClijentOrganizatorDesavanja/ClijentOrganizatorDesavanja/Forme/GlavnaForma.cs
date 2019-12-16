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
    public partial class GlavnaForma : Form
    {
        public void dodajMojaDesavanja() {
            String ulaz = "";
            //primanje projekata
            Program.mojaDesavanja.Clear();

            Program.client.println("MOJA_DESAVANJA#" + Program.nalog.getKorisnickoIme());

            while (!((ulaz = Program.client.readLine()).Equals("KRAJ_DESAVANJA")))
            {
                Program.mojaDesavanja.Add(new Desavanje(ulaz.Split('#')[0], ulaz.Split('#')[1],
                    ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                    ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                    ulaz.Split('#')[9]));
            }
            //primanje stavki
            foreach (Desavanje des in Program.mojaDesavanja)
            {
                Program.client.println("MOJE_STAVKE#" + des.id);
                while (!((ulaz = Program.client.readLine()).Equals("KRAJ_STAVKI")))
                {
                    des.listaStavki.Add(new Stavka(ulaz.Split('#')[0], ulaz.Split('#')[1],
                        ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8]));
                }
            }
            //primanje elemenata
            foreach (Desavanje des in Program.mojaDesavanja)
            {
                foreach (Stavka stav in des.listaStavki)
                {
                    Program.client.println("MOJI_ELEMENTI#" + stav.id);
                    while (!((ulaz = Program.client.readLine()).Equals("KRAJ_ELEMENATA")))
                    {
                        stav.listaElemenata.Add(new Element(ulaz.Split('#')[0], ulaz.Split('#')[1],
                            ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                            ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8]));
                    }
                }
            }

            treeMojaDesavanja.Nodes.Clear();
            int brojac1 = -1, brojac2 = -1;
            foreach (Desavanje des in Program.mojaDesavanja)
            {
                brojac1++;
                brojac2 = -1;
                treeMojaDesavanja.Nodes.Add("1",des.naziv,0);
                foreach (Stavka stav in des.listaStavki)
                {
                    brojac2++;
                    treeMojaDesavanja.Nodes[brojac1].Nodes.Add("2",stav.naziv,1);
                    foreach (Element ele in stav.listaElemenata)
                    {
                        treeMojaDesavanja.Nodes[brojac1].Nodes[brojac2].Nodes.Add("3",ele.naziv,2);
                    }
                }
            }

        }

        public void dodajSvaDesavanja() {

            String ulaz = "";
            //primanje projekata
            Program.svaDesavanja.Clear();

            Program.client.println("SVA_DESAVANJA#" + Program.nalog.getKorisnickoIme());

            while (!((ulaz = Program.client.readLine()).Equals("KRAJ_DESAVANJA")))
            {
                Program.svaDesavanja.Add(new Desavanje(ulaz.Split('#')[0], ulaz.Split('#')[1],
                    ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                    ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                    ulaz.Split('#')[9]));
            }
            //primanje stavki
            foreach (Desavanje des in Program.svaDesavanja)
            {
                Program.client.println("MOJE_STAVKE#" + des.id);
                while (!((ulaz = Program.client.readLine()).Equals("KRAJ_STAVKI")))
                {
                    des.listaStavki.Add(new Stavka(ulaz.Split('#')[0], ulaz.Split('#')[1],
                        ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8]));
                }
            }
            //primanje elemenata
            foreach (Desavanje des in Program.svaDesavanja)
            {
                foreach (Stavka stav in des.listaStavki)
                {
                    Program.client.println("MOJI_ELEMENTI#" + stav.id);
                    while (!((ulaz = Program.client.readLine()).Equals("KRAJ_ELEMENATA")))
                    {
                        stav.listaElemenata.Add(new Element(ulaz.Split('#')[0], ulaz.Split('#')[1],
                            ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                            ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8]));
                    }
                }
            }

            treeSvaDesavanja.Nodes.Clear();
            int brojac1 = -1, brojac2 = -1;
            foreach (Desavanje des in Program.svaDesavanja)
            {
                brojac1++;
                brojac2 = -1;
                treeSvaDesavanja.Nodes.Add("1",des.naziv,0);
                foreach (Stavka stav in des.listaStavki)
                {
                    brojac2++;
                    treeSvaDesavanja.Nodes[brojac1].Nodes.Add("2",stav.naziv,1);
                    foreach (Element ele in stav.listaElemenata)
                    {
                        treeSvaDesavanja.Nodes[brojac1].Nodes[brojac2].Nodes.Add("3",ele.naziv,2);
                    }
                }
            }

        }

        public void dodajObjavljenaDesavanja()
        {

            String ulaz = "";
            //primanje projekata
            Program.objavljena.Clear();

            Program.client.println("OBJAVLJENA_DESAVANJA#" + Program.nalog.getKorisnickoIme());

            while (!((ulaz = Program.client.readLine()).Equals("KRAJ_DESAVANJA")))
            {
                Program.objavljena.Add(new Desavanje(ulaz.Split('#')[0], ulaz.Split('#')[1],
                    ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                    ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                    ulaz.Split('#')[9]));
            }
            //primanje stavki
            foreach (Desavanje des in Program.objavljena)
            {
                Program.client.println("MOJE_STAVKE#" + des.id);
                while (!((ulaz = Program.client.readLine()).Equals("KRAJ_STAVKI")))
                {
                    des.listaStavki.Add(new Stavka(ulaz.Split('#')[0], ulaz.Split('#')[1],
                        ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8]));
                }
            }
            //primanje elemenata
            foreach (Desavanje des in Program.objavljena)
            {
                foreach (Stavka stav in des.listaStavki)
                {
                    Program.client.println("MOJI_ELEMENTI#" + stav.id);
                    while (!((ulaz = Program.client.readLine()).Equals("KRAJ_ELEMENATA")))
                    {
                        stav.listaElemenata.Add(new Element(ulaz.Split('#')[0], ulaz.Split('#')[1],
                            ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                            ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8]));
                    }
                }
            }

            treeObjavljena.Nodes.Clear();
            int brojac1 = -1, brojac2 = -1;
            foreach (Desavanje des in Program.objavljena)
            {
                brojac1++;
                brojac2 = -1;
                treeObjavljena.Nodes.Add("1",des.naziv,0);
                foreach (Stavka stav in des.listaStavki)
                {
                    brojac2++;
                    treeObjavljena.Nodes[brojac1].Nodes.Add("2", stav.naziv,1);
                    foreach (Element ele in stav.listaElemenata)
                    {
                        treeObjavljena.Nodes[brojac1].Nodes[brojac2].Nodes.Add("3",ele.naziv,2);
                    }
                }
            }

        }

        public void postaviImeIPrezime() {
            lblSetIme.Text = Program.nalog.getIme();
            lblSetPrezime.Text = Program.nalog.getPrezme();
        }


        public GlavnaForma()
        {
            InitializeComponent();
            dodajMojaDesavanja();
            dodajSvaDesavanja();
            dodajObjavljenaDesavanja();
            postaviImeIPrezime();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            Program.kreiranje = "KREIRAJ_DOGADJAJ#";
            KreirajDogadjaj dogadjaj = new KreirajDogadjaj();
            dogadjaj.ShowDialog();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            
            int br1=-1, br2 = -1;

            if (treeMojaDesavanja.SelectedNode.Level == 0)
            {
                br1 = treeMojaDesavanja.SelectedNode.Index;
                Program.kreiranje = "KREIRAJ_STAVKU#";
                KreirajDogadjaj dog = new KreirajDogadjaj();
                dog.setId(Program.mojaDesavanja.ElementAt(br1).id);
                dog.ShowDialog();
            }
            else if (treeMojaDesavanja.SelectedNode.Level == 1)
            {
                br1 = treeMojaDesavanja.SelectedNode.Parent.Index;
                br2 = treeMojaDesavanja.SelectedNode.Index;
                Program.kreiranje = "KREIRAJ_ELEMENT#";
                KreirajDogadjaj dog = new KreirajDogadjaj();
                dog.setId(Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).id);
                dog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Samo dogadjaji i stavke mogu imati pod elemente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeMojaDesavanja_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnPromjeni.Enabled = true;
            btnDetalji.Enabled = true;
            btnIzbrisi.Enabled = true;
            if (treeMojaDesavanja.SelectedNode.Level == 0)
            {
                btnIzmijeni.Enabled = true;
            }

            else
                btnIzmijeni.Enabled = false;

            if (treeMojaDesavanja.SelectedNode.Level == 2)
                btnDodajStavku.Enabled = false;
            else
            btnDodajStavku.Enabled = true;
        }
        

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            int br1, br2, br3;
            Detalji detalji = new Detalji();
            if (treeMojaDesavanja.SelectedNode.Level == 0)
            {
                br1 = treeMojaDesavanja.SelectedNode.Index;
                detalji.popuniPodatke(Program.mojaDesavanja.ElementAt(br1).naziv,
                    Program.mojaDesavanja.ElementAt(br1).vrsta, Program.mojaDesavanja.ElementAt(br1).lokacija,
                    Program.mojaDesavanja.ElementAt(br1).datumPocetka + " " + Program.mojaDesavanja.ElementAt(br1).vrijemePocetka,
                    Program.mojaDesavanja.ElementAt(br1).datumZavrsetka+ " " + Program.mojaDesavanja.ElementAt(br1).vrijemeZavrsetka,
                    Program.mojaDesavanja.ElementAt(br1).opis);
            }
            else if (treeMojaDesavanja.SelectedNode.Level == 1)
            {
                br1 = treeMojaDesavanja.SelectedNode.Parent.Index;
                br2 = treeMojaDesavanja.SelectedNode.Index;

                detalji.popuniPodatke(Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).naziv,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrsta,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).lokacija,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).datumPocetka + " "
                    + Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrijemePocetka,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).datumZavrsetka + " "
                    + Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrijemeZavrsetka,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).opis);
            }
            else
            {
                br1 = treeMojaDesavanja.SelectedNode.Parent.Parent.Index;
                br2 = treeMojaDesavanja.SelectedNode.Parent.Index;
                br3 = treeMojaDesavanja.SelectedNode.Index;

                detalji.popuniPodatke(Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).naziv,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrsta,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).lokacija,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumPocetka + " "
                    + Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemePocetka,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumZavrsetka + " "
                    + Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemeZavrsetka,
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).opis);
            }
               detalji.ShowDialog();
        }

        private void treeSvaDesavanja_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ( treeSvaDesavanja.SelectedNode == null)
                btnDetaljiSve.Enabled = false;
            btnDetaljiSve.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int br1, br2, br3;
            Detalji detalji = new Detalji();
            if (treeSvaDesavanja.SelectedNode.Level == 0)
            {
                br1 = treeSvaDesavanja.SelectedNode.Index;
                detalji.popuniPodatke(Program.svaDesavanja.ElementAt(br1).naziv,
                    Program.svaDesavanja.ElementAt(br1).vrsta, Program.svaDesavanja.ElementAt(br1).lokacija,
                    Program.svaDesavanja.ElementAt(br1).datumPocetka + " " + Program.svaDesavanja.ElementAt(br1).vrijemePocetka,
                    Program.svaDesavanja.ElementAt(br1).datumZavrsetka + " " + Program.svaDesavanja.ElementAt(br1).vrijemeZavrsetka,
                    Program.svaDesavanja.ElementAt(br1).opis);
            }
            else if (treeSvaDesavanja.SelectedNode.Level == 1)
            {
                br1 = treeSvaDesavanja.SelectedNode.Parent.Index;
                br2 = treeSvaDesavanja.SelectedNode.Index;

                detalji.popuniPodatke(Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).naziv,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrsta,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).lokacija,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).datumPocetka + " "
                    + Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrijemePocetka,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).datumZavrsetka + " "
                    + Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrijemeZavrsetka,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).opis);
            }
            else
            {
                br1 = treeSvaDesavanja.SelectedNode.Parent.Parent.Index;
                br2 = treeSvaDesavanja.SelectedNode.Parent.Index;
                br3 = treeSvaDesavanja.SelectedNode.Index;

                detalji.popuniPodatke(Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).naziv,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrsta,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).lokacija,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumPocetka + " "
                    + Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemePocetka,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumZavrsetka + " "
                    + Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemeZavrsetka,
                    Program.svaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).opis);
            }
            detalji.ShowDialog();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            Program.glavnaForma.dodajSvaDesavanja();
            btnDetaljiSve.Enabled = false;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            int br = treeMojaDesavanja.SelectedNode.Index;
            Program.client.println("OBJAVI#"+ Program.mojaDesavanja.ElementAt(br).id);
            if (Program.client.readLine().Equals("uspjesno"))
            {
                MessageBox.Show("Uspjesno objavljeno.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.glavnaForma.dodajMojaDesavanja();
                Program.glavnaForma.dodajObjavljenaDesavanja();
                btnDetalji.Enabled = false;
                btnDodajStavku.Enabled = false;
                btnIzbrisi.Enabled = false;
                btnIzmijeni.Enabled = false;
            }
            else
                MessageBox.Show("Došlo je do greške", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                int br1, br2, br3;
                Detalji detalji = new Detalji();
                if (treeObjavljena.SelectedNode.Level == 0)
                {
                    br1 = treeObjavljena.SelectedNode.Index;
                    detalji.popuniPodatke(Program.objavljena.ElementAt(br1).naziv,
                        Program.objavljena.ElementAt(br1).vrsta, Program.objavljena.ElementAt(br1).lokacija,
                        Program.objavljena.ElementAt(br1).datumPocetka + " " + Program.objavljena.ElementAt(br1).vrijemePocetka,
                        Program.objavljena.ElementAt(br1).datumZavrsetka + " " + Program.objavljena.ElementAt(br1).vrijemeZavrsetka,
                        Program.objavljena.ElementAt(br1).opis);
                }
                else if (treeObjavljena.SelectedNode.Level == 1)
                {
                    br1 = treeObjavljena.SelectedNode.Parent.Index;
                    br2 = treeObjavljena.SelectedNode.Index;

                    detalji.popuniPodatke(Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).naziv,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).vrsta,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).lokacija,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).datumPocetka + " "
                        + Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).vrijemePocetka,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).datumZavrsetka + " "
                        + Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).vrijemeZavrsetka,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).opis);
                }
                else
                {
                    br1 = treeObjavljena.SelectedNode.Parent.Parent.Index;
                    br2 = treeObjavljena.SelectedNode.Parent.Index;
                    br3 = treeObjavljena.SelectedNode.Index;

                    detalji.popuniPodatke(Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).naziv,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrsta,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).lokacija,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumPocetka + " "
                        + Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemePocetka,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumZavrsetka + " "
                        + Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemeZavrsetka,
                        Program.objavljena.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).opis);
                }
                detalji.ShowDialog();
            }
        }

        private void treeObjavljena_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeObjavljena.SelectedNode.Index <0)
                btnDetaljiObjavljena.Enabled = false;
            else btnDetaljiObjavljena.Enabled = true;

            if (treeObjavljena.SelectedNode.Level == 0)
            {
                btnZavrsi.Enabled = true;
                btnOtkazi.Enabled = true;
            }
            else {
                btnZavrsi.Enabled = false;
                btnOtkazi.Enabled = false;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {

            int br = treeObjavljena.SelectedNode.Index;
            Program.client.println("OTKAZI#" + Program.objavljena.ElementAt(br).id);
            if (Program.client.readLine().Equals("uspjesno"))
            {
                MessageBox.Show("Uspješno otkazano.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.glavnaForma.dodajMojaDesavanja();
                Program.glavnaForma.dodajObjavljenaDesavanja();
                btnDetaljiObjavljena.Enabled = false;
                btnOtkazi.Enabled = false;
                btnZavrsi.Enabled = false;
            }
            else
                MessageBox.Show("Došlo je do greške", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {

            int br = treeObjavljena.SelectedNode.Index;
            Program.client.println("ZAVRSI#" + Program.objavljena.ElementAt(br).id);
            if (Program.client.readLine().Equals("uspjesno"))
            {
                MessageBox.Show("Uspješno završeno.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.glavnaForma.dodajMojaDesavanja();
                Program.glavnaForma.dodajObjavljenaDesavanja();
                btnDetaljiObjavljena.Enabled = false;
                btnOtkazi.Enabled = false;
                btnZavrsi.Enabled = false;
            }
            else
                MessageBox.Show("Doslo je do greske", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            int br1, br2, br3;
            Detalji detalji = new Detalji();
            if (treeMojaDesavanja.SelectedNode.Level == 0)
            {
                br1 = treeMojaDesavanja.SelectedNode.Index;
                Program.client.println("BRISI_DESAVANJE# " + Program.mojaDesavanja.ElementAt(br1).id);
                
            }
            else if (treeMojaDesavanja.SelectedNode.Level == 1)
            {
                br1 = treeMojaDesavanja.SelectedNode.Parent.Index;
                br2 = treeMojaDesavanja.SelectedNode.Index;
                Program.client.println("BRISI_STAVKU# " + 
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).id);

            }
            else
            {
                br1 = treeMojaDesavanja.SelectedNode.Parent.Parent.Index;
                br2 = treeMojaDesavanja.SelectedNode.Parent.Index;
                br3 = treeMojaDesavanja.SelectedNode.Index;

                Program.client.println("BRISI_ELEMENT# " +
                    Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).id);
                               
            }
            dodajMojaDesavanja();
            btnDetalji.Enabled = false;
            btnDodajStavku.Enabled = false;
            btnIzbrisi.Enabled = false;
            btnIzmijeni.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSetIme_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPodaci_Click(object sender, EventArgs e)
        {
            Promjena register = new Promjena();
            register.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            int br1 = -1, br2 = -1;

            if (treeMojaDesavanja.SelectedNode.Level == 0)
            {
                br1 = treeMojaDesavanja.SelectedNode.Index;
                Program.kreiranje = "UPDATE_DOGADJAJ#";
                
                KreirajDogadjaj dog = new KreirajDogadjaj();
                dog.setDetalje(Program.mojaDesavanja.ElementAt(br1).naziv, Program.mojaDesavanja.ElementAt(br1).vrsta,
                    Program.mojaDesavanja.ElementAt(br1).lokacija, Program.mojaDesavanja.ElementAt(br1).datumPocetka,
                    Program.mojaDesavanja.ElementAt(br1).datumZavrsetka, Program.mojaDesavanja.ElementAt(br1).vrijemePocetka,
                    Program.mojaDesavanja.ElementAt(br1).vrijemeZavrsetka, Program.mojaDesavanja.ElementAt(br1).opis);
                dog.setId(Program.mojaDesavanja.ElementAt(br1).id);
                dog.ShowDialog();
            }
            else if (treeMojaDesavanja.SelectedNode.Level == 1)
            {
                br1 = treeMojaDesavanja.SelectedNode.Parent.Index;
                br2 = treeMojaDesavanja.SelectedNode.Index;

                Program.kreiranje = "UPDATE_STAVKU#";
                KreirajDogadjaj dog = new KreirajDogadjaj();
                dog.setDetalje(Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).naziv, 
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrsta,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).lokacija,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).datumPocetka,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).datumZavrsetka,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrijemePocetka,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).vrijemeZavrsetka,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).opis);

                dog.setId(Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).id);
                dog.ShowDialog();
            }
            else
            {
                br1 = treeMojaDesavanja.SelectedNode.Parent.Parent.Index;
                br2 = treeMojaDesavanja.SelectedNode.Parent.Index;
                int br3 = treeMojaDesavanja.SelectedNode.Index;
                Program.kreiranje = "UPDATE_ELEMENT#";
                KreirajDogadjaj dog = new KreirajDogadjaj();
                dog.setDetalje(Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).naziv,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrsta,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).lokacija,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumPocetka,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumZavrsetka,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemePocetka,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemeZavrsetka,
                   Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).opis);

                dog.setId(Program.mojaDesavanja.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).id);
                dog.ShowDialog();
            }
        }
    }
}
