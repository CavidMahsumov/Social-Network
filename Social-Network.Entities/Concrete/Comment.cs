using Social_Network.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Entities.Concrete
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Message { get; set; }
        public int  Rating { get; set; }
        public DateTime Date { get; set; }
    }
}
