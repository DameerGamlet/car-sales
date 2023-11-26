
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CarCatalogModel : PageModel {
    private readonly ILogger<CarCatalogModel> log;
    private readonly ApplicationDbContext context;
    private readonly ICarBrands brandCars;

    public CarCatalogModel(ILogger<CarCatalogModel> log, ApplicationDbContext context, ICarBrands carBrands) {
        this.log = log;
        this.context = context;
        this.brandCars = carBrands;
    }


    public void OnGet() {
        ViewData["title"] = "Каталог автомобилей";

        // Получаем все машины
        ViewData["brands"] = brandCars.GetAllCarBrands();
    }
}
