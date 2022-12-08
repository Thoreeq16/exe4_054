using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Node
    {
        public int thoriq;
        public Node next;
        public Node(int i, Node n)
        {
            thoriq = i;
            next = n;
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
            Console.WriteLine("\n" + element + "Pushed.");
        }
        public void pop()
        {
            Console.WriteLine("\nThe pooped element is: " + top.thoriq);
            top = top.next; //Make top point to the next  node in sequence
        }
        public void display()
        {
            Node tmp;
            if (empty()) //If stack is empty
                Console.WriteLine("\nStack Empty");
            else
            {
                //Traverse the list from beggining till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.thoriq);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n**Stack Menu**\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your Choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a Number: ");
                        int num = (int)Convert.ToInt64(Console.ReadLine());
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
                        Console.WriteLine("\nInvalid Choice0");
                        break;
                }
            }
        }
    }
}