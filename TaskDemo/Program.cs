using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            var tasks = new List<Task>();
            for (int i = 0; i < 15; i++)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 20; j++)
                    {
                        // Atomik olmayan işlem.
                        number++;
                    }
                }));
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 20; j++)
                    {
                        // Atomik olmayan işlem.
                        number--;
                    }
                }));
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine(number);
            Console.ReadKey();
        

        }
    }
}
