using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using MySql.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;


namespace ServerC
{
    class ServerThread
    {
        Thread _t;
        TcpClient _client;
        NetworkStream stream;
        byte[] buffer;
        string connString;
        MySqlConnection conn;
        StreamReader reader;
        StreamWriter writer;

        public ServerThread(TcpClient client) {
            _client = client;
            stream = _client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            _t = new Thread(new ThreadStart(run));
            _t.Start();
            connString = "server=localhost;Database=hci;Uid=student;Pwd=student;";
            conn = new MySqlConnection(connString);
            conn.Open();
        }

        public string readLine() {
            return reader.ReadLine();
            //buffer = new byte[_client.ReceiveBufferSize];
            //int data = stream.Read(buffer, 0, _client.ReceiveBufferSize);
            //return Encoding.Unicode.GetString(buffer, 0, data);
        }
        public void println(String str)
        {
            writer.WriteLine(str);
            writer.Flush();
            //buffer = Encoding.Unicode.GetBytes(str);
            //stream.Write(buffer, 0, buffer.Length);

        }
        public void kraj() {
            conn.Close();
            _client.Close();

        }

        public void sablonMetoda() {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    
                    cmd.CommandText = "string";
                    //cmd.ExecuteNonQuery()
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0) + "#" + reader.GetString(1) + "#" + reader.GetString(2)
                                 + "#" + reader.GetString(3));
                        }
                    }
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void login(string username, string pass) {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select username, password, ime, prezime from nalog where username = '"+username
                        +"' and aktivan ='1' and password = '"+pass+"'";
                    //cmd.ExecuteNonQuery
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Console.WriteLine("========");
                        string izlaz;
                        if  (reader.Read()) {
                            
                                izlaz = reader.GetString(0) + "#" + reader.GetString(2) + "#" +
                                reader.GetString(3);
                        }
                        else izlaz = "greska";
                        
                        Console.WriteLine(izlaz);
                        println(izlaz);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void register(string user,string pass, string ime, string prezime) {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    
                    cmd.CommandText = "select username from nalog where username = '"+user+"'";
                    //cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            println("nalog_postoji");
                        else {
                            reader.Close();
                            cmd.CommandText = "insert into nalog (Username,password,Ime,Prezime) values "
                                + "('" + user + "','" + pass + "','" + ime + "','" + prezime + "')";
                            if (cmd.ExecuteNonQuery() == 1)
                                println("uspjesno");
                            else println("izuzetak");
                        }
                    }

                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void kreirajDesavanje(string naziv,string vrsta,string lokacija,string opis,string privatno,
            string datumPocetka, string vrijemePocetka,string datumZavrsetka, string vrijemeZavrsetka,string user) {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {//('marko','markovioc')
                    int da = 0;
                    if (privatno.Equals("True")) da = 1;
                    cmd.CommandText = "insert into desavanje (Naziv,Vrsta,Lokacija,Opis,Privatno,DatumPocetka," +
                        "vrijemePocetka,DatumZavrsetka,VrijemeZavrsetka,Username) values ('"+ 
                        naziv+ "','"+vrsta+ "','"+lokacija+ "','"+opis+ "','"+da+ "','"+
                        datumPocetka+ "','"+vrijemePocetka+ "','"+datumZavrsetka+ "','"+vrijemeZavrsetka+"','"+user+"') ";
                    if (cmd.ExecuteNonQuery() == 1) println("uspjesno");
                    else println("neuspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void kreirajStavku(string naziv, string vrsta, string lokacija, string opis, string idStavke,
            string datumPocetka, string vrijemePocetka, string datumZavrsetka, string vrijemeZavrsetka)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    
                    cmd.CommandText = "insert into Stavka (Naziv,Vrsta,Lokacija,Opis,IdDesavanja,DatumPocetka," +
                        "vrijemePocetka,DatumZavrsetka,VrijemeZavrsetka) values ('" +
                        naziv + "','" + vrsta + "','" + lokacija + "','" + opis + "','" + idStavke + "','" +
                        datumPocetka + "','" + vrijemePocetka + "','" + datumZavrsetka + "','" + vrijemeZavrsetka + "') ";
                    if (cmd.ExecuteNonQuery() == 1) println("uspjesno");
                    else println("neuspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void kreirajElement(string naziv, string vrsta, string lokacija, string opis, string idStavke,
            string datumPocetka, string vrijemePocetka, string datumZavrsetka, string vrijemeZavrsetka)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "insert into Element (Naziv,Vrsta,Lokacija,Opis,IdStavke,DatumPocetka," +
                        "vrijemePocetka,DatumZavrsetka,VrijemeZavrsetka) values ('" +
                        naziv + "','" + vrsta + "','" + lokacija + "','" + opis + "','" + idStavke + "','" +
                        datumPocetka + "','" + vrijemePocetka + "','" + datumZavrsetka + "','" + vrijemeZavrsetka + "') ";
                    if (cmd.ExecuteNonQuery() == 1) println("uspjesno");
                    else println("neuspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void mojiaDesavanja(string user)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select naziv,vrsta,lokacija,opis,privatno,"+
                        "datumpocetka, vrijemePocetka, datumZavrsetka, vrijemezavrsetka, idDesavanja "+
                        "from desavanje where objavljeno = 0 and zavrseno = 0 and username ='"+user+"'";
                    
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            println(reader.GetString(0) + "#" + reader.GetString(1) + "#" + reader.GetString(2) + "#" +
                                reader.GetString(3) + "#" + reader.GetString(4) + "#" + reader.GetString(5) + "#" +
                                reader.GetString(6) + "#" + reader.GetString(7) + "#" + reader.GetString(8)
                                + "#" + reader.GetString(9));
                        }
                        println("KRAJ_DESAVANJA");
                    }
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void svaDesavanja(string user)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select naziv,vrsta,lokacija,opis,privatno," +
                        "datumpocetka, vrijemePocetka, datumZavrsetka, vrijemezavrsetka, idDesavanja " +
                        "from desavanje where objavljeno = 1 and zavrseno = 0 and username !='" + user + "'";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            println(reader.GetString(0) + "#" + reader.GetString(1) + "#" + reader.GetString(2) + "#" +
                                reader.GetString(3) + "#" + reader.GetString(4) + "#" + reader.GetString(5) + "#" +
                                reader.GetString(6) + "#" + reader.GetString(7) + "#" + reader.GetString(8)
                                + "#" + reader.GetString(9));
                        }
                        println("KRAJ_DESAVANJA");
                    }
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void objavljenaDesavanja(string user)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select naziv,vrsta,lokacija,opis,privatno," +
                        "datumpocetka, vrijemePocetka, datumZavrsetka, vrijemezavrsetka, idDesavanja " +
                        "from desavanje where objavljeno = 1 and zavrseno = 0 and username ='" + user + "'";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            println(reader.GetString(0) + "#" + reader.GetString(1) + "#" + reader.GetString(2) + "#" +
                                reader.GetString(3) + "#" + reader.GetString(4) + "#" + reader.GetString(5) + "#" +
                                reader.GetString(6) + "#" + reader.GetString(7) + "#" + reader.GetString(8)
                                + "#" + reader.GetString(9));
                        }
                        println("KRAJ_DESAVANJA");
                    }
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void mojeStavke(string idDesavanja)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select naziv,vrsta,lokacija,opis, " +
                        "datumpocetka, vrijemePocetka, datumZavrsetka, vrijemezavrsetka, idStavke " +
                        "from Stavka where idDesavanja ='" + idDesavanja + "'";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            println(reader.GetString(0) + "#" + reader.GetString(1) + "#" + reader.GetString(2) + "#" +
                                reader.GetString(3) + "#" + reader.GetString(4) + "#" + reader.GetString(5) + "#" +
                                reader.GetString(6) + "#" + reader.GetString(7) + "#" + reader.GetString(8));
                        }
                        println("KRAJ_STAVKI");
                    }
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void mojiElementi(string idStavke)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select naziv,vrsta,lokacija,opis, " +
                        "datumpocetka, vrijemePocetka, datumZavrsetka, vrijemezavrsetka, idElementa " +
                        "from Element where idStavke ='" + idStavke + "'";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            println(reader.GetString(0) + "#" + reader.GetString(1) + "#" + reader.GetString(2) + "#" +
                                reader.GetString(3) + "#" + reader.GetString(4) + "#" + reader.GetString(5) + "#" +
                                reader.GetString(6) + "#" + reader.GetString(7) + "#" + reader.GetString(8));
                        }
                        println("KRAJ_ELEMENATA");
                    }
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void objavi(String id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "update Desavanje set objavljeno = '1' where idDesavanja = '"+id+"'";

                    if (cmd.ExecuteNonQuery() == 1)
                        println("uspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void zavrsi(String id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "update Desavanje set zavrseno = '1' where idDesavanja = '" + id + "'";

                    if (cmd.ExecuteNonQuery() == 1)
                        println("uspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void otkazi(String id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "update Desavanje set objavljeno = '0' where idDesavanja = '" + id + "'";

                    if (cmd.ExecuteNonQuery() == 1)
                        println("uspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void brisiDesavanje(String id) {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "delete from Desavanje where idDesavanja = '" + id + "'";

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                //println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void brisiStavku(String id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "delete from Stavka where idStavke = '" + id + "'";

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                //println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void brisiElement(String id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "delete from Element where idElementa = '" + id + "'";

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                //println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void promijeni(String ime, String prezime, String lozinka, String id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "update nalog set ime = '"+ime +
                        "' , prezime = '" +prezime + "' ,password = '"+lozinka +
                        "' where username = '" + id + "'";

                    if (cmd.ExecuteNonQuery() == 1)
                        println("uspjesno");
                }

            }
            catch (Exception e)
            {
                //println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void admin() {
            {
                try
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = "select naziv,vrsta,lokacija,opis,privatno," +
                            "datumpocetka, vrijemePocetka, datumZavrsetka, vrijemezavrsetka, idDesavanja " +
                            "from desavanje " ;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                println(reader.GetString(0) + "#" + reader.GetString(1) + "#" + reader.GetString(2) + "#" +
                                    reader.GetString(3) + "#" + reader.GetString(4) + "#" + reader.GetString(5) + "#" +
                                    reader.GetString(6) + "#" + reader.GetString(7) + "#" + reader.GetString(8)
                                    + "#" + reader.GetString(9));
                            }
                            println("KRAJ_DESAVANJA");
                        }
                    }

                }
                catch (Exception e)
                {
                    println("izuzetak");
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public void adminNalozi() {
            {
                try
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = "select username,ime,prezime from nalog where aktivan = '1' and username != 'Admin'";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                println(reader.GetString(0) + "#" + reader.GetString(1) + "#" + reader.GetString(2));
                            }
                            println("KRAJ_NALOGA");
                        }
                    }

                }
                catch (Exception e)
                {
                    println("izuzetak");
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public void deaktivirajNalog(String id) {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "update nalog set aktivan = '0' where username = '" + id + "'";

                    if (cmd.ExecuteNonQuery() == 1)
                        println("uspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void updateStavku(string naziv, string vrsta, string lokacija, string opis,
            string datumPocetka, string vrijemePocetka, string datumZavrsetka, string vrijemeZavrsetka,
            string id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "update Stavka set " +
                        "naziv = '"+ naziv +"', "  +
                        "vrsta = '" + vrsta+"', " +
                        "lokacija = '" +lokacija +"', " +
                        "opis = '" +opis +"', " +
                        "datumPocetka = '" + datumPocetka +"', " +
                        "DatumZavrsetka = '" + datumZavrsetka+"', " +
                        "vrijemeZavrsetka = '" + vrijemeZavrsetka+"', " + 
                        "vrijemePocetka = '" + vrijemePocetka + "' where idStavke ='" + id +"'";

                    if (cmd.ExecuteNonQuery() == 1) println("uspjesno");
                    else println("neuspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }
        public void updateDesavanje(string naziv, string vrsta, string lokacija, string opis,
            string datumPocetka, string vrijemePocetka, string datumZavrsetka, string vrijemeZavrsetka,
            string id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "update Desavanje set " +
                        "naziv = '" + naziv + "', " +
                        "vrsta = '" + vrsta + "', " +
                        "lokacija = '" + lokacija + "', " +
                        "opis = '" + opis + "', " +
                        "datumPocetka = '" + datumPocetka + "', " +
                        "DatumZavrsetka = '" + datumZavrsetka + "', " +
                        "vrijemeZavrsetka = '" + vrijemeZavrsetka + "', " +
                        "vrijemePocetka = '" + vrijemePocetka + "' where idDesavanja ='" + id + "'";

                    if (cmd.ExecuteNonQuery() == 1) println("uspjesno");
                    else println("neuspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }

        public void updateElement(string naziv, string vrsta, string lokacija, string opis,
           string datumPocetka, string vrijemePocetka, string datumZavrsetka, string vrijemeZavrsetka,
           string id)
        {
            try
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "update Element set " +
                        "naziv = '" + naziv + "', " +
                        "vrsta = '" + vrsta + "', " +
                        "lokacija = '" + lokacija + "', " +
                        "opis = '" + opis + "', " +
                        "datumPocetka = '" + datumPocetka + "', " +
                        "DatumZavrsetka = '" + datumZavrsetka + "', " +
                        "vrijemeZavrsetka = '" + vrijemeZavrsetka + "', " +
                        "vrijemePocetka = '" + vrijemePocetka + "' where idElementa ='" + id + "'";

                    if (cmd.ExecuteNonQuery() == 1) println("uspjesno");
                    else println("neuspjesno");
                }

            }
            catch (Exception e)
            {
                println("izuzetak");
                MessageBox.Show(e.ToString());
            }
        }



        public void run() {
            bool uslov = true;
            
            do
            {
                String ulaz= "---";
                try
                {
                    ulaz = readLine();
                }
                catch (Exception e)
                {
                    ulaz = "KRAJ";
                    //MessageBox.Show(e.ToString());
                }

                Console.WriteLine("klijent: " + ulaz);


                if (ulaz.Equals("KRAJ")) uslov = false;
                else if (ulaz.StartsWith("LOGIN#"))
                {
                    login(ulaz.Split('#')[1], ulaz.Split('#')[2]);
                }
                else if (ulaz.StartsWith("REGISTER#"))
                {
                    register(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4]);
                }
                else if (ulaz.StartsWith("KREIRAJ_DOGADJAJ#"))
                {
                    kreirajDesavanje(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                        ulaz.Split('#')[9], ulaz.Split('#')[10]);
                }
                else if (ulaz.StartsWith("KREIRAJ_ELEMENT#"))
                {
                    kreirajElement(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                        ulaz.Split('#')[9]);
                }
                else if (ulaz.StartsWith("KREIRAJ_STAVKU#"))
                {
                    kreirajStavku(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                        ulaz.Split('#')[9]);
                }
                else if (ulaz.StartsWith("MOJA_DESAVANJA#"))
                {
                    mojiaDesavanja(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("SVA_DESAVANJA#"))
                {
                    svaDesavanja(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("OBJAVLJENA_DESAVANJA#"))
                {
                    objavljenaDesavanja(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("MOJI_ELEMENTI#"))
                {
                    mojiElementi(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("MOJE_STAVKE#"))
                {
                    mojeStavke(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("OBJAVI#"))
                {
                    objavi(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("ZAVRSI#"))
                {
                    zavrsi(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("OTKAZI#"))
                {
                    otkazi(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("BRISI_DESAVANJE#"))
                {
                    brisiDesavanje(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("BRISI_STAVKU#"))
                {
                    brisiStavku(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("BRISI_ELEMENT#"))
                {
                    brisiElement(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("PROMIJENI#"))
                {
                    promijeni(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4]);
                }
                else if (ulaz.StartsWith("ADMIN#"))
                {
                    admin();
                }
                else if (ulaz.StartsWith("ADMIN_NALOZI#"))
                {
                    adminNalozi();
                }
                else if (ulaz.StartsWith("DEAKTIVIRAJ_NALOG#"))
                {
                    deaktivirajNalog(ulaz.Split('#')[1]);
                }
                else if (ulaz.StartsWith("UPDATE_DOGADJAJ#"))
                {
                    updateDesavanje(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                        ulaz.Split('#')[9]);
                }
                else if (ulaz.StartsWith("UPDATE_ELEMENT#"))
                {
                    updateElement(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                        ulaz.Split('#')[9]);
                }
                else if (ulaz.StartsWith("UPDATE_STAVKU#"))
                {
                    updateStavku(ulaz.Split('#')[1], ulaz.Split('#')[2], ulaz.Split('#')[3], ulaz.Split('#')[4],
                        ulaz.Split('#')[5], ulaz.Split('#')[6], ulaz.Split('#')[7], ulaz.Split('#')[8],
                        ulaz.Split('#')[9]);
                }
                else
                {
                    MessageBox.Show("NIJE NISTA SE DESILO!");
                }




            }
            while (uslov);
            
            Console.WriteLine("Kraj konekcije");
            
        }
    }
}
