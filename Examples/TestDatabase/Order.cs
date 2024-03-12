using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDatabase
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

        // Foreign key for Customer
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }  // Navigation property

        // Foreign key for Product
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } // Navigation property
    }
}
