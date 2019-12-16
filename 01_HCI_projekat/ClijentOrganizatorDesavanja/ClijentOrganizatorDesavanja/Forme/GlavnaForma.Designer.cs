namespace ClijentOrganizatorDesavanja
{
    partial class GlavnaForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node2", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node1", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnDetaljiSve = new System.Windows.Forms.Button();
            this.treeSvaDesavanja = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPromjeni = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.treeMojaDesavanja = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDetaljiObjavljena = new System.Windows.Forms.Button();
            this.treeObjavljena = new System.Windows.Forms.TreeView();
            this.btnPodaci = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblSetIme = new System.Windows.Forms.Label();
            this.lblSetPrezime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.Transparent;
            this.btnKreiraj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKreiraj.BackgroundImage")));
            this.btnKreiraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKreiraj.ForeColor = System.Drawing.Color.Black;
            this.btnKreiraj.Location = new System.Drawing.Point(600, 9);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(165, 51);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj dešavanje";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetalji.BackgroundImage")));
            this.btnDetalji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetalji.Enabled = false;
            this.btnDetalji.ForeColor = System.Drawing.Color.Black;
            this.btnDetalji.Location = new System.Drawing.Point(600, 60);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(165, 51);
            this.btnDetalji.TabIndex = 3;
            this.btnDetalji.Text = "Prikaži detalje";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(83, 30);
            this.tabControl1.Location = new System.Drawing.Point(14, 93);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 365);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.btnOsvjezi);
            this.tabPage1.Controls.Add(this.btnDetaljiSve);
            this.tabPage1.Controls.Add(this.treeSvaDesavanja);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Size = new System.Drawing.Size(792, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sva dešavanja";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOsvjezi.BackgroundImage")));
            this.btnOsvjezi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOsvjezi.ForeColor = System.Drawing.Color.Black;
            this.btnOsvjezi.Location = new System.Drawing.Point(600, 76);
            this.btnOsvjezi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(165, 51);
            this.btnOsvjezi.TabIndex = 5;
            this.btnOsvjezi.Text = "Osvježi listu";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnDetaljiSve
            // 
            this.btnDetaljiSve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetaljiSve.BackgroundImage")));
            this.btnDetaljiSve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetaljiSve.Enabled = false;
            this.btnDetaljiSve.ForeColor = System.Drawing.Color.Black;
            this.btnDetaljiSve.Location = new System.Drawing.Point(600, 9);
            this.btnDetaljiSve.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDetaljiSve.Name = "btnDetaljiSve";
            this.btnDetaljiSve.Size = new System.Drawing.Size(165, 51);
            this.btnDetaljiSve.TabIndex = 4;
            this.btnDetaljiSve.Text = "Prikaži detalje";
            this.btnDetaljiSve.UseVisualStyleBackColor = true;
            this.btnDetaljiSve.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeSvaDesavanja
            // 
            this.treeSvaDesavanja.ImageIndex = 0;
            this.treeSvaDesavanja.ImageList = this.imageList1;
            this.treeSvaDesavanja.ItemHeight = 22;
            this.treeSvaDesavanja.Location = new System.Drawing.Point(10, 9);
            this.treeSvaDesavanja.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.treeSvaDesavanja.Name = "treeSvaDesavanja";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "Node2";
            treeNode1.Text = "Node2";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            this.treeSvaDesavanja.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeSvaDesavanja.SelectedImageIndex = 3;
            this.treeSvaDesavanja.Size = new System.Drawing.Size(580, 360);
            this.treeSvaDesavanja.TabIndex = 0;
            this.treeSvaDesavanja.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSvaDesavanja_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "D.jpg");
            this.imageList1.Images.SetKeyName(1, "E.jpg");
            this.imageList1.Images.SetKeyName(2, "S.jpg");
            this.imageList1.Images.SetKeyName(3, "r.jpg");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.btnPromjeni);
            this.tabPage2.Controls.Add(this.btnIzbrisi);
            this.tabPage2.Controls.Add(this.btnIzmijeni);
            this.tabPage2.Controls.Add(this.btnKreiraj);
            this.tabPage2.Controls.Add(this.btnDodajStavku);
            this.tabPage2.Controls.Add(this.btnDetalji);
            this.tabPage2.Controls.Add(this.treeMojaDesavanja);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Size = new System.Drawing.Size(792, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kreiranje dešavanja";
            // 
            // btnPromjeni
            // 
            this.btnPromjeni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPromjeni.BackgroundImage")));
            this.btnPromjeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPromjeni.Enabled = false;
            this.btnPromjeni.ForeColor = System.Drawing.Color.Black;
            this.btnPromjeni.Location = new System.Drawing.Point(600, 213);
            this.btnPromjeni.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPromjeni.Name = "btnPromjeni";
            this.btnPromjeni.Size = new System.Drawing.Size(165, 51);
            this.btnPromjeni.TabIndex = 7;
            this.btnPromjeni.Text = "Izmijeni";
            this.btnPromjeni.UseVisualStyleBackColor = true;
            this.btnPromjeni.Click += new System.EventHandler(this.btnPromjeni_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzbrisi.BackgroundImage")));
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzbrisi.Enabled = false;
            this.btnIzbrisi.ForeColor = System.Drawing.Color.Black;
            this.btnIzbrisi.Location = new System.Drawing.Point(600, 264);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(165, 51);
            this.btnIzbrisi.TabIndex = 6;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzmijeni.BackgroundImage")));
            this.btnIzmijeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzmijeni.Enabled = false;
            this.btnIzmijeni.ForeColor = System.Drawing.Color.Black;
            this.btnIzmijeni.Location = new System.Drawing.Point(600, 162);
            this.btnIzmijeni.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(165, 51);
            this.btnIzmijeni.TabIndex = 5;
            this.btnIzmijeni.Text = "Objavi dešavanje";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajStavku.BackgroundImage")));
            this.btnDodajStavku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajStavku.Enabled = false;
            this.btnDodajStavku.ForeColor = System.Drawing.Color.Black;
            this.btnDodajStavku.Location = new System.Drawing.Point(600, 111);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(165, 51);
            this.btnDodajStavku.TabIndex = 4;
            this.btnDodajStavku.Text = "Dodaj podcjelinu";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // treeMojaDesavanja
            // 
            this.treeMojaDesavanja.HideSelection = false;
            this.treeMojaDesavanja.ImageIndex = 0;
            this.treeMojaDesavanja.ImageList = this.imageList1;
            this.treeMojaDesavanja.ItemHeight = 22;
            this.treeMojaDesavanja.Location = new System.Drawing.Point(10, 9);
            this.treeMojaDesavanja.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.treeMojaDesavanja.Name = "treeMojaDesavanja";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Node2";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Node2";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Node1";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Node1";
            treeNode6.ImageKey = "Chrysanthemum.jpg";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Node0";
            this.treeMojaDesavanja.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeMojaDesavanja.SelectedImageIndex = 3;
            this.treeMojaDesavanja.Size = new System.Drawing.Size(580, 360);
            this.treeMojaDesavanja.TabIndex = 0;
            this.treeMojaDesavanja.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMojaDesavanja_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.btnZavrsi);
            this.tabPage3.Controls.Add(this.btnOtkazi);
            this.tabPage3.Controls.Add(this.btnDetaljiObjavljena);
            this.tabPage3.Controls.Add(this.treeObjavljena);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage3.Size = new System.Drawing.Size(792, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Moja objavljena dešavanja";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.BackColor = System.Drawing.Color.Transparent;
            this.btnZavrsi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZavrsi.BackgroundImage")));
            this.btnZavrsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZavrsi.Enabled = false;
            this.btnZavrsi.ForeColor = System.Drawing.Color.Black;
            this.btnZavrsi.Location = new System.Drawing.Point(600, 143);
            this.btnZavrsi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(165, 51);
            this.btnZavrsi.TabIndex = 6;
            this.btnZavrsi.Text = "Završi";
            this.btnZavrsi.UseVisualStyleBackColor = false;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.Transparent;
            this.btnOtkazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOtkazi.BackgroundImage")));
            this.btnOtkazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOtkazi.Enabled = false;
            this.btnOtkazi.ForeColor = System.Drawing.Color.Black;
            this.btnOtkazi.Location = new System.Drawing.Point(600, 76);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(165, 51);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDetaljiObjavljena
            // 
            this.btnDetaljiObjavljena.BackColor = System.Drawing.Color.Transparent;
            this.btnDetaljiObjavljena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetaljiObjavljena.BackgroundImage")));
            this.btnDetaljiObjavljena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetaljiObjavljena.Enabled = false;
            this.btnDetaljiObjavljena.ForeColor = System.Drawing.Color.Black;
            this.btnDetaljiObjavljena.Location = new System.Drawing.Point(600, 9);
            this.btnDetaljiObjavljena.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDetaljiObjavljena.Name = "btnDetaljiObjavljena";
            this.btnDetaljiObjavljena.Size = new System.Drawing.Size(165, 51);
            this.btnDetaljiObjavljena.TabIndex = 4;
            this.btnDetaljiObjavljena.Text = "Prikaži detalje";
            this.btnDetaljiObjavljena.UseVisualStyleBackColor = false;
            this.btnDetaljiObjavljena.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // treeObjavljena
            // 
            this.treeObjavljena.ImageIndex = 0;
            this.treeObjavljena.ImageList = this.imageList1;
            this.treeObjavljena.ItemHeight = 22;
            this.treeObjavljena.Location = new System.Drawing.Point(10, 9);
            this.treeObjavljena.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.treeObjavljena.Name = "treeObjavljena";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Node2";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Node1";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Node0";
            this.treeObjavljena.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeObjavljena.SelectedImageIndex = 3;
            this.treeObjavljena.Size = new System.Drawing.Size(580, 360);
            this.treeObjavljena.TabIndex = 0;
            this.treeObjavljena.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeObjavljena_AfterSelect);
            // 
            // btnPodaci
            // 
            this.btnPodaci.BackColor = System.Drawing.Color.Transparent;
            this.btnPodaci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPodaci.BackgroundImage")));
            this.btnPodaci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPodaci.Location = new System.Drawing.Point(285, 12);
            this.btnPodaci.Name = "btnPodaci";
            this.btnPodaci.Size = new System.Drawing.Size(136, 46);
            this.btnPodaci.TabIndex = 6;
            this.btnPodaci.Text = "Promjena podataka";
            this.btnPodaci.UseVisualStyleBackColor = false;
            this.btnPodaci.Click += new System.EventHandler(this.btnPodaci_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Location = new System.Drawing.Point(28, 13);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(44, 19);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime: ";
            this.lblIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblPrezime.ForeColor = System.Drawing.Color.Black;
            this.lblPrezime.Location = new System.Drawing.Point(28, 39);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(73, 19);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime: ";
            // 
            // lblSetIme
            // 
            this.lblSetIme.AutoSize = true;
            this.lblSetIme.BackColor = System.Drawing.Color.Transparent;
            this.lblSetIme.Location = new System.Drawing.Point(114, 13);
            this.lblSetIme.Name = "lblSetIme";
            this.lblSetIme.Size = new System.Drawing.Size(47, 19);
            this.lblSetIme.TabIndex = 9;
            this.lblSetIme.Text = "label1";
            this.lblSetIme.Click += new System.EventHandler(this.lblSetIme_Click);
            // 
            // lblSetPrezime
            // 
            this.lblSetPrezime.AutoSize = true;
            this.lblSetPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblSetPrezime.Location = new System.Drawing.Point(114, 39);
            this.lblSetPrezime.Name = "lblSetPrezime";
            this.lblSetPrezime.Size = new System.Drawing.Size(48, 19);
            this.lblSetPrezime.TabIndex = 10;
            this.lblSetPrezime.Text = "label2";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClijentOrganizatorDesavanja.Properties.Resources.pozadian2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 471);
            this.Controls.Add(this.lblSetPrezime);
            this.Controls.Add(this.lblSetIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnPodaci);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnaForma";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeMojaDesavanja;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.TreeView treeSvaDesavanja;
        private System.Windows.Forms.Button btnDetaljiSve;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeObjavljena;
        private System.Windows.Forms.Button btnDetaljiObjavljena;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPodaci;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblSetIme;
        private System.Windows.Forms.Label lblSetPrezime;
        private System.Windows.Forms.Button btnPromjeni;
    }
}