using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cs = "server=(localdb)\\mssqllocaldb;Database=Dap;Trusted_Connection=True;MultipleActiveResultSets=true";
            var con= new SqlConnection(cs);
            con.Open();
            //con.Execute("Insert into Customers(name,surname) values(@Name,@Surname",new Customer { Name="Cagatay",Surname="Ozgonul"});
            List<Customer> customerList = con.Query<Customer>("Select * from Customers").ToList();
            Console.ReadKey();
        }
    }
}
