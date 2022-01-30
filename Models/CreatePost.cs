using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Test.Models
{
    public class CreatePost
    {
        /// <summary>
        /// content of the post is required with max length 140 char
        /// </summary>
        [Required]
        [MaxLength(140)]
        public string content { get; set; }
        [Required]
        public int user_id { get; set; }
    }
}
