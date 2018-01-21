using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  class sortedList
    {
        Node head;
        Node current = new Node();

        public sortedList()
        {
            
            head = null;
            current = head;
        }



        public void Add(int value)
        {
            if(head==null)
            {
                head = new Node();
                head.data = value;
                head.Next = null;
            }
            else if(head.data > value)
            {
               
                    Node newnode = new Node();
                    newnode.data = value;
                    head = newnode;
                    
                }
                else
                {
                    Node temp = head;

                    while(temp!=null)
                    {
                        if(temp.data>value)
                        {
                            Node n = new Node();
                            n.data = value;
                            temp.Next = n;
                            n.Next = temp.Next;
                            break;
                        }
                        temp = temp.Next;
                    }
                }
            }
        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.Next;
            }
        }
    }
       
    }

