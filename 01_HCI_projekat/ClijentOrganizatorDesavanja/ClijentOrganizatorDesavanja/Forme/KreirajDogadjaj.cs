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
    public partial class KreirajDogadjaj : Form
    {
        public KreirajDogadjaj()
        {
            InitializeComponent();
        }

        public void setId(String id) {
            txtId.Text = id;
            checkPrivatno.Hide();
        }

        public void setDetalje(String naziv,String vrsta, String lokacija, String datumPocetka,
            String datumZavrsetka, String vrijemePocetka, String vrijemeZavrsetka, String opis) {
            txtNaziv.Text = naziv;
            txtLokacija.Text = lokacija;
            txtVrsta.Text = vrsta;
            datePocetak.Text = datumPocetka;
            dateZavrsetak.Text = datumZavrsetka;
            timePocetak.Text = vrijemePocetka;
            timeZavrsetak.Text = vrijemeZavrsetka;
            txtOpis.Text = opis;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datum1, datum2;
            datePocetak.Format = DateTimePickerFormat.Custom;
            datePocetak.CustomFormat = "yyyy-MM-dd";
            dateZavrsetak.Format = DateTimePickerFormat.Custom;
            dateZavrsetak.CustomFormat = "yyyy-MM-dd";

            if (txtNaziv.Text.Contains('#') || txtVrsta.Text.Contains('#') || txtLokacija.Text.Contains('#') ||
                txtOpis.Text.Contains('#'))
            {
                MessageBox.Show("Ni jedno polje ne smije da sadrzi znak #","Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtVrsta.Text) ||
                string.IsNullOrWhiteSpace(txtLokacija.Text) || string.IsNullOrWhiteSpace(txtOpis.Text))
                MessageBox.Show("Morate da popunite sva polja","Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DateTime.TryParse(datePocetak.Text, out datum1) && datum1 < DateTime.Now)
                MessageBox.Show("morate izabrati datum koji je stariji od trenutnog.","Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DateTime.TryParse(datePocetak.Text, out datum1) && DateTime.TryParse(dateZavrsetak.Text, out datum2)
                && datum1 > datum2)
                MessageBox.Show("Datum pocetka dogadjaja mora biti manji od datuma zavrsetka.","Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Program.kreiranje.Equals("KREIRAJ_DOGADJAJ#"))
                    Program.client.println("KREIRAJ_DOGADJAJ#" + txtNaziv.Text + "#" + txtVrsta.Text + "#" +
                        txtLokacija.Text + "#" + txtOpis.Text + "#" + checkPrivatno.Checked + "#" + datePocetak.Text + "#" +
                        timePocetak.Text + "#" + dateZavrsetak.Text + "#" + timeZavrsetak.Text + "#" + Program.nalog.getKorisnickoIme());
                else if (Program.kreiranje.Equals("KREIRAJ_STAVKU#"))
                    Program.client.println("KREIRAJ_STAVKU#" + txtNaziv.Text + "#" + txtVrsta.Text + "#" +
                    txtLokacija.Text + "#" + txtOpis.Text + "#" + txtId.Text + "#" + datePocetak.Text + "#" +
                    timePocetak.Text + "#" + dateZavrsetak.Text + "#" + timeZavrsetak.Text);
                else if (Program.kreiranje.Equals("KREIRAJ_ELEMENT#"))
                    Program.client.println("KREIRAJ_ELEMENT#" + txtNaziv.Text + "#" + txtVrsta.Text + "#" +
                    txtLokacija.Text + "#" + txtOpis.Text + "#" + txtId.Text + "#" + datePocetak.Text + "#" +
                    timePocetak.Text + "#" + dateZavrsetak.Text + "#" + timeZavrsetak.Text );

                else if (Program.kreiranje.Equals("UPDATE_DOGADJAJ#"))
                    Program.client.println("UPDATE_DOGADJAJ#" + txtNaziv.Text + "#" + txtVrsta.Text + "#" +
                        txtLokacija.Text + "#" + txtOpis.Text + "#" + datePocetak.Text + "#" +
                        timePocetak.Text + "#" + dateZavrsetak.Text + "#" + timeZavrsetak.Text + "#" + txtId.Text);

                else if (Program.kreiranje.Equals("UPDATE_STAVKU#"))
                    Program.client.println("UPDATE_STAVKU#" + txtNaziv.Text + "#" + txtVrsta.Text + "#" +
                        txtLokacija.Text + "#" + txtOpis.Text + "#" + datePocetak.Text + "#" +
                        timePocetak.Text + "#" + dateZavrsetak.Text + "#" + timeZavrsetak.Text + "#" + txtId.Text);

                else if (Program.kreiranje.Equals("UPDATE_ELEMENT#"))
                    Program.client.println("UPDATE_ELEMENT#" + txtNaziv.Text + "#" + txtVrsta.Text + "#" +
                        txtLokacija.Text + "#" + txtOpis.Text + "#" + datePocetak.Text + "#" +
                        timePocetak.Text + "#" + dateZavrsetak.Text + "#" + timeZavrsetak.Text + "#" + txtId.Text);
                else
                {
                    MessageBox.Show("NIJE NISTA SE DESILO!" + Program.kreiranje);
                }


                string ulaz = Program.client.readLine();
                if (ulaz.Equals("uspjesno"))
                {
                    MessageBox.Show("Uspješno odrađeno!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkPrivatno.Visible = true;
                    Program.glavnaForma.dodajMojaDesavanja();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (ulaz.Equals("neuspjesno"))
                    MessageBox.Show("Nije kreirano", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ulaz.Equals("izuzetak"))
                    MessageBox.Show("Došlo je do greške na serveru!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
