using System;
namespace ex2_6_name_output
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            char inputSymbol;
            int lettersInName;
            Console.WriteLine("Введи своё имя");
            inputName = Console.ReadLine();
            lettersInName = (inputName.Length) + 2;
            Console.WriteLine("Введи символ");
            inputSymbol = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                if (i == 0 || i == 2)
                    for (int j = 0; j < lettersInName; j++)
                    {
                        Console.Write(inputSymbol);
                    }
                else
                {
                    Console.WriteLine("\n" + inputSymbol + inputName + inputSymbol);
                }
            }
            Console.ReadKey();// переделал
        }
    }
}