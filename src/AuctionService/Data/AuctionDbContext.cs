using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data
{
    public class AuctionDbContext : DbContext
    {
        #region Properties
        public DbSet<Auction> Auctions { get; set; }
        #endregion

        #region Constructor
        public AuctionDbContext(DbContextOptions options) : base(options)
        {
        }
        #endregion
    }
}
