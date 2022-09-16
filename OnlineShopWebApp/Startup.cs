using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using Serilog;
using System;

namespace OnlineShopWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Получаем строку подключения из файла конфигурации
            string connection = Configuration.GetConnectionString("online_shop");
            //добавляем контекст DatabaseContext в качестве сервиса в приложении
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection));

            //добавляем контекст IdentityContext в качестве сервиса в приложении
            services.AddDbContext<IdentityContext>(options =>
               options.UseSqlServer(connection));

            //привязываем пользователя к роли
            services.AddIdentity<User, IdentityRole>() //указываем тип пользователя
                .AddEntityFrameworkStores<IdentityContext>(); //устанавливаем тип хранения

            //настройки кук
            services.ConfigureApplicationCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromHours(8);
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.Cookie = new CookieBuilder
                {
                    IsEssential = true
                };
            });

            services.AddControllersWithViews();
            services.AddTransient<ICartsRepository,CartsDbRepository>();
            services.AddTransient<IOrdersRepository, OrdersDbRepository>();
            services.AddTransient<IProductsRepository,ProductsDbRepository>();
            services.AddTransient<IFavoritesRepository, FavoritesDbRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSerilogRequestLogging();//для логирования каждого запроса

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //кто зашел на сайт(авторизован или нет)
            app.UseAuthentication(); // подключение аутентификации
            //какой пользователь зашел(с каким именем,ролью и тд)
            app.UseAuthorization(); // подключение авторизации
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
