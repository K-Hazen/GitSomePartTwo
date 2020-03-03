using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Models.ReplyModels
{
    public class ReplyListItem
    {
        public int ReplyId { get; set; }
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
    }
}
