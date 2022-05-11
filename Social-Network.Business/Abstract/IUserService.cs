using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstract
{
    public  interface IUserService
    {
        List<User> GetAll();
        List<User> GetByCategory(int categoryId);
        void Add(User product);
        void Update(User product);
        void Delete(User product);
        User GetById(int id);
    }
}
