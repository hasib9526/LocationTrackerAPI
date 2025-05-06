﻿namespace LocationTrackerAPI.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string? Address { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
