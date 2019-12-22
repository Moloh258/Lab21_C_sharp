using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace lab21_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullPath;
            Write("Введите полный путь к файлу: ");
            FullPath = ReadLine();
            Write(Path.GetFileNameWithoutExtension(FullPath));
        }
    }
}
