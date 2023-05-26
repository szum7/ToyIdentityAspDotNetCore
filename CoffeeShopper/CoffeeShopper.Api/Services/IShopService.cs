using CoffeeShop.Api.Models;

namespace CoffeeShop.Api.Services
{
    public interface IShopService
    {
        Task<List<ShopModel>> List();
    }
}
