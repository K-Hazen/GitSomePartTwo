using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Models.ReplyModels
{
    public class ReplyCreate
    {
        [Required]
        public string Title { get; set; }

        [MaxLength(9999)]
        public string Content { get; set; }
    }
}
