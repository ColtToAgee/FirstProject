using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<Kisiler> list = new List<Kisiler>
            {
                new Kisiler {Name="Mehmet",Surname="Ozgonul",Old=19},
                new Kisiler { Name = "Cagatay", Surname = "Ozgonul", Old=21 }
            };
            int count = 0;
            foreach(var item in list)
            {
                Console.WriteLine(item.Name+" "+item.Surname+"= "+item.Old);
                count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }

    }
    class Kisiler
    {
        public Kisiler(string name,string surname,int old)
        {
            _name = name;
            _surname = surname; 
            _old = old;

        }
        private string _name { get; set; }
        private string _surname { get; set; }
        private int _old { get; set; }    
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Old { get; set; }
        public Kisiler()
        {

        }
    }
}
