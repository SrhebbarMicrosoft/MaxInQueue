using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxInQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string[] tokens = Console.ReadLine().Split();
            PriorityQueue pq = new PriorityQueue(tokens);
            int q = int.Parse(Console.ReadLine().Trim());
            while (q-- != 0)
            {
                string[] queries = Console.ReadLine().Split();
                if (queries[0] == "1")
                {
                    pq.Add(queries[1]);
                }
                else
                {
                    Console.WriteLine(pq.Max);
                }
            }
        }
    }

    internal class PriorityQueue
    {
         Queue<int> q = new Queue<int>();
        public int Max = 0;

        public PriorityQueue(string[] tokens)
        {
            foreach (string c in tokens)
            {
                Add(c);
            }
        }

        internal void Add(string v)
        {
            int t = int.Parse(v);
            if (Max < t)
                Max = t;
            q.Enqueue(t);

        }
    }

}
