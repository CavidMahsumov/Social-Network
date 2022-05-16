using Social_Network.Business.Abstract;
using Social_Network.DataAccess.Abstarct;
using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public void Add(Post post)
        {
            _postDal.Add(post);
        }

        public void Delete(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            return _postDal.GetList();
        }

        public List<Post> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
