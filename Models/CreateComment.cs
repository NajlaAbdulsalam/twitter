using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class CreateComment
    {
        /// <summary>
        /// content of the comment is required with max length 140 char
        /// </summary>
        [Required]
        [MaxLength(140)]
        public string content { get; set; }
        /// <summary>
        /// id of the post that commenting on
        /// </summary>
        [Required]
        public int post_id { get; set; }
        /// <summary>
        /// id of the comment that replying to (if the comment was reply)
        /// </summary>
        public int? replied_to { get; set; }
    }
}
