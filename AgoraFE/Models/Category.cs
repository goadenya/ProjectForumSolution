﻿using System.Collections.Generic;

namespace AgoraFE.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Post> posts { get; set; }
    }
}
