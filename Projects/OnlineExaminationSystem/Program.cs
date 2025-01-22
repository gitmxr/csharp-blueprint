using OnlineExaminationSystem.Models;

namespace OnlineExaminationSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IExamRepository, MockExamRepository>();
            builder.Services.AddScoped<IUserRepository, MockUserRepository>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.MapDefaultControllerRoute();

            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=User}/{action=Index}");        
            app.Run();
        }
    }
}
