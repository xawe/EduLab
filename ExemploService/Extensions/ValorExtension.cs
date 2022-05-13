using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploService.Extensions
{
    public static class ValorExtension
    {
        public static string ToDescription(this EntityModel.ValorType value)
        {
            return ((decimal) value.Valor /100).ToString();
        }

        public static decimal ToDecimal(this EntityModel.ValorType value)
        {
            return (decimal)value.Valor / 100;
        }
    }
}
