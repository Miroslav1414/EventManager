using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ServerC
{
    class Server
    {
        //public static MySqlConnection conn;
        //public static string userId = "student";
        //public static string pass = "student";
        //public static string server = "server";
        

static void Main(string[] args)
        {

            
            try
            {
                TcpListener listen = new TcpListener(IPAddress.Any, 1200);
                Console.WriteLine("Server je pokrenut...");
                listen.Start();
                while (true)
                {
                    TcpClient client = listen.AcceptTcpClient();
                    Console.WriteLine("Client connected");
                    new ServerThread(client);
                }
                
                //Console.ReadKey();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }
    }
} 
