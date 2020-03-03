using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Data
{
    public class Reply
    {
        [Required]
        public string Text { get; set; }

        [Required]
        public Guid UserId { get; set; }
        [Key]
        public int ReplyId { get; set; }

        [Required]
        public Post ReplyComment { get; set; }
    }
}
