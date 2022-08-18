using Dapper;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cs = "server=(localdb)\\mssqllocaldb;Database=Dap;Trusted_Connection=True;MultipleActiveResultSets=true";
            var con = new SqlConnection(cs);
            con.Open();
            var sql = "Select * from Customers";
            var count = con.Query(sql);
            Utilites utilites = new Utilites();
            List<string> result = utilites.Build<string>("Bursa", "İzmir");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();  
        }
    }
    class Utilites
    {
        public List<T> Build<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
}
