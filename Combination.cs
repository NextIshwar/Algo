using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Combination
    {
        public int combination(int n, int k)
        {
            int[,] f = new int[n + 1, k + 1];



            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= min(i, k); j++)
                {
                    if (j == 0 || j == i)
                    {
                        f[i, j] = 1;
                    }
                    else
                    {
                        f[i, j] = f[i - 1, j - 1] + f[i - 1, j];
                    }

                    }
                }
                return f[n, k];
            }
        static public int min(int a, int b)
        {

            int c = (a < b) ? a : b;
            return c;
        }
    }
      
            
        }
