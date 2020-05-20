using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp1
{
    class Mas
    {
        private double max;
        private double min;
        private double sum = 0;
        public Mas()
        {
        }
        public double[] ChangeMas(double[] mass)
        {
            int fl = 0;
            int ind1 = 0, ind2 = 0;
            max = mass.Max();
            min = mass.Min();
            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
                if (mass[i] == max || mass[i] == min)
                {
                    if (fl == 0)
                    {
                        fl = 1;
                        ind1 = i;
                        continue;
                    }
                    else if (fl == 1)
                    {
                        fl = 2;
                        ind2 = i;
                        continue;
                    }
                }
            }
            if (ind2 - ind1 != 1)
            {
                sum /= mass.Length;
                for (int i = ind1 + 1; i < ind2; i++)
                {
                    mass[i] = sum;
                }
            }
            return mass;
        }
    }
    class Program
    {
        static void Main()
        {
            double[] mass = new double[] { 1, 2, 5.3, 7, 0.5, 6, 12, 17, 13.2, 0.5 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();
            Mas mas = new Mas();
            mass = mas.ChangeMas(mass);
            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
        }
    }
}
