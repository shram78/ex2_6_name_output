using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Вывести имя в прямоугольник из символа, который введет сам пользователь.
Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.*/
namespace ex2_6_name_output
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            string inputSymbol;
            int lettersInName;

            Console.WriteLine("Введи своё имя");
            inputName = Console.ReadLine();
            lettersInName = (inputName.Length) + 2; // определяю колво символов в введенном имени,плюс два перед и после

            Console.WriteLine("Введи символ");
            inputSymbol = Console.ReadLine();
            Console.Clear();
            //отрисовка первой строки
            for (int i = 0; i < lettersInName; i++)
            {
                Console.Write(inputSymbol);
            }
            Console.WriteLine();
            //отрисовка второй строки
            Console.WriteLine(inputSymbol + inputName + inputSymbol);
            //отрисовка третьей строки
            for (int i = 0; i < lettersInName; i++)
            {
                Console.Write(inputSymbol);
            }
            Console.ReadKey();
        }
    }
}