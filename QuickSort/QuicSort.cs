<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class QuicSort
    {
      static  public int Partition(int[] numbers, int l, int r)
        {
            int i = l - 1;
            int pivot = numbers[r];
            for (int j = l; j < r; j++)
            {
                if (numbers[j] < pivot)
                {
                    i++;
                    int temporary = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temporary;
                }

            }
            i++;
            int temp = numbers[i];
            numbers[i] = numbers[r];
            numbers[r] = temp;
            return i;
        }
       static public void quickSort(int[] A, int l, int r)
        {
            int pivot = Partition(A, l, r);
            if (l < r)
            {
                quickSort(A, l, pivot - 1);
                quickSort(A, pivot, r);
            }

        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class QuicSort
    {
      static  public int Partition(int[] numbers, int l, int r)
        {
            int i = l - 1;
            int pivot = numbers[r];
            for (int j = l; j < r; j++)
            {
                if (numbers[j] < pivot)
                {
                    i++;
                    int temporary = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temporary;
                }

            }
            i++;
            int temp = numbers[i];
            numbers[i] = numbers[r];
            numbers[r] = temp;
            return i;
        }
       static public void quickSort(int[] A, int l, int r)
        {
            int pivot = Partition(A, l, r);
            if (l < r)
            {
                quickSort(A, l, pivot - 1);
                quickSort(A, pivot, r);
            }

        }

    }
}
>>>>>>> 777d29eb166ba0d656d437af4b52c29116a5b3a5
