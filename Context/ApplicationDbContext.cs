using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Account> Accounts { get; set; }

    public DbSet<BrandCar> BrandsСar { get; set; }
    public DbSet<TypeCar> TypesCar { get; set; }

    /*     protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Account>()
                .HasMany(a => a.FavoriteCars)
                .WithOne(o => o.Account)
                .HasForeignKey(o => o.Id);

            base.OnModelCreating(modelBuilder);
        } */
}

