using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ProblemaN3
{
    internal class Product
    {
        private string _description;

        public Product(string description)
        {
            _description = description;
        }
        public string GetDescription() => _description;
        public void SetDescription(string value) => _description = value;
    }
}
