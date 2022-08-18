using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new ConsoleTable("one", "two", "three");
            table.AddRow(1, 2, 3);
            table.Write();
            Console.WriteLine();
            Console.ReadKey();

        }
       
    }
}

