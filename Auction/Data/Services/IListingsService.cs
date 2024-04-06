using Auctions.Models;

namespace Auction.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
    }
}
