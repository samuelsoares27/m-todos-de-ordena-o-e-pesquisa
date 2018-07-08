using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class BubleSort
    {
        private string total = "";

        public BubleSort(int[] vetor, int tamanho)
        {
        
            int repos = 0;
            for (int i = 0; i < tamanho - 1; i++)
            {
                for (int j = 0; j < tamanho - (i + 1); j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        repos = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = repos;
                    }
                }
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
