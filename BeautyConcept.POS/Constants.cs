using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyConcept.POS
{
    public static class Constants
    {
        public static char CurrencyPrefix = '$';
        public static string Zero { get { return "0.00"; } }
        public static decimal TaxRate { get { return 10.0M; } }
    }
}
