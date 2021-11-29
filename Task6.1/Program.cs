using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите предложение");
            string startString = Console.ReadLine();

            string[] stringArray = startString.Split();

            foreach (string s in stringArray)
            {
                Console.WriteLine("{0}", s);
            }

            int maxLenght = 0;
            string maxWord = "";

            foreach (string s in stringArray)
            {
                if (s.Length > maxLenght)
                {
                    maxLenght = s.Length;
                    maxWord = s;
                }
            }

            


            Console.WriteLine("Самое динное слово в предложении - {0} из {1} букв", maxWord, maxLenght);

            Console.WriteLine("Нахмите любую клавишу");
            Console.ReadKey();

        }
    }
}
