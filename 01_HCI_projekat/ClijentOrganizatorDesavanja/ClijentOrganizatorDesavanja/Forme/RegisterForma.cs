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
    public partial class RegisterForma : Form
    {
        public RegisterForma()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.TextLength > 50 || txtIme.TextLength > 50 || txtLozinka.TextLength > 50
                || txtLozinkaPonovo.TextLength > 50 || txtPrezime.TextLength > 50)
                MessageBox.Show("Duzina pojedinacnog podatka mora biti manja od 50", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text) || string.IsNullOrWhiteSpace(txtLozinka.Text) ||
                string.IsNullOrWhiteSpace(txtLozinkaPonovo.Text)){
                MessageBox.Show("Morate da popunite sva polja", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(txtLozinka.Text.Equals(txtLozinka.Text)))
                MessageBox.Show("Lozinke se ne poklopaju", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtKorisnickoIme.Text.Contains('#') || txtIme.Text.Contains('#') ||
                txtPrezime.Text.Contains('#') || txtLozinka.Text.Contains('#') || txtLozinkaPonovo.Text.Contains('#'))
                MessageBox.Show("Ni jedan podatak ne smije da sadrzi znak #", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Program.client.println("REGISTER#" + txtKorisnickoIme.Text + "#" + txtLozinka.Text + "#" + txtIme.Text + "#" +
                    txtPrezime.Text );
                string ulaz = Program.client.readLine();
                if (ulaz.Equals("uspjesno"))
                {
                    MessageBox.Show("Uspjesno ste se registrovali", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (ulaz.Equals("nalog_postoji"))
                    MessageBox.Show("Uneseno korisnicko ime je vec zauseto", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ulaz.Equals("izuzetak"))
                    MessageBox.Show("Doslo je do greske na serveru!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
