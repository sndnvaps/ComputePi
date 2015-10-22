using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CalculatePi
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            System.Double PI = 0.0;

           System.DateTime beforeDT = System.DateTime.Now;

          PI =   CalculatePi(100000);

          System.DateTime afterDT = System.DateTime.Now;

          System.TimeSpan ts = afterDT.Subtract(beforeDT);

            Console.WriteLine("Pi = {0}\n", PI);
            Console.WriteLine("TimeSpan = {0} ms \n", ts.Milliseconds.ToString());

          */
            Stopwatch timer = System.Diagnostics.Stopwatch.StartNew();
             int DIGITS = 100000;
             int LEN = 10;
           

            long[] pi = new ComputePi().Compute(DIGITS / LEN);
            timer.Stop();
            Console.Error.WriteLine("{0} seconds", timer.Elapsed.TotalSeconds);
            Console.Write(pi[pi.Length - 1] + ".");
            for (long i = pi.Length - 2; i > 0; i--)
                Console.Write(pi[i].ToString("D" + LEN));

            Console.Write("\n");

            Console.Error.WriteLine("\n{0} seconds\n", timer.Elapsed.TotalSeconds);

        }

        static double CalculatePi(System.UInt64 n)
        {
            System.Double result = 0.0;
            System.UInt64 index = 1;
            for (index = 1; index <= n; index++)
            {
                result = result + (double)(1 / (index * index));
            }

            return System.Math.Sqrt(6 * result);
        }

        
    }
}
