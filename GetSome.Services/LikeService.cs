using GetSome.Data;
using GetSome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Services
{
    public class LikeService
    {
        private readonly Guid _userId;

        public LikeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateLike(LikeCreate model)
        {

            var entity =
                new Like()
                {
                    Liker = model.Liker,
                    LikedPost = model.LikedPost
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity.LikedPost);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
