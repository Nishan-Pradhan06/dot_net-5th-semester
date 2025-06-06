namespace TestWebAppDotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            //www.abc.com/home/index
            app.MapDefaultControllerRoute();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
