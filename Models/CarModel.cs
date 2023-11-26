
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CarModel : PageModel {
	private readonly ILogger<CarModel> log;
	private readonly ApplicationDbContext context;
	private readonly ICars cars;

	public CarModel(ILogger<CarModel> _logger, ApplicationDbContext _context, ICars _cars) {
		log = _logger;
		context = _context;
		cars = _cars;
	}


	public IActionResult OnGet() {
		log.LogInformation("Получение списка автомобилей");
		ViewData["Title"] = "Каталог автомобилей";

		// Получаем все машины
		ViewData["Cars"] = cars.GetAllCars();

		return Page();
	}

	public IActionResult OnGetByBrand(int brandId) {
		log.LogInformation("Получение списка автомобилей для бренда: {brandId}", brandId);
		ViewData["Title"] = $"Машины марки {brandId}";

		// Получаем машины по бренду
		ViewData["Cars"] = cars.GetAllCarsByBrand(brandId);

		return Page();
	}
}
