using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("Cart")]
    public class CartController:ControllerBase
    {
        private readonly StoreContext context;

        public CartController(StoreContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Checkout(CartRequest request)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == request.IdUsuario);

            if (user == null)
            {
                return BadRequest("No existe el usuario");
            }

            foreach (var item in request.Products)
            {
                var product = await context.Products.FirstOrDefaultAsync(x => x.Id == item.Id);
                if (product == null)
                {
                    return BadRequest("No existe el producto");
                }
                if (product.Amount <= 0)
                {
                    return BadRequest($"El producto no tiene stock {product.Name}");
                }
                product.Amount -= 1;
            }
            Cart c = new Cart()
            {
                IdUser = request.IdUsuario
            };
            context.Add(c);
            await context.SaveChangesAsync();

            foreach (var item in request.Products)
            {
                CartProduct cp = new CartProduct()
                {
                    IdCart = c.Id,
                    Name = item.Name,
                    Price = item.Price
                };
                context.Add(cp);
                await context.SaveChangesAsync();
            }
            return Ok(user);
        }

        [HttpGet]
        public async Task<List<Order>> Get()
        {
            List<Order> orders = new List<Order>();
            var carts = await context.Carts.ToListAsync();

            foreach (var cart in carts)
            {
                var products = await context.CartProducts.Where(x => x.IdCart == cart.Id).ToListAsync();

                Order order = new Order()
                {
                    Products = products,
                    Id = cart.Id
                };
                order.Total = order.TotalPrice();
                orders.Add(order);
            }

            return orders;
        }
    }
}
