using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public class DatabaseContext : DbContext
    {
        //Доступ к таблицам
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {
                 new Product("Алишань Гао Шань Ча", 640, "Нежный, маслянистый, легкий и одновременно насыщенный. С нотками тропических цветов и свежей зелени. Послевкусие яркое, богатое, цветочное с нотками липового меда","/images/1.jpg"),
            new Product("Алишань Улун", 604, "Мягкий, нежный, маслянистый, обволакивающий, со сладостью, чуть терпкой ноткой цветочных лепестков и легкой ванильной остринкой","/images/2.jpg"),
            new Product("Габа «Аметист»", 550, "Богатый, маслянистый, фруктово-цветочный, чуть пряный. Во вкусе чувствуется яблочная кислинка.","/images/3.jpg"),
            new Product("Габа «Янтарь»", 415, "Нежный и мягкий, обволакивающий, пряно-цветочный. Ярко выделяются нотки цветков ромашки и розы","/images/4.jpg"),
            new Product("Дун Дин Нун Сян", 700, "Яркий печеный аромат с орехово-медовым вкусом и сладким цветочным послевкусием.","/images/5.jpg"),
            new Product("Дун Фан Мэй Жень", 631, "Звонкая фруктовая кислинка, ром и пряность во вкусе","/images/6.jpg"),
            new Product("Жень Шень А", 535, "Нежный, насыщенный, маслянисто-обволакивающий, с цветочными нотками и яркой шипучей сладостью, тающей на языке, как у газировки","/images/7.jpg"),
            new Product("Лао Ча Ван", 480, "Фейерверк вкусов и ассоциаций, шоколадные, кофейные, коньячные, сигарные ноты перемежаются с вишневыми, карамельными, пряными","/images/8.jpg"),
            new Product("Най Сян Цзинь", 590, "Мягкий и нежный, чуть сладкий, с цветочно-сливочными нотками. Послевкусие с цветочно-медовой сладостью","/images/9.jpg"),
            new Product("Те Гуанинь Гандэ", 720, "Яркий и богатый, крепкий, но не терпкий, насыщенный с цветочными и медовыми нотками.","/images/10.jpg"),
            new Product("Хуан Мей", 485, "Мягкий, чуть терпкий, с интересной острой ноткой и цветочным оттенком","/images/11.jpg"),
            new Product("Ми Лань Сян", 515, "Терпкий, фруктовый, с земляничной кислинкой, а также с перчинкой, характерной для всех гуандунских улунов","/images/12.jpg")
            });
        }

    }
}
