using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploService.EntityModel
{
    public class ValorType
    {
        public ValorType()
        {

        }
        public ValorType(int valor)
        {
            Valor = valor;

        }
        public int Valor { get; set; }
        public float ValorDecimal { get; set; }
        public string ValorDescricao { get; set; }
               

    }
}
