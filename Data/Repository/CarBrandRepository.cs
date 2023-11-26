public class CarBrandRepository : ICarBrands {
    private readonly ApplicationDbContext context;

    public CarBrandRepository(ApplicationDbContext _context) {
        context = _context;
    }

    public IEnumerable<BrandCar> GetAllCarBrands() {
        return context.BrandsСar.ToList();
    }
}
