namespace campgrounds;
using Microsoft.EntityFrameworkCore;
using campgrounds.Models;

public class CreekRiverDbContext : DbContext
{

    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Campsite> Campsites { get; set; }
    public DbSet<CampsiteType> CampsiteTypes { get; set; }


    public CreekRiverDbContext(DbContextOptions<CreekRiverDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // seed data with campsite types
        modelBuilder.Entity<CampsiteType>().HasData(new CampsiteType[]
        {
            new CampsiteType {Id = 1, CampsiteTypeName = "Tent", FeePerNight = 15.99M, MaxReservationDays = 7},
            new CampsiteType {Id = 2, CampsiteTypeName = "RV", FeePerNight = 26.50M, MaxReservationDays = 14},
            new CampsiteType {Id = 3, CampsiteTypeName = "Primitive", FeePerNight = 10.00M, MaxReservationDays = 3},
            new CampsiteType {Id = 4, CampsiteTypeName = "Hammock", FeePerNight = 12M, MaxReservationDays = 7}
        });

        modelBuilder.Entity<Campsite>().HasData(new Campsite[]
        {
            new Campsite {Id = 1, CampsiteTypeId = 1, Nickname = "Barred Owl", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
            new Campsite {Id = 2, CampsiteTypeId = 2, Nickname = "Mushroom Camp", ImageUrl="https://www.discovercrystalriverfl.com/imager/s3_us-east-1_amazonaws_com/crystalriver-2019/images/attractions/RV-Camping-in-Rock-Crusher-RV-Resort1-1_bc0d2157d501d4729a3d5631708a6b2e.jpg"},
            new Campsite {Id = 3, CampsiteTypeId = 3, Nickname = "Hot Spot", ImageUrl="https://dec.ny.gov/sites/default/files/styles/hero_background/public/2023-11/PrimitiveASD1.jpg?h=2f15d14c&itok=HbFnKfKL"},
            new Campsite {Id = 4, CampsiteTypeId = 4, Nickname = "With Shower", ImageUrl="https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-10-TIPS-FOR-HAMMOCK-CAMPING-LIKE-A-PRO_900x.jpg?v=1678808670"},
            new Campsite {Id = 5, CampsiteTypeId = 4, Nickname = "Dead Body... Once", ImageUrl="https://www.rei.com/dam/content_team_042618_0128_hammock_setup.jpg"},
            new Campsite {Id = 6, CampsiteTypeId = 1, Nickname = "Weed Spot", ImageUrl="https://images.pexels.com/photos/1687845/pexels-photo-1687845.jpeg?auto=compress&cs=tinysrgb&w=600"}
        });

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
            new UserProfile {Id = 1, FirstName = "John", LastName = "Doe", Email = "getbaked@gmail.com" }
        });

        modelBuilder.Entity<Reservation>().HasData(new Reservation[]
{
            new Reservation {Id = 1, CampsiteId = 1, UserProfileId = 1, CheckinDate = new DateTime(2024, 8, 15), CheckoutDate = new DateTime(2024, 8, 20) },
            new Reservation {Id = 2, CampsiteId = 3, UserProfileId = 1, CheckinDate = new DateTime(2025, 8, 15), CheckoutDate = new DateTime(2025, 8, 20) }
});

    }
}