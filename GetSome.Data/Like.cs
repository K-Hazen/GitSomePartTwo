using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Data
{
    public class Like
    {
        [ForeignKey("Post")]
        public Post LikedPost { get; set; }
        public User Liker { get; set; }
    }
}
