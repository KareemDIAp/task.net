using System.ComponentModel.DataAnnotations;

namespace Frist_app.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public decimal price { get; set; }
        [Required]
        public int quantity { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updateAt { get; set; } = DateTime.Now;

        //public async Task UpdateProduct(Product product)
        //{
        //    product.UpdatedAt = DateTime.Now;

        //    _context.Products.Update(product);

        //    await _context.SaveChangesAsync();
        //}

    }
}

