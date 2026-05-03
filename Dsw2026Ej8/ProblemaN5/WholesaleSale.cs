using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ProblemaN5
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal total) : base(total) { }

        public override decimal CalculateTotal() { return _total * 0.9m; }
    }
}
