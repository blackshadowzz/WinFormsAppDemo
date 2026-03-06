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
        public List<Category> GetCategories()
        {
            var categories = new List<Category>();

            string query = @"Select * from TbCategories";
            using (SqlCommand cmd = new SqlCommand(query, conn))
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
        public int CreateCategory(Category category)
        {
            string sql = "INSERT INTO TbCategories (CategoryName, Description, IsActive) VALUES (@CategoryName, @Description, @IsActive); " +
                         "SELECT SCOPE_IDENTITY();";

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

            string query = @"Select * from TbCategories";
            using (SqlCommand cmd = new SqlCommand(query, conn))
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
}
