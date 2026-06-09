using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove_Web.Models;

namespace Uninove_Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Boletim()
    {
        var disciplinas = new List<string>
        {
            "Matemática",
            "Português",
            "História",
            "Física",
            "Inglês"
        };

        var notas = new List<double>
        {
            9.5,
            6.0,
            4.5,
            7.8,
            8.2
        };

        ViewBag.Disciplinas = disciplinas;
        ViewBag.Notas = notas;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
