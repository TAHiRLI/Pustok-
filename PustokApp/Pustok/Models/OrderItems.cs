using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{
    public class OrderItems
    {

        public int Id { get; set; }
        public int BookId { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }

        [Column(TypeName = "money")]
        public decimal ItemCostPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal ItemSalePrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ItemDiscountPercent { get; set; }

        public Orders Order { get; set; }
        public Books Book { get; set; }
    }
}
