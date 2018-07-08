using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Métodos
{
    public partial class Ordena : Form
    {
        public Ordena()
        {
            InitializeComponent();
            btordena.Visible = false;
            btgrava.Visible =false;
        }

        BubleSort M;
        SelectSort S;
        ShellSort SS;
        QuickSort Q;
        string op = "";

        string vet = "";

        int[] v;
        List<int> salve = new List<int>();

        private void Ordena_Load(object sender, EventArgs e)
        {
            InicializaVetor();
        }
        private void InicializaVetor()
        {
            string[] vetor_aux = System.IO.File.ReadAllLines("arquivo.txt");

            for (int i = 0; i < vetor_aux.Count(); i++)
            {
                vetor_aux[i] = vetor_aux[i].Replace(" ", "/");
                List<string> ccc = vetor_aux[i].Split('/').ToList();
                for (int z = 0; z < ccc.Count; z++)
                {
                    if (ccc[z] != string.Empty)
                        salve.Add(int.Parse(ccc[z]));
                }
            }

            v = new int[salve.Count];
            for (int i = 0; i < salve.Count; i++)
            {
                v[i] = salve[i];
                textBox1.Text += v[i].ToString() + " ";
            }
        }



        private void btordena_Click(object sender, EventArgs e)
        {
            if (op == "BubleSort")
            {
                M = new BubleSort(v, v.Count());
                vet = M.vetorordenado();
                lbvetor.Text = vet;
            }
            if (op == "SelectSort")
            {
                S = new SelectSort(v, v.Count());
                vet = S.vetorordenado();
                lbvetor.Text = vet;
            }
            if (op == "ShellSort")
            {
                SS = new ShellSort(v, v.Count());
                vet = SS.vetorordenado();
                lbvetor.Text = vet;
            }
            if (op == "QuickSort")
            {
                Q = new QuickSort();
                int[] ve = Q.quickSort(v, 0, v.Count() - 1);
                for (int z = 0; z < ve.Count(); z++)
                {
                    vet += ve[z] + " ";
                }
                lbvetor.Text = vet;
            }

            btgrava.Visible = true;

            pnordena.Enabled = true;
        }

        private void btMétodos_Click(object sender, EventArgs e)
        {
            if (rbBublesort.Checked)
            {
                op ="BubleSort";
            }
            if(rbSelectSort.Checked)
            {
                op = "SelectSort";
            }
            if(rbShellSort.Checked)
            {
                op = "ShellSort";
            }
            if(rbQuickSort.Checked)
            {
                op = "QuickSort";
            }
            pnordena.Enabled = false;
  
            btordena.Visible = true;
            lbvetor.Text = "";
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter escreva = new StreamWriter("arquivo_resposta.txt");
                escreva.WriteLine(vet);

                MessageBox.Show("Salvo com sucesso");
                escreva.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            btordena.Visible = false;
        }

        private void btvolta_Click(object sender, EventArgs e)
        {
            menu M = new menu();
            M.Show();
            this.Visible = false;
        }
    }
}
