using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeyzanurKarakas_ErenMeral.Models;
using BeyzanurKarakas_ErenMeral.Data;

namespace BeyzanurKarakas_ErenMeral.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

       public IActionResult Index()
    {
        var ProductViewModel = new ProductViewModel()
        {
            Products = ProductRepository.Products
        };

        return View(ProductViewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
