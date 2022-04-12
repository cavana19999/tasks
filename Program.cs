using System;
using System.Linq;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array1 = new int[] { 100, 20, 90, 50, 60, 10, 40, 60, 80, 95 };
            int[] array2 = new int[] { 55, 97, 50, 43, 10, 10, 80, 89, 20, 75 };

            //union
            var query1 = (from i in array1 select i).Union(from j in array2 select j);

            foreach (int i in query1)
            {
                Console.WriteLine(i);
            }           

            //intersect
            var query2 = (from i in array1 select i).Intersect(from j in array2 select j);

            foreach (int i in query2)
            {
                Console.WriteLine(i);
            }

            //except
            var query3 = (from i in array1 select i).Except(from j in array2 select j);

            foreach (int i in query3)
            {
                Console.WriteLine(i);
            }

            //concat
            var query4 = (from i in array1 select i).Concat(from j in array2 select j);

            foreach (int i in query4)
            {
                Console.WriteLine(i);
            }

            //aggregate functions

            int sum1 = (from i in array1 select i).Sum();
            int sum2 = (from i in array2 select i).Sum();
            Console.WriteLine("Total Sum of two arrays:-" + (sum1 + sum2));                    

            int max1 = (from i in array1 select i).Max();
            int max2 = (from i in array2 select i).Max();
            Console.WriteLine("Maximum number in both arrays:-" + (max1, max2));

            int min1 = (from i in array1 select i).Min();
            int min2 = (from i in array2 select i).Min();
            Console.WriteLine("Minimum number in both arrays:-" + (min1, min2));

            double avg1 = (from i in array1 select i).Average();
            double avg2 = (from i in array2 select i).Average();
            Console.WriteLine("Average of arrays:-" + (avg1, avg2));

            int count1 = (from i in array1 select i).Count();
            int count2 = (from i in array2 select i).Count();
            Console.WriteLine("Total number of elements in two arrays:-" + (count1, count2));

            var dis1 = (from i in array1 select i).Distinct();
            foreach (var i in dis1)
            {
                Console.WriteLine(i);
            }

        }
    }
}