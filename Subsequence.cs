using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Subsequence
    {
       public static int LCS(string s1,string s2)
        {
            int n1 = s1.Length;
            int n2 = s2.Length;
            int[,] lcs = new int[n1+1, n2+1];
                for(int i=0;i<=n1;i++)
            {
                for(int j=0;j<=n2;j++)
                {
                    if(i==0||j==0)
                    {
                        lcs[i, j] = 0;
                    }
                    else if(s1[i-1]==s2[j-1])
                    {
                        lcs[i, j] = 1 + lcs[i - 1, j - 1];
                    }
                    else
                    {
                        lcs[i, j] = (lcs[i - 1, j] > lcs[i, j - 1] ? lcs[i - 1, j] : lcs[i, j - 1]);
                    }
                }
            }
            return lcs[n1, n2];
        }
    }
}
