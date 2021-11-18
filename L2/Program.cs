/* 
  
Дан массив X, содержащий 16 элементов. 
Вычислить и вывести значения 
di=(exi+2e−xi)/(5+sinxi−−−−−−−−√) 
и значения di>0,1. 

*/


using System;

namespace L2
{
    class Program
    {
        static void Main()
        {
            double[] x = new double[16];
            Random rnd = new Random();


            Console.WriteLine("Исходный массив :");
            for (int i = 0; i < x.Length; i++) 
            {
                x[i] = rnd.Next (-10,10); // для генерации вещественных чисел NextDouble()
                Console.Write(x[i] + " ");
            }


           Console.WriteLine("\n\nНовые значения:");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = (Math.Exp(x[i]) + 2 * Math.Exp(-x[i])) / Math.Sqrt((5 + Math.Sin(x[i])));
                Console.WriteLine(x[i]);

            }


            Console.WriteLine("\nЗначения массива > 0.1:");
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0.1)
                    Console.WriteLine(x[i]);
            }
        }
    }
}
