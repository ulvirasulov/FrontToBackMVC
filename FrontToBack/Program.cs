using FrontToBack.DAL;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
                {
                    opt.UseSqlServer("server=DELL\\SQLEXPRESS;database=SafeCamDB;trusted_connection=true;Encrypt=false");
                }
            );

            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}"
                );

            app.UseStaticFiles();

            app.Run();
        }
    }
}
