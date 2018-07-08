using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Métodos
{
    public partial class Tempo : Form
    {
        public Tempo()
        {
            InitializeComponent();
     
        }
        Thread t1, t2, t3, t4;
        DateTime hi1, hf1;
        Random Numero = new Random();
        int[] v1;
        int countHora = 1;
        bool c1, c2, c3, c4;


   
        BubleSort b;
        ShellSort s;
        SelectSort ss;
        QuickSort q;

        private void Tempo_Load(object sender, EventArgs e)
        {
            
        }

        private void btvolta_Click(object sender, EventArgs e)
        {
            menu M = new menu();
            M.Show();
            this.Visible = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            v1 = new int[int.Parse(textBox1.Text.Trim())];
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                v1[i] = Numero.Next(100, 100000);
            }

            lbtemp1.Text = lbtemp2.Text = lbtemp3.Text = lbtemp4.Text = "Tempo:";

            t1 = new Thread(QuickSort);
            t2 = new Thread(SelectSort);
            t3 = new Thread(ShellSort);
            t4 = new Thread(BubleSort);
            t1.IsBackground = t2.IsBackground = t3.IsBackground = t4.IsBackground = false;

            t4.Start();
            t3.Start();
            t2.Start();
            t1.Start();
            tmr_hora.Enabled = true;
        }

        private void tmr_hora_Tick(object sender, EventArgs e)
        {
            if (!c1 || !c2 || !c3 || !c4)
            {
                label7.Text = countHora.ToString();
                countHora++;
            }
            else
            {
                tmr_hora.Enabled = false;
                countHora = 0;
            }
        }

        private void QuickSort()
        {
            hi1 = DateTime.Now;
            q = new QuickSort();
            int[] ve = q.quickSort(v1, 0, v1.Count() - 1);
            hf1 = DateTime.Now;
            this.Invoke((MethodInvoker)delegate
            {
                lbtemp2.Text = "Tempo:" + "\n" + (hf1 - hi1).ToString();
            });
            c1 = true;
        }

        private void SelectSort()
        {
            hi1 = DateTime.Now;
            ss = new SelectSort(v1, v1.Count());
            hf1 = DateTime.Now;
            this.Invoke((MethodInvoker)delegate
            {
                lbtemp3.Text = "Tempo:" + "\n" + (hf1 - hi1).ToString();
            });
            c2 = true;
        }

        private void ShellSort()
        {
            hi1 = DateTime.Now;
            s = new ShellSort(v1, v1.Count());
            hf1 = DateTime.Now;
            this.Invoke((MethodInvoker)delegate
            {
                lbtemp4.Text = "Tempo:" + "\n" + (hf1 - hi1).ToString();
            });
            c3 = true;
        }

        private void BubleSort()
        {
            hi1 = DateTime.Now;
            b = new BubleSort(v1, v1.Count());
            hf1 = DateTime.Now;     
            this.Invoke((MethodInvoker)delegate
            {
                lbtemp1.Text = "Tempo:" + "\n" + (hf1 - hi1).ToString();
            });
            c4 = true;
        }
    }
}
