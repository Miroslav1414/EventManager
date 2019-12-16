using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClijentOrganizatorDesavanja.Forme
{
    public partial class Admin : Form
    {
        public void dodajDogadjaje() {
            String ulaz = "";
            //primanje projekata
            Program.admin.Clear();

            Program.client.println("ADMIN#");

            while (!((ulaz = Program.client.readLine()).Equals("KRAJ_DESAVANJA")))
            {
                Program.admin.Add(new Desavanje(ulaz.Split('#')[0], ulaz.Split('#')[1],
                    ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                    ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                    ulaz.Split('#')[9]));
            }
            //primanje stavki
            foreach (Desavanje des in Program.admin)
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
            foreach (Desavanje des in Program.admin)
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
            foreach (Desavanje des in Program.admin)
            {
                brojac1++;
                brojac2 = -1;
                treeSvaDesavanja.Nodes.Add("1", des.naziv, 0);
                foreach (Stavka stav in des.listaStavki)
                {
                    brojac2++;
                    treeSvaDesavanja.Nodes[brojac1].Nodes.Add("2", stav.naziv, 1);
                    foreach (Element ele in stav.listaElemenata)
                    {
                        treeSvaDesavanja.Nodes[brojac1].Nodes[brojac2].Nodes.Add("3", ele.naziv, 2);
                    }
                }
            }

        }

        public void dodajNaloge() {
            {
                String ulaz = "";
                
                Program.nalozi.Clear();

                Program.client.println("ADMIN_NALOZI#");

                while (!((ulaz = Program.client.readLine()).Equals("KRAJ_NALOGA")))
                {
                    Program.nalozi.Add(new Nalog( ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[0]));
                }
                

                treeNalozi.Nodes.Clear();
                int brojac1 = -1;
                foreach (Nalog nalog in Program.nalozi)
                {
                    brojac1++;
                    treeNalozi.Nodes.Add("1", nalog.getKorisnickoIme(), 0);
                    treeNalozi.Nodes[brojac1].Nodes.Add("2", nalog.getIme() + " " + nalog.getPrezme(), 1);
                    
                }

            }

        }

        public Admin()
        {
            InitializeComponent();
            dodajDogadjaje();
            dodajNaloge();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            {
                int br1, br2, br3;
                Detalji detalji = new Detalji();
                if (treeSvaDesavanja.SelectedNode.Level == 0)
                {
                    br1 = treeSvaDesavanja.SelectedNode.Index;
                    detalji.popuniPodatke(Program.admin.ElementAt(br1).naziv,
                        Program.admin.ElementAt(br1).vrsta, Program.admin.ElementAt(br1).lokacija,
                        Program.admin.ElementAt(br1).datumPocetka + " " + Program.admin.ElementAt(br1).vrijemePocetka,
                        Program.admin.ElementAt(br1).datumZavrsetka + " " + Program.admin.ElementAt(br1).vrijemeZavrsetka,
                        Program.admin.ElementAt(br1).opis);
                }
                else if (treeSvaDesavanja.SelectedNode.Level == 1)
                {
                    br1 = treeSvaDesavanja.SelectedNode.Parent.Index;
                    br2 = treeSvaDesavanja.SelectedNode.Index;

                    detalji.popuniPodatke(Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).naziv,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).vrsta,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).lokacija,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).datumPocetka + " "
                        + Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).vrijemePocetka,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).datumZavrsetka + " "
                        + Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).vrijemeZavrsetka,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).opis);
                }
                else
                {
                    br1 = treeSvaDesavanja.SelectedNode.Parent.Parent.Index;
                    br2 = treeSvaDesavanja.SelectedNode.Parent.Index;
                    br3 = treeSvaDesavanja.SelectedNode.Index;

                    detalji.popuniPodatke(Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).naziv,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrsta,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).lokacija,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumPocetka + " "
                        + Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemePocetka,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).datumZavrsetka + " "
                        + Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).vrijemeZavrsetka,
                        Program.admin.ElementAt(br1).listaStavki.ElementAt(br2).listaElemenata.ElementAt(br3).opis);
                }
                detalji.ShowDialog();
            }
        }

        private void treeSvaDesavanja_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeSvaDesavanja.SelectedNode.Level == 0)
            {
                btnIzbrisi.Enabled = true;
            }
            else
            {
                btnIzbrisi.Enabled = false;
            }
            btnDetalji.Enabled = true;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            {
                int br1 = treeSvaDesavanja.SelectedNode.Index;
                Program.client.println("BRISI_DESAVANJE# " + Program.admin.ElementAt(br1).id);
                Program.add.dodajDogadjaje();

            }
        }

        private void btnDeaktiviraj_Click(object sender, EventArgs e)
        {
            int br = treeNalozi.SelectedNode.Index;
            Program.client.println("DEAKTIVIRAJ_NALOG#" + Program.nalozi.ElementAt(br).getKorisnickoIme());
            if (Program.client.readLine().Equals("uspjesno"))
            { MessageBox.Show("Uspjesna deaktivacija","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Program.add.dodajNaloge();
            }

            else
                MessageBox.Show("Doslo je do greske", "Greska",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void treeNalozi_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeNalozi.SelectedNode.Level == 0)
                btnDeaktiviraj.Enabled = true;
            else btnDeaktiviraj.Enabled = false;
        }
    }
}
