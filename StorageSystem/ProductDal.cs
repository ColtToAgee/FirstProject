using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem
{
    public class ProductDal
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=test;integrated security=true");
    public DataTable GetAll()
        {
            connectionControl();
            SqlCommand command = new SqlCommand("Select * From Products",connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable=new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
    public void Add_Product(Product product)
        {
            connectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@product_name,@product_category,@product_price,@product_number)", connection);
            command.Parameters.AddWithValue("@product_name", product.product_name);
            command.Parameters.AddWithValue("@product_category", product.product_category);
            command.Parameters.AddWithValue("@product_price", product.product_price);
            command.Parameters.AddWithValue("@product_number", product.product_number);
            command.ExecuteNonQuery();
            connection.Close();
        }
    public void connectionControl()
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
        }
    public void Update_Product(Product product)
        {
            connectionControl();
            SqlCommand command = new SqlCommand("Update Products set product_name=@product_name,product_category=@product_category,product_price=@product_price,product_number=@product_number where Id=@id", connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@product_name", product.product_name);
            command.Parameters.AddWithValue("@product_category", product.product_category);
            command.Parameters.AddWithValue("@product_price", product.product_price);
            command.Parameters.AddWithValue("@product_number", product.product_number);
            command.ExecuteNonQuery();
            connection.Close();
        }
    public void Delete_Product(Product product)
        {
            connectionControl();
            SqlCommand command = new SqlCommand("Delete Products where Id=@id ",connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
