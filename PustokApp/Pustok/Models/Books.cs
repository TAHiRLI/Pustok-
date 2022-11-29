using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{
    public class Books
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public bool StockStatus { get; set; }

        [Column(TypeName ="money")]
        public decimal CostPrice { get; set; }


        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPercent { get; set; }




        public Genres Genre { get; set; }
        public Authors Author { get; set; }


        public List<Reviews> Reviews { get; set; }
        public List<OrderItems> OrderItems { get; set; }
        public List<BookImages> BookImages { get; set; }
    }
}
