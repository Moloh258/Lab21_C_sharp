using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab21_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char[] glas = { 'А', 'а', 'Е', 'е', 'Ё', 'ё', 'И', 'и', 'О', 'о', 'У', 'у', 'ы', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' };
            Write("Введите строку: ");
            s = ReadLine();
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < glas.Length; j++)
                {
                    if (s[i] == glas[j])
                    {
                        k++;
                    }
                }
            }

            Write(k);
        }
    }
}
