using System;
using System.Collections.Generic;

namespace Pustok.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }
}
