using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class User
    {
        public User()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
        public int id { get; set; }
        [Required]
        public string user_name { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        [Required]
        public DateTime updated_at { get; set; }
    }
}
