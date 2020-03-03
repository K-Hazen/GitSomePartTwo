using GetSome.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Models
{
    public class LikeEdit
    {
        public int LikeId { get; set; }
        public Post LikedPost { get; set; }
        public User Liker { get; set; }
    }
}
