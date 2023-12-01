using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel {
  private readonly ILogger<IndexModel> _logger;
  private readonly ICars cars;

  public IndexModel(ILogger<IndexModel> logger, ICars cars) {
    _logger = logger;
    this.cars = cars;
  }

  public void OnGet() { ViewData["Cars"] = cars.GetLastCars(5); }
}