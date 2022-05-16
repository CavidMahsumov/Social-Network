using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstract
{
    public interface IGroupService
    {
        List<Group> GetAll();
        List<Group> GetByCategory(int categoryId);
        void Add(Group group);
        void Update(Group group);
        void Delete(Group group);
        Group GetById(int id);
    }
}
