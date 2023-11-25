
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CarModel : PageModel {
	private readonly ILogger<CarModel> logger;
	private readonly ApplicationDbContext context;
	private readonly ICars cars;

	public CarModel(ILogger<CarModel> _logger, ApplicationDbContext _context, ICars _cars) {
		logger = _logger;
		context = _context;
		cars = _cars;
	}


	public void OnGet() {
		ViewData["Title"] = "Каталог автомобилей";

		// Получаем все машины
		ViewData["Cars"] = cars.GetAllCars();
	}
}
