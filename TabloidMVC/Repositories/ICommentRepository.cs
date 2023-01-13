using System.Collections.Generic;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface ICommentRepository
    {
         List<Comment> GetAllPostedComments();
        // List<Comment> GetCommentsByPostId(int id, int postId);
         void AddComment(Comment comment);
         //Comment GetCommentsById(int id);
        
    }
}
