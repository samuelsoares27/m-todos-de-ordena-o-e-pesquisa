using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class ShellSort
    {
        private string total = "";
        public ShellSort(int[] vetor, int tamanho)
        {
            int h = 1;
            int i = 0;
            int j = 0;
            int k = 0;
            while (h<tamanho)
            {
                h = h * 3 + 1;
            }
            while (h > 0)
            {
                i = h;
                while (i < tamanho)
                {
               
                    j = i - h;
                    k = vetor[i];
                    while (j >= 0 && vetor[j] > k)
                    {
                        vetor[j + h] = vetor[j];
                        vetor[j] = k;
                        j = j - h;

                    }
                    i++;
                }
                h = h / 3;
            }
            for (int z = 0; z < tamanho; z++)
            {
                total += vetor[z] + " ";
            }
        }
        public string vetorordenado()
        {
            return total;
        }

    }
}
