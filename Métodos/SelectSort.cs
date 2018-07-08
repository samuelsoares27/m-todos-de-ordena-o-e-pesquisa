using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class SelectSort
    {
        private string total = "";
        public SelectSort(int[] vetor, int tamanho)
        {
            int i, j, menor, aux;

            for (i = 0; i < tamanho - 1; ++i)
            {
                menor = i;
                for (j = i + 1; j < tamanho; ++j)
                {
                    if (vetor[j] < vetor[menor])
                        menor = j;
                }
                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
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
