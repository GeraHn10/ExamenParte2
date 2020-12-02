namespace mytunes.Core.Entities
{
    public class Song
    {
        public string Name { get; set; }
        
        public string ArtistName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int Popularity { get; set; }

        public int AlbumId { get; set; }

        public Album Album { get; set; }
    }
}