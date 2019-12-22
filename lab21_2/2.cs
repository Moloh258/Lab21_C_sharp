using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab21_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Write("Введите строку: ");
            s = ReadLine();
            var word = from min in s.Split(' ')
                       orderby min.Length
                       select min;
            string minword = word.First();
            Write(minword.Length);
        }
    }
}
