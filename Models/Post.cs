using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Post
    {
        public Post()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }

        public int id { get; set; }
        [Required]
        [MaxLength(140)]
        public string content { get; set; }
        [Required]
        public DateTime? deleted_at { get; set; }
        public DateTime created_at { get; set; }
        [Required]
        public DateTime updated_at { get; set; }
        [Required]
        public User user_id { get; set; }
    }
}
