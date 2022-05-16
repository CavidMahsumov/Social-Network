using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        List<Comment> GetByCategory(int categoryId);
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        Comment GetById(int id);
    }
}
