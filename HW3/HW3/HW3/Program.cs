using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static Dictionary<char, int> GetCharacterFrequency(string input)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach (char c in input.ToLower())
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency.Add(c, 1);
                }
            }
            return frequency;
        }

        static void PrintFrequency(Dictionary<char, int> frequency)
        {
            foreach (KeyValuePair<char, int> pair in frequency)
            {
                Console.Write($"{pair.Key}={pair.Value}");
                if (!pair.Equals(frequency.Last()))
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');

            foreach (string str in inputs)
            {
                string trimmedStr = str.Trim();
                if (!string.IsNullOrEmpty(trimmedStr))
                {
                    Dictionary<char, int> charFrequency = GetCharacterFrequency(trimmedStr);
                    PrintFrequency(charFrequency);
                }
            }
        }
    }
}
