using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name="India",
                    ShortName="IND"
                },
                new Country
                {
                    Id = 2,
                    Name = "England",
                    ShortName = "ENG"
                },
                 new Country
                 {
                     Id = 3,
                     Name = "Dubai",
                     ShortName = "DXB"
                 }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name="Marriot",
                    Address="Kochin",
                    CountryId=1,
                    Rating=5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Jungle Beats",
                    Address = "Vayanad",
                    CountryId = 1,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "LuLu",
                    Address = "Dubai",
                    CountryId = 3,
                    Rating = 5
                }
                );
            ;
        }
    }
}
