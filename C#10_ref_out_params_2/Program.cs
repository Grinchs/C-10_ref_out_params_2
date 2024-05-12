using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_10_ref_out_params_2
{
    internal class Program
    {
        public class MansMath
        {
            public static double Min(params double[] x)
            {
                double min = x[0];
                for (int i = 1; i < x.Length; i++)
                {
                    if (x[i] < min)
                    {
                        min = x[i];
                    }
                }
                return min;
            }
            public static double Max(params double[] x)
            {
                double max = x[0];
                for (int i = 1; i < x.Length; i++)
                {
                    if (x[i] > max)
                    {
                        max = x[i];
                    }
                }
                return max;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Min (1, 2, 3, 4, 5): {MansMath.Min(1, 2, 3, 4, 5)}");
            Console.WriteLine($"Max (1, 2, 3, 4, 5): {MansMath.Max(1, 2, 3, 4, 5)}");

            double[] x = { 6, 7, 8, 9, 10 };
            Console.WriteLine($"Min (6, 7, 8, 9, 10): {MansMath.Min(x)}");
            Console.WriteLine($"Max (6, 7, 8, 9, 10): {MansMath.Max(x)}");

            Console.WriteLine($"Min (1, 2, 3): {MansMath.Min(1, 2, 3)}");
            Console.WriteLine($"Max (1, 2, 3): {MansMath.Max(1, 2, 3)}");

            Console.WriteLine($"Min (10, 20, 30): {MansMath.Min(10, 20, 30)}");
            Console.WriteLine($"Max (10, 20, 30): {MansMath.Max(10, 20, 30)}");
        }
    }
}

