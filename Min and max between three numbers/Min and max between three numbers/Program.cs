using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_and_max_between_three_numbers
{
    class Program
    {
        static void MinMax(int []a)
        {
            int min = 1000000000;
            int max = 0;
            for(int i =0 ; i < a.Length ; i++)
            {
                if (min > a[i])
                    min = a[i];
                if (max < a[i])
                    max = a[i];
            }
            Console.WriteLine($"Max : {max}");
            Console.WriteLine($"Min : {min}");
        }
        static void Main(string[] args)
        {
            int i = 0;
            int[] adad = new int[3];
            for (i=0 ; i < adad.Length; i++) 
            {
                Console.Write($"Adade {i + 1} ra vared konid : ");
                adad[i] = int.Parse(Console.ReadLine());
            }
            MinMax(adad);
            Console.ReadKey();
        }
    }
}
