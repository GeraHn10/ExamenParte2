namespace mytunes.Infrastructure
{
    public class MyTunesDbContext
    {
        public MyTunesDbContext(DbContextOptions options) :
            base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Basket> Baskets { get; set; }

        public DbSet<BasketItem> BasketItems { get; set; }
    }
}