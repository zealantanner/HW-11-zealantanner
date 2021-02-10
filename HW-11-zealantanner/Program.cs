using System;

namespace CS1405_Lab
{/*
    class Program
    {
        static void Main(string[] args)
        {
        }
    }*/
    class DisplayFibonacci
    {
        static void Main()
        {

            //Console.WriteLine($"{thing} {number} {bigNumber}");






            int number;
            object thing;
            double bigNumber;
            number = 42;
            thing = number;
            bigNumber = (double)(int)thing;

            Console.WriteLine($"{thing} {number} {bigNumber}");

            number = (int)thing;
            Console.WriteLine($"{thing} {number} {bigNumber}");





            
            int totalCount;
            // Intentionally using ArrayList to demonstrate boxing
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            Console.Write("Enter a number between 2 and 1000:");
            totalCount = int.Parse(Console.ReadLine());
            if (totalCount == 7) // Magic number used for testing
            {
                // Triggers exception when retriving value as double.
                // list.Add(0); // Cast to double or 'D' suffix required.
                // Whether cast or using 'D' suffix,
            }
            else
            // CIL is identical.
            {
                list.Add((double)0);
            }
            list.Add((double)0); list.Add((double)1);
            for (int count = 2; count < totalCount; count++)
            {
                list.Add((double)(list[count - 1])! + (double)(list[count - 2])!);
            }
            // Using a foreach to clarify the box/unbox operations rather than
            Console.WriteLine(string.Join(", ", list.ToArray()));
            foreach (double count in list)
            {
                Console.Write("{0}, ", count);
            }
        }
    }
}
