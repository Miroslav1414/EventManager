namespace ClijentOrganizatorDesavanja
{
    partial class KreirajDogadjaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KreirajDogadjaj));
            this.timeZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePocetak = new System.Windows.Forms.DateTimePicker();
            this.dateZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.checkPrivatno = new System.Windows.Forms.CheckBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timePocetak = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timeZavrsetak
            // 
            this.timeZavrsetak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeZavrsetak.Location = new System.Drawing.Point(636, 218);
            this.timeZavrsetak.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.timeZavrsetak.Name = "timeZavrsetak";
            this.timeZavrsetak.ShowUpDown = true;
            this.timeZavrsetak.Size = new System.Drawing.Size(95, 26);
            this.timeZavrsetak.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(46, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lokacija";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // datePocetak
            // 
            this.datePocetak.CustomFormat = "";
            this.datePocetak.Location = new System.Drawing.Point(59, 218);
            this.datePocetak.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.datePocetak.Name = "datePocetak";
            this.datePocetak.Size = new System.Drawing.Size(186, 26);
            this.datePocetak.TabIndex = 10;
            this.datePocetak.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateZavrsetak
            // 
            this.dateZavrsetak.Location = new System.Drawing.Point(439, 218);
            this.dateZavrsetak.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateZavrsetak.Name = "dateZavrsetak";
            this.dateZavrsetak.Size = new System.Drawing.Size(187, 26);
            this.dateZavrsetak.TabIndex = 12;
            this.dateZavrsetak.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // checkPrivatno
            // 
            this.checkPrivatno.AutoSize = true;
            this.checkPrivatno.Location = new System.Drawing.Point(19, 263);
            this.checkPrivatno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkPrivatno.Name = "checkPrivatno";
            this.checkPrivatno.Size = new System.Drawing.Size(86, 23);
            this.checkPrivatno.TabIndex = 5;
            this.checkPrivatno.Text = "Privatno";
            this.checkPrivatno.UseVisualStyleBackColor = true;
            this.checkPrivatno.Visible = false;
            this.checkPrivatno.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(19, 324);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(721, 170);
            this.txtOpis.TabIndex = 14;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(114, 21);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(617, 26);
            this.txtNaziv.TabIndex = 7;
            this.txtNaziv.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(114, 68);
            this.txtVrsta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(617, 26);
            this.txtVrsta.TabIndex = 8;
            this.txtVrsta.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(114, 114);
            this.txtLokacija.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLokacija.Multiline = true;
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(617, 56);
            this.txtLokacija.TabIndex = 9;
            this.txtLokacija.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(55, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vrijeme početka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(439, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vrijeme završetka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Opis dešavanja";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(615, 521);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(19, 521);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timePocetak
            // 
            this.timePocetak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePocetak.Location = new System.Drawing.Point(255, 218);
            this.timePocetak.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.timePocetak.Name = "timePocetak";
            this.timePocetak.ShowUpDown = true;
            this.timePocetak.Size = new System.Drawing.Size(95, 26);
            this.timePocetak.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 261);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 26);
            this.txtId.TabIndex = 17;
            this.txtId.Visible = false;
            // 
            // KreirajDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 571);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.timeZavrsetak);
            this.Controls.Add(this.timePocetak);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.checkPrivatno);
            this.Controls.Add(this.dateZavrsetak);
            this.Controls.Add(this.datePocetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "KreirajDogadjaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KreirajDogadjaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateZavrsetak;
        private System.Windows.Forms.CheckBox checkPrivatno;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker timePocetak;
        private System.Windows.Forms.DateTimePicker datePocetak;
        private System.Windows.Forms.DateTimePicker timeZavrsetak;
        private System.Windows.Forms.TextBox txtId;
    }
}