using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Models.ReplyModels
{
    public class ReplyListItem
    {
        public Guid UserId { get; set; }
        public int ReplyId { get; set; }
        public string Title { get; set; }
    }
}
