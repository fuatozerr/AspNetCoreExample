using Project.Business.Abstract;
using Project.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project.Business.Concreate
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.cartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if(cartLine!=null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.cartLines.Add(new CartLine { Product =product,Quantity=1});
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.cartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.cartLines.Remove(cart.cartLines.FirstOrDefault(c => c.Product.ProductId == productId));

        }
    }
}
