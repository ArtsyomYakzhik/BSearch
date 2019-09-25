using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bsearch(new int[] { 16, 10, 7, 5, 5}, 5));
        }

        static int bsearch(int[] sortedArray, int X)
        {
            return sortedArray.FirstOrDefault(element => element < X);
        }
    }
}
