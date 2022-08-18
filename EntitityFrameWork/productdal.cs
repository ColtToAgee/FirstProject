using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitityFrameWork
{
    public class productdal
    {
        public List<Products> GetAll()
        {
            using (StorageContext context =new StorageContext())
            {
                return context.Product.ToList();
            }
        }
        public void Add(Products product)
        {
            using (StorageContext context =new StorageContext())
            {
                if (product.product_category == CategoryEnum.category.Fruit.ToString())
                {
                    context.Product.Add(product);
                }
                context.SaveChanges();
            }

        }
        public void Update(Products product)
        {
            using (StorageContext context=new StorageContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Products product)
        {
            using (StorageContext context = new StorageContext())
            {
                var entity=context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
