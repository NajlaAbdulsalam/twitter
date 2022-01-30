using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Comment
    {
        public Comment()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
        public int id { get; set; }
        [Required]
        [MaxLength(140)]
        public string content { get; set; }
        public System.Nullable<DateTime> deleted_at { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        [Required]
        public DateTime updated_at { get; set; }
        [Required]
        public Post post_id { get; set; }
        public Comment replied_to { get; set; }
    }

}
