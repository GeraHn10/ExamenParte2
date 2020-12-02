using mytunes.Core.Entities;

namespace mytunes.Core.Interfaces
{
    public interface IAlbumService
    {

        ServiceResult<Album> AddSong(Song song,int idAlbum);
        
        ServiceResult<Album> FindAlbums(int idAlbum);

    }
}