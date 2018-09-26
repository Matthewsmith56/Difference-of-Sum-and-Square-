using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[101];

            for (int i = 1; i <= 100; i++)
            {
                numsArray[i] = i;
            }

            int totalOfsquare = 0;
            int totalOfbase = 0;

            foreach (var i in numsArray)
            {
                totalOfsquare += (i * i);
                totalOfbase += i;
            }
            Console.WriteLine(totalOfbase * totalOfbase - totalOfsquare);
        }
    }
}
