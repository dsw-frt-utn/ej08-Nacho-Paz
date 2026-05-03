using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ProblemaN5
{
    internal class RetailSale : Sale
    {
        public RetailSale(decimal total) : base(total) { }

        public override decimal CalculateTotal() { return _total; }
    }
}
