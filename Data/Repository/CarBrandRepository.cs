public class CarBrandRepository : ICarBrands {
    private readonly ApplicationDbContext context;

    public CarBrandRepository(ApplicationDbContext _context) {
        context = _context;
    }

    public IEnumerable<CarBrand> GetAllCarBrands() {
        return context.CarBrands.ToList();
    }
}
