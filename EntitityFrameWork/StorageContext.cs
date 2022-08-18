using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitityFrameWork
{
    public class StorageContext:DbContext
    {
        public DbSet<Products> Product { get; set; }
    }
}
