using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstract
{
    public interface INotficationService
    {
        List<Notfication> GetAll();
        List<Notfication> GetByCategory(int categoryId);
        void Add(Notfication notf);
        void Update(Notfication notf);
        void Delete(Notfication notf);
        Notfication GetById(int id);
    }
}
