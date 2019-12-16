namespace ClijentOrganizatorDesavanja.Forme
{
    partial class Admin
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeSvaDesavanja = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.treeNalozi = new System.Windows.Forms.TreeView();
            this.btnDeaktiviraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeSvaDesavanja
            // 
            this.treeSvaDesavanja.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeSvaDesavanja.ImageIndex = 0;
            this.treeSvaDesavanja.ImageList = this.imageList1;
            this.treeSvaDesavanja.ItemHeight = 22;
            this.treeSvaDesavanja.Location = new System.Drawing.Point(26, 17);
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
            this.treeSvaDesavanja.Size = new System.Drawing.Size(298, 276);
            this.treeSvaDesavanja.TabIndex = 1;
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
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzbrisi.BackgroundImage")));
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzbrisi.Enabled = false;
            this.btnIzbrisi.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.ForeColor = System.Drawing.Color.Black;
            this.btnIzbrisi.Location = new System.Drawing.Point(200, 301);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(124, 51);
            this.btnIzbrisi.TabIndex = 8;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetalji.BackgroundImage")));
            this.btnDetalji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetalji.Enabled = false;
            this.btnDetalji.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ForeColor = System.Drawing.Color.Black;
            this.btnDetalji.Location = new System.Drawing.Point(26, 302);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(114, 51);
            this.btnDetalji.TabIndex = 7;
            this.btnDetalji.Text = "Prikaži detalje";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // treeNalozi
            // 
            this.treeNalozi.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeNalozi.ImageIndex = 0;
            this.treeNalozi.ImageList = this.imageList1;
            this.treeNalozi.ItemHeight = 22;
            this.treeNalozi.Location = new System.Drawing.Point(430, 17);
            this.treeNalozi.Name = "treeNalozi";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Node1";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            this.treeNalozi.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeNalozi.SelectedImageIndex = 3;
            this.treeNalozi.Size = new System.Drawing.Size(327, 276);
            this.treeNalozi.TabIndex = 9;
            this.treeNalozi.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNalozi_AfterSelect);
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeaktiviraj.BackgroundImage")));
            this.btnDeaktiviraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeaktiviraj.Enabled = false;
            this.btnDeaktiviraj.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeaktiviraj.ForeColor = System.Drawing.Color.Black;
            this.btnDeaktiviraj.Location = new System.Drawing.Point(633, 300);
            this.btnDeaktiviraj.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(124, 51);
            this.btnDeaktiviraj.TabIndex = 10;
            this.btnDeaktiviraj.Text = "Deaktiviraj nalog";
            this.btnDeaktiviraj.UseVisualStyleBackColor = true;
            this.btnDeaktiviraj.Click += new System.EventHandler(this.btnDeaktiviraj_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClijentOrganizatorDesavanja.Properties.Resources.pozadian2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 364);
            this.Controls.Add(this.btnDeaktiviraj);
            this.Controls.Add(this.treeNalozi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.treeSvaDesavanja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeSvaDesavanja;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.TreeView treeNalozi;
        private System.Windows.Forms.Button btnDeaktiviraj;
    }
}