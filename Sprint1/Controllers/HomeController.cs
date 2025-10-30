using Microsoft.AspNetCore.Mvc;
using CP2.Models;
using CP2.Controllers; // <-- 1. ADICIONE ESTE 'USING'
using System.Diagnostics;

namespace CP2.Controllers
{
    public class HomeController : Controller
    {
        // (O seu _logger pode ficar aqui)

        // --- 2. ESTA � A MUDAN�A PRINCIPAL ---
        public IActionResult Index()
        {
            // Busca a lista est�tica e P�BLICA do seu ProdutosController
            var produtos = ProdutosController.Produtos;

            // Envia essa lista (agora atualizada) para a sua View Home/Index
            return View(produtos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}