﻿namespace AuthSystem.Models.Domain
{
    public class Tag
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public ICollection<BlogPost> BlogpPosts { get; set; }
    }
}
