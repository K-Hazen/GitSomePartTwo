using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Data
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        public virtual Post Post { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
    }
}
