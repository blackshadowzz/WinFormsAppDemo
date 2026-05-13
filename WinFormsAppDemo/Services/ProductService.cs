using Microsoft.Data.SqlClient;
using WinFormsAppDemo.Data;
using WinFormsAppDemo.Models;

namespace WinFormsAppDemo.Services
{
    public class ProductService
    {
        private readonly SqlConnection conn;
        public ProductService()
        {
            conn = ConnectionHelper.GetConnection();
            conn.Open();
        }

        public List<Product> GetProducts(string? filter = null)
        {
            var products = new List<Product>();
            string sql = "SELECT * FROM TLProducts WHERE ProductName LIKE @filter";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (!string.IsNullOrEmpty(filter))
                    cmd.Parameters.AddWithValue("@filter", $"%{filter}%");
                else
                    cmd.Parameters.AddWithValue("@filter", "%");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product
                        {
                            ProductId = reader.GetInt32(0),
                            CategoryId = reader.GetInt32(1),
                            ProductName = reader.GetString(2),
                            Description = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Price = reader.IsDBNull(4) ? (decimal?)null : reader.GetDecimal(4),
                            StockQty = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                            ImageUrl = reader.IsDBNull(6) ? null : reader.GetString(6),
                            IsActive = reader.GetBoolean(7),
                            CreatedDate = reader.GetDateTime(8),
                            ModifiedDate = reader.GetDateTime(9)
                        };
                        products.Add(product);
                    }
                }
            }
            return products;
        }

        public Product GetProduct(int Id)
        {
            Product product = new();

            string sql = "SELECT * FROM TLProducts WHERE ProductId=@Id";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var pro = new Product
                        {
                            ProductId = reader.GetInt32(0),
                            CategoryId = reader.GetInt32(1),
                            ProductName = reader.GetString(2),
                            Description = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Price = reader.IsDBNull(4) ? (decimal?)null : reader.GetDecimal(4),
                            StockQty = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                            ImageUrl = reader.IsDBNull(6) ? null : reader.GetString(6),
                            IsActive = reader.GetBoolean(7),
                            CreatedDate = reader.GetDateTime(8),
                            ModifiedDate = reader.GetDateTime(9)
                        };
                        product = pro;
                    }
                }
                return product;
            }
        }
        public int CreateProduct(Product product)
        {
            string sql = @"INSERT INTO TLProducts (CategoryId, ProductName, Description, Price, StockQty, ImageUrl, IsActive, CreatedDate, ModifiedDate) 
                            VALUES (@CategoryId, @ProductName, @Description, @Price, @StockQty, @ImageUrl, @IsActive, @CreatedDate, @ModifiedDate); 
                            SELECT SCOPE_IDENTITY();";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Description", (object?)product.Description ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Price", (object?)product.Price ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StockQty", (object?)product.StockQty ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ImageUrl", (object?)product.ImageUrl ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
                cmd.Parameters.AddWithValue("@CreatedDate", product.CreatedDate);
                cmd.Parameters.AddWithValue("@ModifiedDate", product.ModifiedDate);
                object newIdObj = cmd.ExecuteScalar();
                int newId = Convert.ToInt32(newIdObj);
                if (newId == 0)
                    return 0;
                return newId;
            }
        }
    }
}
