using Microsoft.EntityFrameworkCore;

public class CarRepository : ICars {
	private readonly ApplicationDbContext context;

	public CarRepository(ApplicationDbContext _context) {
		context = _context;
	}

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

	public IEnumerable<Car> GetAllCars() => context.Cars.Include(c => c.CarBrand).ToList();
	public IEnumerable<Car> GetAllCarsByBrand(string brand) =>
		context.Cars.Include(c => c.CarBrand)
			.Where(c => c.CarBrand.Name.Equals(brand, StringComparison.OrdinalIgnoreCase))
			.ToList();

	public IEnumerable<Car> GetLastCars(int n) => context.Cars.Include(c => c.CarBrand)
		.OrderByDescending(c => c.Id)
		.Take(n)
		.ToList();

	public IEnumerable<Car> GetAllCarsByBrand() => context.Cars.Include(c => c.CarBrand);
	public IEnumerable<Car> GetAllCarsByType() => context.Cars.Include(c => c.CarType);

	public Car GetCarById(int Id) =>
		context.Cars.Include(c => c.CarBrand)
			.FirstOrDefault(c => c.Id == Id) ??
			throw new NotCarFoundException("Car not found by id:" + Id);

	public void UpdateCar(Car car) {
		context.Cars.Update(car);
		context.SaveChanges();
	}
}
