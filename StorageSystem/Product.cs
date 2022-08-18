using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem
{
    public class Product
    {
        public int Id { get; set; }
        public string product_name { get; set; }
        public string product_category { get; set; }
        public double product_price { get; set; }
        public int product_number { get; set; }
    }
}
