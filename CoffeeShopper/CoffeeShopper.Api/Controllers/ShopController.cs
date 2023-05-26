using CoffeeShop.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ShopController : ControllerBase
    {
        private readonly IShopService coffeeShopService;

        public ShopController(IShopService coffeeShopService)
        {
            this.coffeeShopService = coffeeShopService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var coffeeShops = await coffeeShopService.List();
            return Ok(coffeeShops);
        }
    }
}
