using Microsoft.AspNetCore.Mvc;
using CP2.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering; 

namespace CP2.Controllers
{
    public class ProdutosController : Controller
    {
        public static List<Produto> Produtos { get; set; } = new List<Produto>
        {
            new Produto {
                Produto_ID = 1,
                Titulo = "Sonic Riders",
                Descricao = "Jogo de corrida do sonic em skates voadores!",
                Preco_original = 20,
                Categoria = "Corrida",
                Plataforma = "GameCube",
                Desenvolvedora = "Sonic Team",
                Condicao_produto = "Usado", 
                Estoque = 10,                 
                Imagem_url = "https://static.wikia.nocookie.net/sonic/images/9/91/Sonic_Riders_key_art_EN.png/revision/latest?cb=20210821035238"
            },
            new Produto {
                Produto_ID = 2,
                Titulo = "Hades",
                Descricao = "Fuja de tártaros como filho do demonio: HADES.",
                Preco_original = 30,
                Categoria = "Roguelike",
                Plataforma = "PC",
                Desenvolvedora = "Supergiant Games",
                Condicao_produto = "Novo", 
                Estoque = 5,                
                Imagem_url = "https://upload.wikimedia.org/wikipedia/pt/c/c5/Hades_capa.png"
            },
            new Produto {
                Produto_ID = 3,
                Titulo = "Silksong",
                Descricao = "Embarque nessa nova aventura como Hornet",
                Preco_original = 40,
                Categoria = "Metroidvania",
                Plataforma = "PC",
                Desenvolvedora = "Team Cherry",
                Condicao_produto = "Novo", 
                Estoque = 15,              
                Imagem_url = "https://upload.wikimedia.org/wikipedia/pt/1/1a/Hollow_Knight_Silksong_capa.jpg"
            }
        };

        private void PopularDropdowns()
        {
            ViewBag.Generos = new List<SelectListItem>
            {
                new SelectListItem { Text = "Corrida", Value = "Corrida" },
                new SelectListItem { Text = "Roguelike", Value = "Roguelike" },
                new SelectListItem { Text = "Metroidvania", Value = "Metroidvania" },
                new SelectListItem { Text = "RPG", Value = "RPG" },
                new SelectListItem { Text = "Ação", Value = "Ação" },
                new SelectListItem { Text = "Aventura", Value = "Aventura" },
                new SelectListItem { Text = "Plataforma", Value = "Plataforma" }
            };

            ViewBag.Plataformas = new List<SelectListItem>
            {
                new SelectListItem { Text = "PC", Value = "PC" },
                new SelectListItem { Text = "GameCube", Value = "GameCube" },
                new SelectListItem { Text = "PlayStation 5", Value = "PlayStation 5" },
                new SelectListItem { Text = "Xbox Series X", Value = "Xbox Series X" },
                new SelectListItem { Text = "Nintendo Switch", Value = "Nintendo Switch" }
            };
        }


        public IActionResult Index(string termoBusca)
        {
            ViewData["termoBuscaAtual"] = termoBusca;
            var produtos = Produtos.AsEnumerable();
            if (!String.IsNullOrEmpty(termoBusca))
            {
                produtos = produtos.Where(p => p.Titulo.Contains(termoBusca, StringComparison.OrdinalIgnoreCase));
            }
            return View(produtos.ToList());
        }

        public IActionResult Details(int id)
        {
            var produto = Produtos.FirstOrDefault(p => p.Produto_ID == id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        public IActionResult Create()
        {
            PopularDropdowns(); 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                if (Produtos.Any())
                {
                    produto.Produto_ID = Produtos.Max(p => p.Produto_ID) + 1;
                }
                else
                {
                    produto.Produto_ID = 1;
                }
                Produtos.Add(produto);
                TempData["MensagemSucesso"] = $"Produto '{produto.Titulo}' cadastrado com sucesso!";
                return RedirectToAction("Index");
            }

            PopularDropdowns();
            return View(produto);
        }

        public IActionResult Edit(int id)
        {
            var produto = Produtos.FirstOrDefault(p => p.Produto_ID == id);
            if (produto == null)
            {
                return NotFound();
            }
            PopularDropdowns(); 
            return View(produto);
        }

        [HttpPost]
        public IActionResult Edit(Produto produtoEditado)
        {
            var produtoOriginal = Produtos.FirstOrDefault(p => p.Produto_ID == produtoEditado.Produto_ID);

            if (produtoOriginal != null)
            {
                produtoOriginal.Titulo = produtoEditado.Titulo;
                produtoOriginal.Descricao = produtoEditado.Descricao;
                produtoOriginal.Imagem_url = produtoEditado.Imagem_url;
                produtoOriginal.Preco_original = produtoEditado.Preco_original;
                produtoOriginal.Plataforma = produtoEditado.Plataforma;
                produtoOriginal.Categoria = produtoEditado.Categoria;
                produtoOriginal.Desenvolvedora = produtoEditado.Desenvolvedora;

                TempData["MensagemSucesso"] = $"Produto '{produtoOriginal.Titulo}' editado com sucesso!";
            }
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var produto = Produtos.FirstOrDefault(p => p.Produto_ID == id);
            if (produto != null)
            {
                Produtos.Remove(produto);
                TempData["MensagemSucesso"] = $"Produto '{produto.Titulo}' excluído com sucesso!";
            }
            return RedirectToAction("Index");
        }
    }
}