using System;

class Program
{
   
    static string CheckPrime(int num)
    {
        if (num <= 1) return "Composite";
        if (num == 2) return "Prime";

        int i = 2;
        while (i < num)
        {
            if (num % i == 0)
                return "Composite";
            i = i + 1;
        }
        return "Prime";
    }

 
    static void ConvertMoney(double dollar, out double peso, out double yen)
    {
        peso = dollar * 57.17;
        yen = dollar * 146.67;
    }

    static void Main()
    {
        Console.WriteLine("Enter numbers (separated by spaces):");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');

       
        int count = 1;
        foreach (string numStr in numberStrings)
        {
            int num;
            bool isValid = int.TryParse(numStr, out num);
            if (isValid)
            {
                string result = CheckPrime(num);
                Console.WriteLine(count + ". " + num + " " + result);
                count = count + 1;
            }
        }

        Console.WriteLine("\nEnter dollar amounts (separated by spaces)");
        string dollarInput = Console.ReadLine();
        string[] dollarStrings = dollarInput.Split(' ');
        Console.WriteLine("\nCurrency Conversion:");
        Console.WriteLine("Dollar($)    Phil Peso(P)    Jpn Yen(¥)");
        foreach (string dollarStr in dollarStrings)
        {
            double dollar;
            bool isValid = double.TryParse(dollarStr, out dollar);
            if (isValid)
            {
                double peso, yen;
                ConvertMoney(dollar, out peso, out yen);
               
                Console.WriteLine(dollar + "          " + peso + "          " + yen);
            }
        }
    }
}