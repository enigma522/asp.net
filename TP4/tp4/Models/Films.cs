﻿namespace tp4.Models
{
    public class Films
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public IEnumerable<Role>? Roles { get; set; }

        
    }
}
