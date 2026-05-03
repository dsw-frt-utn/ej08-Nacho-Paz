using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ProblemaN3
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copyValue = originalValue;
            copyValue++;

            Product copyProduct = product;
            copyProduct.SetDescription("Modificación");

            return $"{originalValue} - {copyValue} - {product.GetDescription()}";
        }
    }
}
