using System.Collections.Generic;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface ICommentRepository
    {
         List<Comment> GetAllPostedComments();
         List<Comment> GetCommentsByPostId(int postId);
         void AddComment(Comment comment);
    }
}
