
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DetailCarModel : PageModel {
	private readonly ILogger<DetailCarModel> log;
	private readonly ApplicationDbContext context;
	private readonly ICars cars;

	public DetailCarModel(ILogger<DetailCarModel> _logger, ApplicationDbContext context, ICars _cars) {
		log = _logger;
		this.context = context;
		cars = _cars;
	}

	public void OnGet(int Id) {
		log.LogInformation("Получение информации об автомобиле");

		Car car = cars.GetCarById(Id);

		ViewData["Title"] = "Автомобиль " + car.BrandCar + " " + car.ModelCar;

		ViewData["Car"] = car;
	}
}
