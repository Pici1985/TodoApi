﻿namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; } 
        public string? Secret { get; set; }
        public string? AnotherSecret { get; set; }

    }

    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
    
}

// Add nuget package is the next step
