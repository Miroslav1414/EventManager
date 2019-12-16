using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;

namespace ClijentOrganizatorDesavanja
{ 
class Program
{
        public static int idUpdate;
        public static Forme.Admin add;
        public static GlavnaForma glavnaForma;
        public static String kreiranje;
        public static Client client;
        public static Nalog nalog;
        public static List<Desavanje> mojaDesavanja;
        public static List<Desavanje> svaDesavanja;
        public static List<Desavanje> objavljena;
        public static List<Desavanje> admin;
        public static List<Nalog> nalozi;
        public static int ugasi = 0;

        //public void setNalog(string ime, string prezime, string korisnickoIme) {
        //    nalog = new Nalog(ime,prezime,korisnickoIme);
        //}
        public Program(Client clijent) {
            client = clijent;
            mojaDesavanja = new List<Desavanje>();
            svaDesavanja = new List<Desavanje>();
            objavljena = new List<Desavanje>();
            admin = new List<Desavanje>();
            nalozi = new List<Nalog>();

        }

public static void balon(TextBox polje) {
            ToolTip hint = new ToolTip();
            if (polje.Text.Contains("#"))
            {
                hint.IsBalloon = true;
                hint.ToolTipTitle = "Nedozvoljeni znak";
                hint.ToolTipIcon = ToolTipIcon.Error;
                //hint.Show(string.Empty, label1, 0);
                hint.Show("ovo polje ne moze da sadrzi znak #", polje, 0, -70, 1000);
            }
        }
   
    static void Main()
    {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            Program program = new Program( new Client());
            if (ugasi == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                LoginForma login_form = new LoginForma();
                if (login_form.ShowDialog() == DialogResult.OK)
                {
                    if (nalog.getKorisnickoIme().Equals("Admin"))
                    {
                        add = new Forme.Admin();
                        Application.Run(add);
                    }

                    else
                    {
                        glavnaForma = new GlavnaForma();
                        Application.Run(glavnaForma);
                    }
                }
            }
            else
                MessageBox.Show("Server je ugasen! Pokusajte ponovo kasnije", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            Program.client.kraj();
            
        }
    }



class Client
{

    static TcpClient _client;
    static NetworkStream _network;
    static byte[] buffer;
    static StreamReader reader;
    static StreamWriter writer;

        public Client()
        {
            try
            {
               // Console.WriteLine("spajanje sa serverom...");
                _client = new TcpClient("127.0.0.1", 1200);
                _network = _client.GetStream();
                reader = new StreamReader(_network);
                writer = new StreamWriter(_network);
               // Console.WriteLine("Spojeno!");
            }
            catch (Exception e) {

                Program.ugasi = 1;
            }
        }

    public void println(String str)
    {
            try
            {
                writer.WriteLine(str);
                writer.Flush();
            }
            catch (Exception e) {
               // MessageBox.Show("Server je ugasen!!");
                Application.Exit();
            }
        //buffer = Encoding.Unicode.GetBytes(str);
        //_network.Write(buffer, 0, buffer.Length);
    }

    public string readLine()
    {
            return reader.ReadLine();
        //buffer = new byte[_client.ReceiveBufferSize];
        //int data = _network.Read(buffer, 0, _client.ReceiveBufferSize);
        //return Encoding.Unicode.GetString(buffer, 0, data);
    }

    public void kraj()
    {
        println("KRAJ");
            if (_network != null)
        _network.Close();
            if (_client != null)
        _client.Close();
    }
}


}