using Social_Network.Core.DataAccess;
using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.DataAccess.Abstarct
{
    public  interface IPostDal:IEntityRepository<Post>
    {
    }
}
