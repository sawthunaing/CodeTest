using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 7, 2, 3,3,3, 4, 5, 3, 6,3,1,2,2,2,2,2,2,2,8,9,1,2, 7, 8, 1, 8, 8 };
          
            Dictionary<int, int> counts = new Dictionary<int, int>();
           
            foreach (int num in numbers)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                   
                }
                else
                {
                    counts.Add(num, 1);
                }
            }

            var maxCountNumber = counts.FirstOrDefault(x=> x.Value == counts.Values.Max()).Key;

            Console.WriteLine("maxCountNumber is :" + maxCountNumber);
            Console.ReadLine();

        }

    
    }
}
