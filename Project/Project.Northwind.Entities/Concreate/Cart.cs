using System.Collections.Generic;
using System.Linq;

namespace Project.Northwind.Entities.Concreate
{
    public class Cart
    {
        public Cart()
        {
            cartLines = new List<CartLine>();
        }

        public List<CartLine> cartLines { get; set; }

        public decimal Total
        {
            get { return cartLines.Sum(c => c.Product.UnitPrice * c.Quantity); }
        }
    }
}
