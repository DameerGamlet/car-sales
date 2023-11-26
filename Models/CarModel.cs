
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

	// public IActionResult OnGet() {
	// 	log.LogInformation("Получение списка автомобилей");
	// 	ViewData["Title"] = "Каталог автомобилей";

	// 	// Получаем все машины
	// 	ViewData["Cars"] = cars.GetAllCars();

	// 	return Page();
	// }

	public IActionResult OnGet(string brandId) {
		if (!int.TryParse(brandId, out int brandIdInt)) {
			// Обработка неверного формата brandId, например, возврат ошибки 400 Bad Request.
			return BadRequest("Invalid brandId format.");
		}

		log.LogInformation("Получение списка автомобилей для бренда: {brandId}", brandIdInt);
		ViewData["Title"] = $"Машины марки {brandIdInt}";

		// Получаем машины по бренду
		ViewData["Cars"] = cars.GetAllCarsByBrand(brandIdInt);

		return Page();
	}

}
