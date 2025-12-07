using LiveCurrencyApp.Services;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly CurrencyService _currencyService;

    public HomeController(CurrencyService currencyService)
    {
        _currencyService = currencyService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _currencyService.GetExchangeRatesAsync();

        if (data == null)
        {
            ViewBag.Error = "Failed to fetch rate data.";
            return View(null);
        }

        return View(data);
    }

    [HttpGet]
    public async Task<IActionResult> GetRates()
    {
        var data = await _currencyService.GetExchangeRatesAsync();
        return Json(data);
    }
}
