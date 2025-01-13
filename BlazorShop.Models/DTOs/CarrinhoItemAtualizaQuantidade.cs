using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.DTOs
{
    public class CarrinhoItemAtualizaQuantidade
    {
        public int CarrinhoId { get; set; }        
        public int Quantidade { get; set; }

    }
}