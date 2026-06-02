using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Uninove.web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Ryan Delmondes";
        ViewBag.Curso = "Análise de Sistemas";
        ViewBag.Semestre = 1;

        return View();
    }
}