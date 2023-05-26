using CoffeeShop.Api.Services;
using CoffeeShop.DAL.Data;
using Microsoft.EntityFrameworkCore;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        builder.Services.AddAuthentication("Bearer")
            .AddIdentityServerAuthentication("Bearer", options =>
            {
                options.Authority = "https://localhost:5443";
                options.ApiName = "CoffeeAPI";
            });

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddScoped<IShopService, ShopService>();

        var app = builder.Build();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}