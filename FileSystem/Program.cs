using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleTables;
namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarForm carForm = new CarForm();
            RecordServices recordServices = new RecordServices();
            carForm.Form();
            recordServices.KayıtListele();
            Console.ReadKey();

        }
    }
}
