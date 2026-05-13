namespace WinFormsAppDemo.Models
{
    public class Product
    {
        public int ProductId { get; set; }              // Primary Key
        public int CategoryId { get; set; }             // Foreign Key to Category
        public string ProductName { get; set; } = string.Empty;        // Required
        public string? Description { get; set; }        // Optional
        public decimal? Price { get; set; }             // Optional
        public int? StockQty { get; set; }              // Optional
        public string? ImageUrl { get; set; }           // Optional
        public bool IsActive { get; set; } = true;      // Default true
        public DateTime CreatedDate { get; set; }       // Default GETDATE()
        public DateTime ModifiedDate { get; set; }      // Default GETDATE()
    }

}
