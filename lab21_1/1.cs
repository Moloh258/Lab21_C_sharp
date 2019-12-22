using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab21_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s;
            Write("Введите строку: ");
            s = ReadLine().ToCharArray();
            int k = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == ' ') && (s[i - 1] != ' '))
                {
                    k++;
                }
            }
            Write(k);
        }
    }
}
