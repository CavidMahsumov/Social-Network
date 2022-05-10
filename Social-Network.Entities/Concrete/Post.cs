﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Entities.Concrete
{
    public class Post
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
        public string VideoUrl { get; set; }
    }
}
