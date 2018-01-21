using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prims_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];
            int[] visited = new int[5];
            int u = 0, v = 0, min, total = 0; ;
            Console.WriteLine("Enter the wieights of the matrix");
            for(int i=0;i<5;i++)
            {
                visited[i] = 0;
                for(int j=0;j<5;j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    if(matrix[i,j]==0)
                    {
                        matrix[i, j] = 999;
                    }
                }

            }
            visited[0] = 1;
            for(int counter=0;counter<4;counter++)
            {
                min = 999;
                for(int i=0;i<5;i++)
                {
                    if(visited[i]==1)
                    {
                        for(int j=0;j<5; j++)
                        {
                            if(visited[j]!=1)
                            {
                                if(min>matrix[i,j])
                                {
                                    min = matrix[i, j];
                                    u = i;
                                    v = j;
                                }
                            }
                        }
                    }
                }
                visited[v] = 1;
                total += min;
                Console.WriteLine("Edge found" + u + "->" + v + " Weight:" + min);
            }
            Console.WriteLine("Min cost is" + total);
            Console.ReadLine();
        }
    }
}
