using Social_Network.Core.DataAccess.EntityFramework;
using Social_Network.DataAccess.Abstarct;
using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.DataAccess.Concrete
{
    public class EfNotficationDal:EfEntityRepositoryBase<Notfication,SocialNetworkDbContext>,INotficationDal
    {
    }
}
