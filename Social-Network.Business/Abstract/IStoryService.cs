using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstract
{
    public interface IStoryService
    {
        List<Story> GetAll();
        List<Story> GetByCategory(int categoryId);
        void Add(Story story);
        void Update(Story story);
        void Delete(Story story);
        Story GetById(int id);
    }
}
