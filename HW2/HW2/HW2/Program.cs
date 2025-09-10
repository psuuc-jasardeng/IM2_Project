using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            List<double> numbers = new List<double>();

            
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number{j + 1}: ");
                    numbers.Add(double.Parse(Console.ReadLine()));
                }
            }

       
            Console.WriteLine("\nThe numbers are:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]:F1} ");
                if ((i + 1) % cols == 0)
                {
                    Console.WriteLine();
                }
            }

            
            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            double average = sum / numbers.Count;

          
            Console.WriteLine($"\nSum: {sum:F1}  Average: {average:F1}");
        }
    }
    }
