using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;

namespace PainelPingDinamico
{
    public partial class JanelaPrincipal : Form
    {
        List<Painel> lista;

        public JanelaPrincipal()
        {            
            InitializeComponent();
            lista = new List<Painel>();
        }

        private void adicionarPainelToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Painel painel = new Painel("8.8.8.8", 1450, "Google");
           // painel.MdiParent = this;            
           // painel.Show();
           // this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            
        }

        private void ladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Painel p4 = new Painel("8.8.8.8", 1450, "Google");
            p4.MdiParent = this;
            p4.Show();

            Painel p3 = new Painel("8.8.8.8", 1450, "Google");
            p3.MdiParent = this;
            p3.Show();

            Painel p2 = new Painel("8.8.8.8", 1450, "Google");
            p2.MdiParent = this;
            p2.Show();

            Painel p1 = new Painel("8.8.8.8", 1450, "Google");
            p1.MdiParent = this;
            p1.Show();

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);            

            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void iniciarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Painel p in lista){
                p.iniciar();
            }
        }

        private void pararTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Painel p in lista)
            {
                p.parar();
            }
        }
    }
}
