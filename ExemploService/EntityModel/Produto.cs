using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploService.EntityModel
{
    public class Produto
    {
        public Produto()
        {
            Ativo = true;
        }

        public string Descricao { get; set; }
        public EntityModel.ValorType Valor { get; set; }        
        public bool Ativo { get; set; }
    }
}
