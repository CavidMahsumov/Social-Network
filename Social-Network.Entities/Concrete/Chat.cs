using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Entities.Concrete
{
    public  class Chat
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int SenderId { get; set; }



    }
}
