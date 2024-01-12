using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produto
{
    internal class Produto
    {
        public String Name;
        public double Price;
        public int Numbers;

        public double ValorTotalEmEstoque()
        {
            return Price * Numbers;
        }

        public override string ToString()
        {
            return Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Numbers
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
