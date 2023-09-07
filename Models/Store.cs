using System;
using System.Collections.Generic;

namespace OnlineStore.Models
{
    public class Store
    {
        private Cart _cart = new Cart();

        public void AddProductToCart(Product product)
        {
            _cart.AddProduct(product);
        }

        public void Checkout()
        {
            var totalPrice = _cart.TotalPrice();
            if (totalPrice > 100)
            {
                throw new Exception("No se puede realizar el checkout si el total supera los $100.");
            }
            Console.WriteLine($"Checkout realizado con éxito. El total es: {totalPrice}.");
            _cart = new Cart(); // crea un nuevo carrito
        }
    }
}
