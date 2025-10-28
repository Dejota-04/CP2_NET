using Microsoft.AspNetCore.Mvc;
using CP2.Models;
using System.Collections.Generic;
using System.Linq;

namespace CP2.Controllers
{
    public class ProdutosController : Controller
    {
        public static List<Produto> Produtos { get; set; } = new List<Produto>
        {
            new Produto { Produto_ID = 1, Titulo = "Sonic Riders", Descricao = "Jogo de corrida do sonic em skates voadores!", Estoque = 10, Categoria = "Corrida", Idioma = "Inglês" },
            new Produto { Produto_ID = 2, Titulo = "Hades", Descricao = "Fuja de tártaros como filho do demonio: HADES.", Estoque = 5, Categoria = "Roguelike", Idioma = "Português" },
            new Produto { Produto_ID = 3, Titulo = "Silksong", Descricao = "Embarque nessa nova aventura como Hornet", Estoque = 15, Categoria = "Metroidvania", Idioma = "Português" }
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