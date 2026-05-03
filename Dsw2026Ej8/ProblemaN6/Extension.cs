using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ProblemaN6
{
    internal static class Extension
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
                return "SIN-CODIGO";

            return code
                .Trim()
                .ToUpper()
                .Replace(" ", "-");
        }
    }
}
