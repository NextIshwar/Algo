using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Linkedlist
    {
        public Node Head;
        public Node current;
        public Linkedlist()
        {
            Head = new Node();
            current = Head;
         
        }
        
        public void add(object data)
        {
            Node newNode= new Node();
            newNode.value = data;
            current.next = newNode;
            current = newNode;
            current.next = null;
        }
        public void displayNode()
        {
            Node curr=Head;
            
            while(curr.next!=null)
            {
                curr = curr.next;
                Console.WriteLine(curr.value);
                

            }
            Console.ReadLine();
        }


        public void addatfirst(object data)
        {
            Node newnode = new Node();
            newnode.value = data;
            newnode.next = Head.next;
            Head.next = newnode;
        }


      /*  public void delete(object n)
        {
            Node curr = Head ;
            if (Head.next.value.Equals(n))
            {
                Head = Head.next;
            }
            else
            {
                Node currNext = curr.next;
                while (curr.next != null)
                {
                    if (currNext.value.Equals(n))
                    {
                        curr = currNext.next;
                        break;
                    }
                    curr = curr.next;
                    currNext = currNext.next;
                }
            }
        }*/

        public void delete_it(object n)
        {
            Node temp = Head;
            while(!temp.next.value.Equals(n) && temp != null)
            {
                temp = temp.next;
            }

            temp.next = temp.next.next;
            
        }
        public void removefromLast()
        {
            Node curr = Head;
            while(curr.next!=null)
            {
                curr = curr.next;
               if( curr.next.next==null)
                {
                    curr.next = null;
                    break;
                }
            }
        }
    }
}
