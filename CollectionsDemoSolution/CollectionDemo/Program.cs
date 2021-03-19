using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----WELCOME TO C# COLLECTIONS-----");
            doSetDemo();
            doQueueDemo();
            doDictionaryDemo();
            doStackDemo();
            doListDemo();
            Console.ReadKey();
        }

        public static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Prashik");
            set.Add("Ravi");
            set.Add("Myself");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }

        public static void doQueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Prashik Jaware");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Gautam Buddha");
            queue.Enqueue("Ram");
            Console.WriteLine("Head: " + queue.Peek());
            Console.WriteLine("\nIterating the queue elements: ");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeu element: " + dequeue);
            Console.WriteLine("\nIterating the queue elements after dequeue one element: ");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Prashik");
            dictionary.Add(101, "Gautam");
            dictionary.Add(102, "Ram");
            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionay: ");
            foreach (var element in dictionary)
            {
                Console.WriteLine("key=" + element.Key + " & Value= " + element.Value);
            }

        }
        public static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Prashik");
            stack.Push("Gravit");
            stack.Push("Garina");
            stack.Push("Gautam");
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: " + pop);
        }

        public static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Gautam");
            list.Add("Ram");
            list.Add("Prashik");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
