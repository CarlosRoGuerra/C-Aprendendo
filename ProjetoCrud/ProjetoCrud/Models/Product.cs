using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
namespace ProjetoCrud.Models
{
    public class Product
    {
        public List<ProductModel> listaProdutos = new List<ProductModel>();
        public Product()
        {
            listaProdutos.Add(new ProductModel
            {
                Name = "Cerveja",
                Description = "Muito Boa",
                Price = 20
            });
            listaProdutos.Add(new ProductModel
            {
                Name = "Coca-Cola",
                Description = "Muito ruim",
                Price = 10
            });
        }

        public void AdicionarProduto(ProductModel productModel)
        {
            listaProdutos.Add(productModel);
        }

        public void EditarProduto(ProductModel productModel)
        {
            int index = listaProdutos.FindIndex(p => p.Name == productModel.Name);

            if (index != -1)
            {
                listaProdutos[index] = productModel;
            }
        }

        public ProductModel ObterProduto(string nome)
        {
            return listaProdutos.FirstOrDefault(p => p.Name == nome);
        }

        public void ExcluirProduto(string nome)
        {
            listaProdutos.RemoveAll(p => p.Name == nome);
        }
    }
}
