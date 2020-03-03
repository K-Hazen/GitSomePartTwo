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
        public int PostId { get; set; }
        public Guid AuthorId { get; set; }
    }
}
