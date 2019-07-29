using System;
using System.Linq;
using System.Text;

namespace Project.Northwind.Entities.Concreate
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
