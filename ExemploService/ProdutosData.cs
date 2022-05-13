using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploService
{
    public static class ProdutosData
    {
        public static List<EntityModel.Produto> ListaProdutos()
        {
            List<EntityModel.Produto> lista = new List<EntityModel.Produto>();

            lista.Add(new EntityModel.Produto { Descricao = "Camisa", Valor = new EntityModel.ValorType(3099)});
            lista.Add(new EntityModel.Produto { Descricao = "Calça", Valor = new EntityModel.ValorType(7999)});
            lista.Add(new EntityModel.Produto { Descricao = "Bota", Valor = new EntityModel.ValorType(129999) });
            lista.Add(new EntityModel.Produto { Descricao = "Bola", Valor = new EntityModel.ValorType(1000), Ativo = false });

            return lista;

        }
    }
}
