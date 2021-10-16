using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 3
            /* Дана строка S. 
            * Из строки требуется удалить текст, заключенный в фигурные скобки. 
            * В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
            * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала. */
            #endregion
            string str = Console.ReadLine();
            string strResult = "";
            int f = 0;
            for (int i = 0; i < str.Length; )
            {
                if (str[i] == '{')
                {
                    f++;
                    for (int j = i + 1; f != 0;  j++)
                    {
                        if (str[j] == '{')
                        {
                            f++;
                        }
                        if (str[j] == '}')
                        {
                            f--;
                        }
                        i = j + 1;
                    }
                    continue;
                }
                strResult += str[i];
                i++;
            }
            Console.WriteLine(strResult);
            Console.ReadKey();
        }
    }
}