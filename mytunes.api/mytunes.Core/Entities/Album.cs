using System;
using System.Collections.Generic;

namespace mytunes.Core.Entities
{
    public class Album : BaseEntity
    {

        public Album()
        {
            Songs = new List<Song>();
        }

        public ICollection<Song> Songs { get; set; }
        
        public string Name { get; set; }
        
        public string ArtistName { get; set; }
        
        public double Total { get; set; }
        
        public string Gender {get; set;}
        
        public DateTime ReleaseDate { get; set; }
        
        public string Description { get; set; }
        
        public string LinkImage { get; set; }








    }
}