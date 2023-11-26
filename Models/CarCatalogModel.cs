
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CarCatalogModel : PageModel {
    private readonly ILogger<CarCatalogModel> log;
    private readonly ApplicationDbContext context;
    private readonly ICarBrands carBrands;

    public CarCatalogModel(ILogger<CarCatalogModel> log, ApplicationDbContext context, ICarBrands carBrands) {
        this.log = log;
        this.context = context;
        this.carBrands = carBrands;
    }


    public void OnGet() {
        ViewData["title"] = "Каталог автомобилей";

        // Получаем все машины
        ViewData["carBrands"] = carBrands.GetAllCarBrands();
    }
}
