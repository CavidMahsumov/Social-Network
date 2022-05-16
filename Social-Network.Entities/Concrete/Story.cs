using Social_Network.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Entities.Concrete
{
    public class Story:IEntity
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }

    }
}
