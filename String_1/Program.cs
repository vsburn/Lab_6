using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1
            //1. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.
            #endregion
            string s = Console.ReadLine();
            string[] arrayString = s.Split();
            string strMax = arrayString[0];
            foreach (string a in arrayString)
            {
                strMax = (strMax.Length < a.Length) ? a : strMax;
            }
            Console.WriteLine(strMax);
            Console.ReadKey();
        }
    }
}
