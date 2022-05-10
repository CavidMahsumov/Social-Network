using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Entities.Concrete
{
    public class Notfication
    {
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
