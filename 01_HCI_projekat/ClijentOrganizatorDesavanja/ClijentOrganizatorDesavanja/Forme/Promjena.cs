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
    public partial class Promjena : Form
    {
        public Promjena()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtIme.TextLength > 50 || txtLozinka.TextLength > 50 || txtPrezime.TextLength > 50)
                MessageBox.Show("Duzina pojedinacnog podatka mora biti manja od 50","Greška",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            else if ((string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text) || string.IsNullOrWhiteSpace(txtLozinka.Text)))
            {
                MessageBox.Show("Morate da popunite sva polja", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtIme.Text.Contains('#') || txtPrezime.Text.Contains('#') || txtLozinka.Text.Contains('#'))
                MessageBox.Show("Ni jedan podatak ne smije da sadrzi znak #", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Program.client.println("PROMIJENI#" + txtIme.Text + "#" +
                    txtPrezime.Text + "#" + txtLozinka.Text + "#" + Program.nalog.getKorisnickoIme());
                string ulaz = Program.client.readLine();

                if (ulaz.Equals("uspjesno"))
                {
                    MessageBox.Show("Uspjesno ste promijenili podatke", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    Program.nalog.setIme(txtIme.Text);
                    Program.nalog.setPrezime(txtPrezime.Text);
                    Program.glavnaForma.postaviImeIPrezime();
                }

                //    else (ulaz.Equals("izuzetak"))
                //            { 
                //    MessageBox.Show("Doslo je do greske na serveru!"); }
            }
            }
    }
}
