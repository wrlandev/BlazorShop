﻿using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models.DTOs
{
    public class CarinhoItemAdicionaDto
    {
        [Required]
        public int CarrinhoId { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        [Required]
        public int Quantidade { get; set; }
    }
}
