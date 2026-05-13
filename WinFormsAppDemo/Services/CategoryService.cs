using Microsoft.Data.SqlClient;
using WinFormsAppDemo.Data;
using WinFormsAppDemo.Models;

namespace WinFormsAppDemo.Services
{
    public class CategoryService
    {
        private readonly SqlConnection conn;
        public CategoryService()
        {
            conn = ConnectionHelper.GetConnection();
            conn.Open();
        }
        public List<Category> GetCategories(string? search = "")
        {
            var categories = new List<Category>();

            string query = @"Select * from TbCategories WHERE CategoryName LIKE @search";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@search", search + "%");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            Id = reader.GetInt32(0),
                            CategoryName = reader.GetString(1),
                            Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            IsActive = reader.GetBoolean(3),

                        });
                    }
                }
                return categories;
            }

        }
        public int CreateCategory(Category category)
        {
            string sql = @"INSERT INTO TbCategories (CategoryName, Description, IsActive) 
                            VALUES (@CategoryName, @Description, @IsActive); 
                            SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                cmd.Parameters.AddWithValue("@Description", category.Description);
                cmd.Parameters.AddWithValue("@IsActive", category.IsActive);

                object newIdObj = cmd.ExecuteScalar();
                int newId = Convert.ToInt32(newIdObj);
                if (newId == 0)
                    return 0;
                return newId;
            }
        }
        public Category GetCategory(int id)
        {
            var category = new Category();

            string query = @"Select * from TbCategories WHERE Id=@Id";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        category.Id = reader.GetInt32(0);
                        category.CategoryName = reader.GetString(1);
                        category.Description = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        category.IsActive = reader.GetBoolean(3);
                    }
                }
                return category;
            }
        }
        public bool UpdateCategory(Category category)
        {
            string sql = @"UPDATE TbCategories SET CategoryName = @CategoryName, 
                Description = @Description, IsActive = @IsActive WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", category.Id);
                cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                cmd.Parameters.AddWithValue("@Description", category.Description);
                cmd.Parameters.AddWithValue("@IsActive", category.IsActive);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool DeleteCategory(int Id)
        {
            string sql = @"DELETE FROM TbCategories WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
