using GetSome.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Models
{
    public class LikeDetail
    {
        public int PostId { get; set; }
        public Guid AuthorId { get; set; }
    }
}
