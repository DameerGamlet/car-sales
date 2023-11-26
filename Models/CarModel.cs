
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
		ViewData["Cars"] = cars.GetAllCars();

		return Page();
	}

	public IActionResult OnGetBrand([FromQuery] string brandId) {
		if (!int.TryParse(brandId, out int brandIdInt)) {
			// Обработка неверного формата brandId, например, возврат ошибки 400 Bad Request.
			return BadRequest("Invalid brandId format.");
		}

		return OnGetByBrand(brandIdInt);
	}

	public IActionResult OnGetByBrand(int brandId) {
		log.LogInformation("Получение списка автомобилей для бренда: {brandId}", brandId);

		ViewData["Title"] = $"Машины марки {brandId}";
		ViewData["Cars"] = cars.GetAllCarsByBrand(brandId);

		return Page();
	}
}
