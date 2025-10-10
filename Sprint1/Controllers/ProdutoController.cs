using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sprint1.Controllers
{
    public class ProdutosController : Controller
    {
        public static List<Produto> Produtos { get; set; } = new List<Produto>
        {
            new Produto { Produto_ID = 1, Titulo = "Naruto Clássico Vol. 1", Descricao = "A jornada de um jovem ninja.", Preco_original = 29.90m, Estoque = 10, Categoria = "Shounen", Idioma = "Português", Condicao_produto = "Novo", Peso = 0.2m },
            new Produto { Produto_ID = 2, Titulo = "One Piece Vol. 1", Descricao = "Monkey D. Luffy busca o maior tesouro.", Preco_original = 32.50m, Estoque = 5, Categoria = "Shounen", Idioma = "Português", Condicao_produto = "Novo", Peso = 0.22m },
            new Produto { Produto_ID = 3, Titulo = "Attack on Titan Vol. 34", Descricao = "O final da épica batalha.", Preco_original = 34.90m, Estoque = 15, Categoria = "Seinen", Idioma = "Português", Condicao_produto = "Novo", Peso = 0.25m }
        };

        public IActionResult Index()
        {
            return View(Produtos);
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
            return View();
        }
        [HttpPost]
        public IActionResult Create(Produto produto)
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

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var produto = Produtos.FirstOrDefault(p => p.Produto_ID == id);
            if (produto == null)
            {
                return NotFound();
            }
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
                produtoOriginal.Preco_original = produtoEditado.Preco_original;
                produtoOriginal.Estoque = produtoEditado.Estoque;
                produtoOriginal.Preco_descontado = produtoEditado.Preco_descontado;
                produtoOriginal.Peso = produtoEditado.Peso;
                produtoOriginal.Dimensoes = produtoEditado.Dimensoes;
                produtoOriginal.Condicao_produto = produtoEditado.Condicao_produto;
                produtoOriginal.Categoria = produtoEditado.Categoria;
                produtoOriginal.Idioma = produtoEditado.Idioma;
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
            }
            return RedirectToAction("Index");
        }
    }
}