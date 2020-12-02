using mytunes.Core.Entities;

namespace mytunes.Core.Interfaces
{
    public interface IAlbumRepository
    {
        Album GetAlbumforBuyer(int albumId);
    }
}