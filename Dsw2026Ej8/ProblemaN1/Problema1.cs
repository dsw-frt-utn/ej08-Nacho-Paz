using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dsw2026Ej8.ProblemaN1
{
    partial class ProductHelper
    {
        public ProductHelper()
        {
        }

        public ProductHelper(long code, string description, decimal price)
        {
            _code = code;
            _description = description;
            _price = price;
        }

        public long GetCode() => _code;
        public void SetCode(long value) => _code = value;

        public string GetDescription() => _description;
        public void SetDescription(string value) => _description = value;

        public decimal GetPrice() => _price;
        public void SetPrice(decimal value) => _price = value;

        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            return $"[{code}] {description} - {price.ToString("C2", new CultureInfo("es-AR"))}";
        }
    }
}
