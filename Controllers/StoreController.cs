using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private Store _store = new Store();

        [HttpPost]
        [Route("addProduct")]
        public ActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                _store.AddProductToCart(product);
                return Ok("Producto añadido al carrito con éxito.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("checkout")]
        public ActionResult Checkout()
        {
            try
            {
                _store.Checkout();
                return Ok("Checkout realizado con éxito.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
