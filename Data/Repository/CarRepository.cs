using Microsoft.EntityFrameworkCore;

public class CarRepository : ICars {
  private readonly ApplicationDbContext context;

  public CarRepository(ApplicationDbContext _context) { context = _context; }

  public void AddCar(Car car) {
    context.Cars.Add(car);
    context.SaveChanges();
  }

  public void DeleteCar(int id) {
    var car = context.Cars.FirstOrDefault(car => car.Id == id);
    if (car != null) {
      context.Cars.Remove(car);
      context.SaveChanges();
    }
  }

  public IEnumerable<Car> GetAllCars() =>
      context.Cars.Include(c => c.BrandCar).Include(c => c.TypeCar).ToList();

  public IEnumerable<Car>
  GetAllCarsByBrand(int brandId) => context.Cars.Include(c => c.BrandCar)
                                        .Include(c => c.TypeCar)
                                        .Where(c => c.BrandCar.Id == brandId)
                                        .ToList();
  public IEnumerable<Car>
  GetAllCarsByType(int typeId) => context.Cars.Include(c => c.BrandCar)
                                      .Include(c => c.TypeCar)
                                      .Where(c => c.TypeCar.Id == typeId)
                                      .ToList();

  public IEnumerable<Car>
  GetLastCars(int n) => context.Cars.Include(c => c.BrandCar)
                            .Include(c => c.TypeCar)
                            .OrderByDescending(c => c.Id)
                            .Take(n)
                            .ToList();

  public Car GetCarById(int Id) =>
      context.Cars.Include(c => c.BrandCar)
          .Include(c => c.TypeCar)
          .FirstOrDefault(c => c.Id == Id) ??
      throw new NotCarFoundException("Car not found by id:" + Id);

  public void UpdateCar(Car car) {
    context.Cars.Update(car);
    context.SaveChanges();
  }
}