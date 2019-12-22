using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab21_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Write("Введите строку: ");
            s = ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Write(s[i]);
                }
            }
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Write(s[i]);
                }
            }
        }
    }
}
