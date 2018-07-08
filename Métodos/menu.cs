using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adicionarValorNoTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addvalor A = new Addvalor();
            A.Show();
            this.Visible = false;
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordena F = new Ordena();
            F.Show();
            this.Visible = false;
        }

        private void tempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tempo t = new Tempo();
            t.Show();
            this.Visible = false;
        }
    }
}
