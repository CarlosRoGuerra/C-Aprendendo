using Microsoft.AspNetCore.Mvc;
using ProjetoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCrud.Controllers
{
    public class ProductController : Controller
    {
        // Lista para armazenar produtos em memória
        private static List<ProductModel> _produtos = new List<ProductModel>();

        // Ação para exibir a lista de produtos

        public ActionResult Index()
        {
            return View(_produtos);
        }

        // Ação para exibir o formulário de criação de produtos
        public ActionResult AdicionarProduto()
        {
            return View();
        }

        // Ação para Criar o novo produto
        [HttpPost]
        public ActionResult AdicionarProduto(ProductModel productModel)
        {
            _produtos.Add(productModel);
            return RedirectToAction("Index");
        }

        public ActionResult EditarProduto(string name)
        {
            var item = _produtos.FirstOrDefault(p => p.Name == name);



            return View(item);
        }

        [HttpPost]
        public ActionResult EditarProduto(ProductModel productModel)
        {
            var item = _produtos.FirstOrDefault(p => p.Name == productModel.Name);


            item.Name = productModel.Name;
            item.Description = productModel.Description;
            item.Price = productModel.Price;


            return RedirectToAction("Index");
        }

        // Ação para excluir o produto existente
        public ActionResult DeleteProduct(string name)
        {
            var item = _produtos.FirstOrDefault(p => p.Name == name);

            return View(item);

        }

        [HttpPost, ActionName("DeleteProduct")]
        public ActionResult DeleteConfirmed(string name)
        {
            var item = _produtos.FirstOrDefault(p => p.Name == name);

            // Exclua o item
            _ = _produtos.Remove(item);

            return RedirectToAction("Index");
        }

    }
}

