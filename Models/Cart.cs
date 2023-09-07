using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        private List<Product> _products = new List<Product>();

        public IEnumerable<Product> Products => _products;

        public int IdUser { get; set; }

        public void AddProduct(Product product)
        {
            if (_products.Count >= 5)
            {
                throw new Exception("No puedes añadir más de 5 productos al carrito.");
            }
            _products.Add(product);
        }

        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.Price;
            }
            return total;
        }
    }

    public class CartRequest
    {
        public int IdUsuario { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public List<CartProduct> Products { get; set; }
        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }

}
