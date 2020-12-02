using System;

namespace mytunes.api.Models
{
    public class Album
    {
        public int id { get; set; }
        
        public string Name { get; set; }
        
        public string ArtistName { get; set; }
        
        public double Total { get; set; }
        
        public string Gender {get; set;}
        
        public DateTime ReleaseDate { get; set; }
        
        public string Description { get; set; }
        
        public string LinkImage { get; set; }

        public int TotalMinutes { get; set; }
    }
}