using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Inserting an element");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

        }
    }
}