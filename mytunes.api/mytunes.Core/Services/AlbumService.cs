using mytunes.Core.Entities;
using mytunes.Core.Interfaces;

namespace mytunes.Core.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IRepository<Song> _songRepository;
        private readonly IRepository<Album> _albumRepository;
        
        public ServiceResult<Album> AddSong(Song song, int idAlbum)
        {
            
        }
    }
}