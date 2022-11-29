using System.Collections.Generic;

namespace Pustok.Models
{
    public class Authors
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Books> Books { get; set; }
    }
}
