using ADONetProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetProject.DataAccess
{
    public class ProductDal
    {

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETradeSample;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionStateControl();

            SqlCommand command = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product   //reader dan gelen veri obje olduğundan doğru notasyona çevirmemiz gerekli.
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    ProductName = reader["ProductName"].ToString(),
                    ProductUnitPrice = Convert.ToDecimal(reader["ProductUnitPrice"]),
                    ProductStockAmount = Convert.ToInt32(reader["ProductStockAmount"])
                };

                products.Add(product);


            }
            reader.Close();
            _connection.Close();

            return products;

        }

        

        public void Add(Product product)
        {

            ConnectionStateControl();

            SqlCommand command = new SqlCommand("insert into Products(ProductName,ProductUnitPrice,ProductStockAmount) values(@name,@unitPrice,@stockAmount)", _connection); //sql injection sıkıntısı yaşanmaması için parametrelerle veriyoruz.
            command.Parameters.AddWithValue("@name", product.ProductName);
            command.Parameters.AddWithValue("@unitPrice", product.ProductUnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.ProductStockAmount);
            command.ExecuteNonQuery(); //etkilenen kayıt sayısıint olarak döner.Kontrol amaçlı kullanılabilir.

            _connection.Close();


        }

        public void Update(Product product)
        {
            ConnectionStateControl();

            SqlCommand command = new SqlCommand("update Products set ProductName=@name,ProductUnitPrice=@unitPrice,ProductStockAmount=@stockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.ProductName);
            command.Parameters.AddWithValue("@unitPrice", product.ProductUnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.ProductStockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        

        private void ConnectionStateControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
        }


    }
}
