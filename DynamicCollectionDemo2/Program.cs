using System.Collections.Concurrent;

namespace DynamicCollectionDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List
            // store n number of ints and work with that
            List<string> list = new List<string>();
            Console.WriteLine(list.Capacity);


            list.Add("sdfsdf");
            list.Add("sdfsdf");
            list.Add("sdfsdf");
            list.Add("sdfsdf");

            list.Add("sdfsdf");
            list.TrimExcess();
            Console.WriteLine(list.Capacity);

            //list.Add("sdfsdf");

            // read

            Queue<int> queue = new Queue<int>();
            // add
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            // read
            queue.Dequeue();
            queue.Peek();

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // read
            stack.Pop();
            stack.Peek();

            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(1);

            Dictionary<int, string> result = new Dictionary<int, string>();
            // add
            result.Add(1, "Pass");
            result.Add(2, "Fail");
            // read

            string r = result[1];

            // use these in multi threaded app
            ConcurrentQueue<int> ints = new ConcurrentQueue<int>();
            ConcurrentStack<int> ints1 = new ConcurrentStack<int>();

        }
    }
}
