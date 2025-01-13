using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.DTOs
{
    public class CarrinhoItemAdicionaItemDto
    {
        [Required]
        public int CarrinhoId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantidade { get; set; }
    }
}
