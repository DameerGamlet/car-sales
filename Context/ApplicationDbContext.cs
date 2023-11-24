using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Здесь вы можете добавить DbSet для ваших моделей данных

    public DbSet<Car> Cars { get; set; }
    public DbSet<Account> Accounts { get; set; }

    public DbSet<CarBrand> CarBrands { get; set; }
    public DbSet<CarType> CarTypes { get; set; }
}


public interface IDatabaseInitializer
{
}