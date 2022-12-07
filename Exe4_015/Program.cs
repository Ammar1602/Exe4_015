using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_015
{
    class Node
    {
        public int info;
        public Node next;

        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Program
    {
        //Aaray to be searched
        int[] ammar = new int[33];
        //Number of element in the array 
        int nt;
        //Get the number of elements to show in the array
        int io;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array:");
                string s = Console.ReadLine();
                if ((nt > 0) && (nt <= 33))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 33 elements.\n");
            }
            //
            Console.WriteLine("");
            Console.WriteLine("======================");
            Console.WriteLine(" Enter Array Elements ");
            Console.WriteLine("======================");
            for (io = 0; io < nt; io++)
            {
                Console.Write("<" + (io + 1) + ">");
                string s1 = Console.ReadLine();
                ammar[io] = Int32.Parse(s1);
            }
        }
    }

    class Stacks
    {
        Node top;

        public Stacks()
        {
            top = null;

        }

        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }

        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed. ");
        }

        public void pop()
        {
            Console.WriteLine("\nThe Popped Element Is: " + top.info);
        }

        public void display()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("\n==Stack Menu==\n");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. Exit ");
                Console.WriteLine("\nEnter Your Choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "30" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter A Number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}
