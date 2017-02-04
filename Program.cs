using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170128_SortersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            double[] numbers = new double[1000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.NextDouble();
            }

            
            TestSortMethod(new InsertSorter(numbers));          
            TestSortMethod(new BoobleSorter(numbers));
            TestSortMethod(new QuickSorter(numbers));
            TestSortMethod(new MergeSort(numbers));

            double[] numbers1 = new double[10000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers1[i] = i;
            }

            TestSortMethod(new InsertSorter(numbers1));
            TestSortMethod(new BoobleSorter(numbers1));
            TestSortMethod(new QuickSorter(numbers1));
            TestSortMethod(new MergeSort(numbers1));

            double[] numbers2 = new double[1000000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = numbers.Length-i;
            }

            TestSortMethod(new InsertSorter(numbers2));
            TestSortMethod(new BoobleSorter(numbers2));
            TestSortMethod(new QuickSorter(numbers2));
            TestSortMethod(new MergeSort(numbers2));

            Console.ReadKey();
        }

        private static void TestSortMethod(Sorter s)
        {
            double start = Environment.TickCount;
            s.Sort();
            double time = Environment.TickCount - start;
            s.Time = time;
            Console.WriteLine(s);
            Console.WriteLine();
      
        }
    }
}
