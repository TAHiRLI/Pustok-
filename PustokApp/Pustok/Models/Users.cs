using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Users
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Fullname { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string PasswordHash { get; set; }
        public List<Reviews> Reviews { get; set; }

    }
}
