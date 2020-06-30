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

namespace Receptor
{
    public partial class Form1 : Form
    {

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
                rbt_log.AppendText("\nEsperando Clientes");
                TcpClient cliente = await server.AcceptTcpClientAsync();
                rbt_log.AppendText("\nconectado");
                cliente.Close();

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
