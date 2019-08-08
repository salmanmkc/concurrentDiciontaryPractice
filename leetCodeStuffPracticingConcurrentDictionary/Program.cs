using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeStuffPracticingConcurrentDictionary
{
    class Program
    {
        static public void Main()
        {
            string userinput = Console.ReadLine();
            ConcurrentDictionary<char, int> mapping = new ConcurrentDictionary<char, int>();
            foreach (var c in userinput)
            {
                mapping.AddOrUpdate(c, 1, (key, oldvalue) => oldvalue + 1);
            }
            StringBuilder sb = new StringBuilder();
            foreach (var c in mapping)
            {
                sb.Append(c);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
