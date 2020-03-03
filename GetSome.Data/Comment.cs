using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Data
{
    public class Comment
    {

        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        public virtual Post Post { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }

        //is there a user class I am supposed to be using?


        //Foriegn Key
        //[ForeignKey(nameof(Reply))]
        //public int? ReplyId {get; set;}
        //public virtual Reply Reply {get; set:}


        //Post CommentPost


    }
}
