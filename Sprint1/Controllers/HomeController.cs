using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using System.Diagnostics;

namespace Sprint1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listaDeProdutos = ProdutosController.Produtos;

            return View(listaDeProdutos);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}