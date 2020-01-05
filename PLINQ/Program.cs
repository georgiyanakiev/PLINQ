using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
   public static class Program1
    {
         public static void Main()
        {
            var num = Enumerable.Range(0, 20);
            try
            {
                var pResult = num.AsParallel()
                    .Where(i => CheckIfIsEven(i));


                //foreach (int i in pResult.Take(5))
                //    Console.WriteLine(i);
                //Console.ReadLine();
                pResult.ForAll(e => Console.WriteLine(e));
                Console.ReadLine();
            }
            catch(AggregateException e)
            {
                Console.WriteLine("There are {0} exceptions", e.InnerExceptions.Count);
                
            }

        }

        public static bool CheckIfIsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
