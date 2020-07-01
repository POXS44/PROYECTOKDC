using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Inicidador
{
    public partial class Form1 : Form
    {
        byte[] ka = System.Text.UTF8Encoding.UTF8.GetBytes("12345678901234567890123456789012");
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_conectar_Click(object sender, EventArgs e)
        {
            int puerto = Int32.Parse(tb_puerto.Text);
            string nombre = tb_numero.Text;
            rbt_log.Text = "\nIniciando";

            TcpClient cliente = new TcpClient(nombre, puerto);

            if (cliente.Connected)
            {
                rbt_log.AppendText("\nconectado");
                var destino = tb_destino.Text;
                var numero = Int32.Parse(tb_numero.Text);

                NetworkStream stream = cliente.GetStream();

                Byte[] mensaje = System.Text.Encoding.ASCII.GetBytes(tb_destino.Text);
                // byte[] mensajecifrado = Utilidad_Cifrado.EncryptString(mensaje,ka);


                using (RijndaelManaged myRijndael = new RijndaelManaged())
                {
                    myRijndael.GenerateIV();
                    Utilidad_Cifrado2.IV =  myRijndael.IV;
                    myRijndael.Key = ka;
                    byte[] cifrado = Utilidad_Cifrado2.EncryptStringToBytes(tb_destino.Text, myRijndael.Key, myRijndael.IV);
                    stream.Write(cifrado, 0, mensaje.Length);
                }
                rbt_log.AppendText("\n" + tb_destino.Text);
                rbt_log.AppendText("\n"+ ByteArrayToString(mensaje));
            }

            
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length + 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
