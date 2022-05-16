using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll();
        List<Post> GetByCategory(int categoryId);
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);
        Post GetById(int id);
    }
}
