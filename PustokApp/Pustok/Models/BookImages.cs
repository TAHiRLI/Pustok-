using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class BookImages
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        public bool? PosterStatus { get; set; }
        public int BooksId { get; set; }    
        public Books Books { get; set; }
       
    }
}
