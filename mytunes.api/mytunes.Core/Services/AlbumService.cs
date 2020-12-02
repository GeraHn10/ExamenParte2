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
            throw new System.NotImplementedException();
        }

        public ServiceResult<Album> FindAlbums(int idAlbum)
        {
            var album = _albumRepository.get
            return album == null
                ? ServiceResult<Basket>.NotFoundResult($"No se encontró basket para el usuario {userId}")
                : ServiceResult<Basket>.SuccessResult(basket);
        }
    }
}