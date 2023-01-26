namespace Routing_Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //cows moos
            app.MapControllerRoute(
                name: "Cow",
                pattern: "{num}",
                defaults: new { controller = "Home", action = "Cow" });

            //cow with name
            app.MapControllerRoute(
                name: "CowName",
                pattern: "{num}/{name}",
                defaults: new { controller = "Home", action = "CowName" });

            //gallery
            app.MapControllerRoute(
                name: "CowGallery",
                pattern: "AllCows/Gallery/{num}",
                defaults: new { controller = "Home", action = "CowGallery" });

            //cow pages
            app.MapControllerRoute(
                name: "CowGalleryPage",
                pattern: "AllCows/Gallery/5/Page{num}",
                defaults: new { controller = "Home", action = "CowGalleryPage" });

            //double nums
            app.MapControllerRoute(
                name: "AllCowsdoubleNum",
                pattern: "AllCows/Gallery/{num1}/{num2}",
                defaults: new { controller = "Home", action = "AllCowsdoubleNum" });

            //chickfila
            app.MapControllerRoute(
                name: "Chicken",
                pattern: "{EatMoreChicken}",
                defaults: new { controller = "Home", action = "Chicken" });

            //catches all
            app.MapControllerRoute(
                name: "MattCatchAll",
                pattern: "{*bruh}",
                defaults: new { controller = "Home", action = "index" });

            app.Run();
        }
    }
}