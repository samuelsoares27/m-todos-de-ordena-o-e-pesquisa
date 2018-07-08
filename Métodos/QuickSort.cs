using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class QuickSort
    {
        public int[] quickSort(int[] v, int p, int r)
        {
            int x = v[(p + r) / 2];
            int i = p;
            int j = r;

            while (i <= j)
            {
                while (v[i] < x)
                {
                    i++;
                }

                while (v[j] > x)
                {
                    j--;
                }

                if (i <= j)
                {
                    int aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;

                    i++;
                    j--;
                }
            }
            if(p < j)
            {
                quickSort(v, p, j);
            }
            if(i < r)
            {
                quickSort(v, i, r);
            }

            return v;
        }



    }
}


