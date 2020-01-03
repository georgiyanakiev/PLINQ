using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
   public static class Program1
    {
         public static void Main(string[] args)
        {
            var num = Enumerable.Range(0, 10);
            var pResult = num.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (int i in pResult)
                Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
