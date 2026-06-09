using Microsoft.AspNetCore.Mvc;

namespace Uninove_Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var nomes = new List<string>
            {
                "Caneta",
                "Caderno",
                "Mochila",
                "Notebook",
                "Monitor"
            };

            var precos = new List<double>
            {
                5.90,
                35.00,
                120.00,
                2500.00,
                899.90
            };

            ViewBag.Nomes = nomes;
            ViewBag.Precos = precos;

            return View();
        }
    }
}
