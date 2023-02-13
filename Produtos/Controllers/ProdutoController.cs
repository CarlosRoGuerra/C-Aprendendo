using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MVCWithoutDatabase.Controllers
{
    public class ProductController : Controller
    {
        // Lista para armazenar produtos em memória
        private static List<Product> products = new List<Product>();

        // Ação para exibir a lista de produtos
        public ActionResult Index()
        {
            return View(products);
        }

        // Ação para exibir o formulário de criação de produtos
        public ActionResult Create()
        {
            return View();
        }

        // Ação para salvar o novo produto
        [HttpPost]
        public ActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index");
        }

        // Ação para exibir o formulário de edição de produtos
        public ActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        // Ação para atualizar o produto existente
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            return RedirectToAction("Index");
        }

        // Ação para excluir o produto existente
        public ActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            products.Remove(product);
            return RedirectToAction("Index");
        }
    }
}