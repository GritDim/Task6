using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string startString = Console.ReadLine();

            string[] stringArray = startString.Split();

            
            string joinedString = String.Join("",stringArray);

            joinedString = joinedString.ToLower();
            Console.WriteLine("{0}", joinedString); //выводим изначальную строку без пробелов и все буквы в нижнем регистре
            int sLenght = joinedString.Length;

            string reverseString = "";       

            for (int i = (sLenght-1); i >= 0; i--)
            {
                reverseString += joinedString.Substring(i, 1);
            }

            Console.WriteLine("{0}", reverseString); //выводим реверс строку без пробелов и все буквы в нижнем регистре
            Console.WriteLine();

            int proverka = String.Compare(reverseString,joinedString);

            if (proverka == 0)
            {
                Console.WriteLine("Исходное предложение - палиндром!");
            }
            else
            {
                Console.WriteLine("Предложение не палиндром.");
            }

            Console.WriteLine("Нахмите любую клавишу");
            Console.ReadKey();

        }
    }
}
