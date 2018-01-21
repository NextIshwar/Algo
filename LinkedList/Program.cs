using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();

            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);
            list.add(5);
            list.add(12);
            list.addatfirst(5);
            list.addatfirst(0);
            list.add(6);
            list.addatfirst(8);
            list.addatfirst(89);
            list.removefromLast();
            list.delete_it(3);
            list.delete_it(89);
            list.delete_it(6);
            list.displayNode();
        }
    }
}
