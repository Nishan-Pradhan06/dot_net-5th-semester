using Microsoft.EntityFrameworkCore;
using WebExampleWithEr.Models;

namespace WebExampleWithEr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConn")));
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //app.MapControllerRoute();
            //app.MapDefaultControllerRoute();//www.abc.com/Home/Iindex
            app.MapControllerRoute(name:"myRoute",pattern:"{controller=Student}/{action=Index}/{id?}");//www.abc.com/Home/Iindex

            app.Run();
        }
    }
}
