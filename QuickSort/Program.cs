using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string a = Console.ReadLine();
            //  string b = Console.ReadLine();
            //string c1=  a.ToUpper();
            // string c2= b.ToUpper();
            //  char[] a1 = c1.ToCharArray();
            //  char[] b2 = c2.ToCharArray();
            //  Array.Sort(a1);
            //  Array.Sort(b2);
            //  a = new string(a1);
            //  b = new string(b2);

            //  if(a.Equals(b)==true)
            //  {
            //      Console.WriteLine("yes");
            //  }
            //  else
            //  {
            //      Console.WriteLine("no");
            //  }
            //  Console.ReadKey();

            //SortedList<int,int> lst= new SortedList<int, int>();
            //lst.Add(2, 7);
            //lst.Add(1, 4);
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Remove(3);
            //foreach (var i in lst.Keys)
            //    Console.WriteLine(i);



            // Dictionary<char, int> dict = new Dictionary<char,int>();
            // string str = Console.ReadLine();
            //// char[] arr = str.ToCharArray();
            // //Array.Sort(arr);
            // for(int i=0;i<str.Length;i++)
            // {   
            //    if((!dict.ContainsKey(str[i])))
            //     {
            //         dict.Add(str[i], i);
            //     } 

            // }
            // foreach(var i in dict.Keys)
            // {
            //     Console.Write(i);
            // }

            /*
                 string str = Console.ReadLine();

                 string[] arr = str.Split(' ');
                 foreach(var i in arr)
                 {
                     Console.WriteLine(i);
                 }
                */

            //string str = Console.ReadLine();
            //char[] arr= new char[str.Length];
            //int j = 0;
            //for(int i=0;i<str.Length;i++)
            //{
            //    if(!arr.Contains(str[i]))
            //    {
            //        arr[j] = str[i];
            //        j++;
            //    }
            //}

            //foreach(var i in arr)
            //{
            //    Console.Write(i);
            //}
            //string str = Console.ReadLine();
            //if(str.Contains(' '))
            //{
            //    str.Remove(' ');
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();

            //int a=10;
            //int b = 100;
            //int[] arr=new int[100];
            //int i = 0;
            //while(b!=0)
            //{
            //    arr[i] = b % 2;
            //    b = b / 2;
            //    i++;
            //    if(b==0)
            //    {
            //        Array.Resize(ref arr, i);
            //    }
            //}
            //Array.Reverse(arr);
            //foreach(var p in arr)
            //{
            //    Console.Write(p);
            //}
            //Console.ReadKey();

            //sortedList lst = new sortedList();

            //lst.Add(1);
            //lst.Add(5);
            //lst.Add(3);
            //lst.display();
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddLast(2);
            //list.AddLast(3);
            //LinkedListNode<int> obj = list.Find(2);
            //list.AddAfter(obj, 5);

            //foreach(var i in list)
            //{
            //    Console.WriteLine(i);
            //}



            //string str = Console.ReadLine();
            //Console.WriteLine(str.Length);
            //string[] substrings = new string[100];
            //string[] tempsubstring = new string[100];
            //int[] count = new int[100];
            //int n = 0;
            //int b = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = i + 1; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            tempsubstring[i] = str.Substring(i, j - i + 1);
            //            string temp = tempsubstring[i];
            //            char[] arr = tempsubstring[i].ToCharArray();
            //            Array.Reverse(arr);
            //            string newstr = new string(arr);
            //            if (newstr.Equals(temp) && !substrings.Contains(newstr))
            //            { 
            //                substrings[n] = tempsubstring[i];
            //                n++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(b);
            //int max = 0;
            //int index=0;
            //int[] nos = new int[n];
            //for(int k=0;k<n;k++)
            //{
            //    nos[k] = substrings[k].Length;
            //    if(max<nos[k])
            //    {
            //        max = nos[k];
            //        index = k;
            //    }

            //}


            //Console.WriteLine(substrings[index]);

            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //char[] arr = new char[200];
            //int max = 0;
            //int index = 0;
            //string[] tempstring=new string[100];
            //int tempstringsize = 1;
            //int n = 0;
            //int m = 0;
            //for(int i=0;i<str1.Length;i++)
            //    {
            //    int str1index = 0;
            //    for(int j=0;j<str2.Length;j++)
            //    {
            //      if(str1[i]==str2[j])
            //        {
            //            arr[m] = str1[i];
            //            if(m>0)
            //            {
            //                string check = new string(arr);
            //                if (!tempstring.Contains(check))
            //                {
            //                    tempstring[n] = new string(arr);

            //                    Array.Resize(ref tempstring, tempstringsize + 1);
            //                    tempstringsize++;

            //                    n++;

            //                }
            //            }
            //            m++;

            //        }
            //        str1index++;
            //    }
            //}
            //foreach (var i in tempstring)
            //{
            //    Console.WriteLine(i);
            //}



            //QuickSort
            //int[] arr = { 5, 4, 7, 2, 3, 6 };

            //QuicSort.quickSort(arr, 0, 5);
            //foreach (var i in arr)
            //{
            //    Console.Write(i + " ");
            //}


            //Dynamic Programming
            //Fibonacci obj = new Fibonacci();
            //Console.Write("0 1 ");
            //for(int i=2;i<5;i++)
            //{
            //    Console.Write(obj.FibSeries(i) + " ");
            //}
            Console.ReadKey();

        }
    }
}
