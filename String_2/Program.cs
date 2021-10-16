using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 2
            /* Ввести с клавиатуры предложение. 
             * Предложение представляет собой слова, разделенные пробелом.
             * Знаки препинания не используются. 
             * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
             */
            #endregion
            string[] arrStr = Console.ReadLine().Split();
            string t = string.Concat(arrStr).ToLower();
            string t2 = "";
            for (int i = (t.Length - 1); i >= 0; i--)
            {
                t2 += t[i];
            }
            Console.WriteLine((t == t2) ? "Палиндром" : "Не палиндром");
            Console.ReadKey();
        }
    }
}
