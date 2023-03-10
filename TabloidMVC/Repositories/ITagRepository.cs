using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface ITagRepository
    {
        List<Tag> GetAllTags();
        Tag GetTagById(int id);
        void UpdateTag(Tag tag);
        void AddTag(Tag tag);
        void DeleteTag(int id);
    }
}
