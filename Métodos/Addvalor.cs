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
    public partial class Addvalor : Form
    {
        public Addvalor()
        {
            InitializeComponent();
            btgrava.Visible = false;
        }
        string []x= new string[10];
        int i = 0;
        string j = "";
        int k = 0;

 

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                StreamWriter escreva = new StreamWriter("arquivo.txt");
                int i = 0;
                foreach (var item in x)
                {
                    escreva.WriteLine(x[i]);
                    i++;
                }
                
                escreva.Close();
                MessageBox.Show("Gravado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btvolta_Click(object sender, EventArgs e)
        {
            menu M = new menu();
            M.Show();
            this.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
       
                if (i < 10)
                {
             
                     if ((Keys)e.KeyChar == Keys.Enter)
                     {
                          x[i] = textBox1.Text;
                           j += x[i];  
                           k = i+1;
                           label2.Text = "Números: " + k.ToString();
                           label3.Text = "Números:" + j;
                           textBox1.Text = "";
                           i++;
                    }
                }
            btgrava.Visible = true;
        }
    }
}

      
