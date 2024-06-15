using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Finding_the_largest_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = {11,25,03,44,5,63,700,88,91,10};
            int max = number[0];
            foreach (var item in number)
            {
                if (item > max) 
                {
                    max= item;
                }
            }
                    Console.WriteLine($"Maximum Number is: {max}");
        }
    }
}
