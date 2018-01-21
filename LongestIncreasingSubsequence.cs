using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class LongestIncreasingSubsequence
    {
        public int Lis(int[] arr)
        {
            int[] LIS = new int[arr.Length + 1];
            for(int i=0;i<arr.Length;i++)
            {
                LIS[i] = 1;
            }
            for(int i=1;i<arr.Length;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if(arr[i]>arr[j]&&LIS[i]<LIS[j]+1)
                    {
                        LIS[i] = LIS[j] + 1;
                    }
                }
            }
            int max = LIS[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(LIS[i]>max)
                {
                    max = LIS[i];
                }
            }
            return max;
        }
    }
}
