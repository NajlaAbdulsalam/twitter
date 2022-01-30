using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Test.Models
{
    public class CreateComment
    {
        [Required]
        [MaxLength(140)]
        public string content { get; set; }
        [Required]
        public int post_id { get; set; }
        public int? replied_to { get; set; }
    }
}
