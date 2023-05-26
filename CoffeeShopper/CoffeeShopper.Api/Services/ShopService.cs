using CoffeeShop.Api.Models;
using CoffeeShop.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Services
{
    public class ShopService : IShopService
    {
        private readonly AppDbContext dbContext;

        public ShopService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<ShopModel>> List()
        {
            var coffeeShops = await (from shop in dbContext.Shops
                                     select new ShopModel()
                                     {
                                         Id = shop.Id,
                                         Name = shop.Name,
                                         OpeningHours = shop.OpeningHours,
                                         Address = shop.Address
                                     }).ToListAsync();

            return coffeeShops;
        }
    }
}
