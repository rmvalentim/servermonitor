using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainelPingDinamico
{
    public partial class Painel : Form
    {
        private int contador = 0;
        private string ip;
        private int tamanhoPacote = 1450;
        private int tempo = 1;
        private string localidade;       

        public Painel(string ip, int tamanhoPacote, string localidade)
        {
            this.ip = ip;
            this.tamanhoPacote = tamanhoPacote;
            this.localidade = localidade;
            Console.WriteLine(localidade);

            this.ControlBox = false;
            this.Text = String.Empty;           

            InitializeComponent();

            this.Text = ip;
            this.lblLocalidade.Text = localidade;
            
        }

        public void iniciar()
        {
            timer.Interval = this.tempo * 1000;
            timer.Start();
        }

        public void parar()
        {
            timer.Stop();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            timer.Interval = this.tempo * 1000;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            PainelConfig pc = new PainelConfig();
            pc.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 200)
            {
                listView1.Clear();
            }

            // Cria uma string do tamanho do pacote a enviar
            // Cada caracter representa um byte
            string data = "";

            for (int i = 0; i < tamanhoPacote; i++)
            {
                data = String.Concat(data, "a");
            }

            Ping pingSender = new Ping();

            // Cria um buffer de dados que será o pacote enviado pelo PING
            // Do tamanho da String data
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Define o tempo de timeout
            // Cada 1000 representa um segundo
            int timeout = 1000;

            // Define as opções de transmissão do PING
            // A ser passado como parametro para o PingReply
            PingOptions options = new PingOptions(64, true);

            // Manda a requisição.
            // 1º Parametro = Endereço do Servidor.
            // 2º Parametro = Tempo de timeout em milisegundos.
            // 3º Parametro = Tamanho do pacote (em buffer).
            // 4º Parametro = Opcoes do PingOptions.
            PingReply reply = pingSender.Send(ip, timeout, buffer, options);

            string resultado;

            if (reply.Status == IPStatus.Success)
            {
                contador = 0;

                resultado = "Resposta de: " + reply.Address.ToString() + " Bytes=" + reply.Buffer.Length
                    + " Tempo=" + reply.RoundtripTime + "ms TTL=" + reply.Options.Ttl + " " + DateTime.Now.ToString("HH:mm:ss") + "                                                                                            ";
                

                listView1.Items.Add(resultado);

                if (reply.RoundtripTime < 100)
                {
                    int tamanho = listView1.Items.Count;
                    listView1.Items[--tamanho].BackColor = Color.LightGreen;

                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    //
                    listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                }
                else
                {
                    int tamanho = listView1.Items.Count;
                    listView1.Items[--tamanho].BackColor = Color.Yellow;
                    //
                    listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                }

            }
            else
            {
                contador++;

                if (contador >= 10)
                {
                    contador = 0;
                }

                resultado = "Esgotado tempo de espera                                                                                                                                                                 ";
                listView1.Items.Add(resultado);
                int tamanho = listView1.Items.Count;
                listView1.Items[--tamanho].BackColor = Color.Red;
                //
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();
            }
        }        
    }
}
