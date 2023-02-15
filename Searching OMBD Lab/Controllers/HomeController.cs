using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Searching_OMBD_Lab.Models;

namespace Searching_OMBD_Lab.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult MovieSearchForm()
    {
        return View("MovieSearch");
    }
    [HttpPost]
    public IActionResult MovieSearchResults(string Title)
    {
        Movies result = MoviesDAL.GetMovie(Title);
        return View(result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

