using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ProjetoCrud.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [DisplayName("Nome do Produto")]
        [Required]
        [StringLength(50, ErrorMessage = "O campo Nome permite no máximo 50 caracteres!")]
        public string Name { get; set; }
        [DisplayName("Descrição do Produto")]
        public string Description { get; set; }
        [DisplayName("Preço do Produto")]
        [Required]
        public decimal? Price { get; set; }
    }
}
