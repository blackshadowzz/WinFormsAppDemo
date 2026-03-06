using Microsoft.Data.SqlClient;

namespace WinFormsAppDemo.Data
{

    public static class ConnectionHelper
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                                    Initial Catalog=DemoDB;
                                                    Trusted_Connection=True;
                                                    MultipleActiveResultSets=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static void ShowError(Exception ex)
        {
            MessageBox.Show("Wrong: " + ex.Message, "System wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
