using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Test.Models
{
    public class CreatePost
    {
     
        public string content { get; set; }
 
        public int user_id { get; set; }
    }
}
