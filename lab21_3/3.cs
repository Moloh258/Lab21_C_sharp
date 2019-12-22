using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab21_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s;
            char c;
            Write("Введите строку: ");
            s = ReadLine().ToArray();
            c = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    s[i] = '.';
                }
            }

            Write(s);
        }
    }
}
