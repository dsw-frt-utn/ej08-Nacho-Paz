using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ProblemaN5
{
    internal class Sale
    {
        protected decimal _total;

        public Sale(decimal total) { _total = total; }

        public virtual decimal CalculateTotal() { return _total; }
    }
}
