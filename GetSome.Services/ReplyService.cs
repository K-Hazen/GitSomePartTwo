using GetSome.Data;
using GetSome.Models.ReplyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Services
{
    public class ReplyService
    {
        private readonly Guid _userId;

        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    AuthorId = _userId,
                    Text = model.Content,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ReplyListItem> GetReply()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Replies
                        .Where(e => e.AuthorId == _userId)
                        .Select(
                            e =>
                                new ReplyListItem
                                {
                                    ReplyId = e.ReplyId,
                                    Title = e.Text,
                                    AuthorId = _userId,
                                }
                        );
                return query.ToArray();
            }
        }

        public ReplyDetail GetReplyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Replies
                        .Single(e => e.ReplyId == id && e.AuthorId == _userId);
                return
                    new ReplyDetail
                    {
                        ReplyId = entity.ReplyId,
                        Title = entity.Text,
                    };
            }
        }

        public bool UpdateReply(ReplyEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Replies
                        .Single(e => e.ReplyId == model.ReplyId && e.AuthorId == _userId);

                entity.Text = model.Content;
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteReply(int replyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Replies.Single(e => e.ReplyId == replyId && e.AuthorId == _userId);

                ctx.Replies.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
