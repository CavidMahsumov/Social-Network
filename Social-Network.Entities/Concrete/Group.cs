using Social_Network.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Entities.Concrete
{
    public class Group:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreaterName { get; set; }


    }
}
