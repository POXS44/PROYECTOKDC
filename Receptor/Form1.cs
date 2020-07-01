using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Receptor
{
    public partial class Form1 : Form
    {
        byte[] ka = System.Text.UTF8Encoding.UTF8.GetBytes("12345678901234567890123456789012");
        byte[] kb = System.Text.UTF8Encoding.UTF8.GetBytes("12345678901234567890123456789034");
       
        public static TcpListener server; 


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void bt_escuchar_Click(object sender, EventArgs e)
        {
            int puerto = Int32.Parse(tb_puerto.Text); 
            IPAddress direccion = IPAddress.Parse(tb_nombre.Text);

            server = new TcpListener(direccion,puerto);
            server.Start();
            rbt_log.Text = "Iniciado";
            while (true)
            {
                Byte[] mensaje = new byte[512];
                Byte[] IV = new byte[16];
                Byte[] resto = new byte[16];
                string obtenido = "";

                rbt_log.AppendText("\nEsperando Clientes");
                TcpClient cliente = await server.AcceptTcpClientAsync();
                MessageBox.Show(cliente.Client.RemoteEndPoint.ToString());
                rbt_log.AppendText("\nconectado");
                
                NetworkStream stream = cliente.GetStream();
                int i = 0;
               
               i=  stream.Read(mensaje,0,mensaje.Length);
                Array.Copy(mensaje, IV, 16);
                rbt_log.AppendText(Utilidad_Cifrado.ByteArrayToString(IV));
                Array.Copy(mensaje, IV.Length, resto, 0, 16);
                obtenido= Utilidad_Cifrado2.DecryptStringFromBytes(resto,ka,IV);
                rbt_log.AppendText("\n" + obtenido);

                /*
                while ((i = stream.Read(mensaje, 0, mensaje.Length)) != 0)
                {
                    rbt_log.AppendText("\n"+Utilidad_Cifrado.ByteArrayToString(mensaje));

                    byte[] mensajedecifrado = Utilidad_Cifrado.DecryptString(mensaje,ka);

                    //Translate data bytes to a  ASCII STRING
                    obtenido = System.Text.Encoding.ASCII.GetString(mensajedecifrado, 0, i);
                    rbt_log.AppendText("Recibido: " + obtenido);
                }
                */
                cliente.Close();

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
