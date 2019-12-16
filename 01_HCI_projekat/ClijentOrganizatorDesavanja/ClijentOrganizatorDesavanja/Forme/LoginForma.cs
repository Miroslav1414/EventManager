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
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String username, pass;
            username = txtUsername.Text;
            pass = txtPassword.Text;
            Program.client.println("LOGIN#"+ username +"#"+pass);

            string ulaz = Program.client.readLine();

            if (ulaz.Equals("greska"))
                MessageBox.Show("Unešeni podaci nisu ispravni ili vam je nalog deaktiviran", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                Program.nalog = new Nalog(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[0]);

                //primanje projekata
                //Program.client.println("MOJA_DESAVANJA#"+Program.nalog.getKorisnickoIme());
                //while (!(ulaz.Equals("KRAJ_DESAVANJA"))) {
                //    Program.mojaDesavanja.Add(new Desavanje(ulaz.Split('#')[0], ulaz.Split('#')[1],
                //        ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                //        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[8], ulaz.Split('#')[9]));
                //}
                ////
                
                //TreeNode node = new TreeNode(Program.mojaDesavanja[0].naziv);
                //node.Nodes.Add("1");
                //node.Nodes.Add("2");




                this.DialogResult = DialogResult.OK;
                this.Close(); }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnOK.Enabled = false; 
            }
            else
            {
                
                btnOK.Enabled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnOK.Enabled = false;
            }
            else
            {
                
                btnOK.Enabled = true;
            }
        }

        
        private void LoginForma_FormClosing(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForma register = new RegisterForma();
            register.ShowDialog();

        }

        private void LoginForma_Load(object sender, EventArgs e)
        {

        }
    }
}
