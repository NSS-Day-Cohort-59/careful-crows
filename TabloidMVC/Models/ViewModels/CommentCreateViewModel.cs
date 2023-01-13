using System.Collections.Generic;

namespace TabloidMVC.Models.ViewModels
{
    public class CommentCreateViewModel
    {
        public Post Post { get; set; }
        public List<Comment> CommentList { get; set;}
    }
}
