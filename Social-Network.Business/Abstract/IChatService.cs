using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstract
{
    public interface IChatService
    {
        List<Chat> GetAll();
        List<Chat> GetByCategory(int categoryId);
        void Add(Chat chat);
        void Update(Chat chat);
        void Delete(Chat chat);
        Chat GetById(int id);
    }
}
