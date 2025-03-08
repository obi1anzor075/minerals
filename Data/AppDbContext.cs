using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using minerals.Models;

namespace minerals.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Добавляем начальные данные
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "Кварц", Color = "white", Hardness = "7 по шкале Мооса", Shine = "Стеклянный", Price = 2500, ImageUrl = "/assets/img/Quartz.jpg" },
                new Item { Id = 2, Name = "Аметист", Color = "purple", Hardness = "7 по шкале Мооса", Shine = "Стеклянный", Price = 6000, ImageUrl = "/assets/img/Ametist.jpg" },
                new Item { Id = 3, Name = "Яшма", Color = "red", Hardness = "6 по шкале Мооса", Shine = "Матовый", Price = 12000, ImageUrl = "/assets/img/Yashma.jpg" },
                new Item { Id = 4, Name = "Агат", Color = "black", Hardness = "6.5 по шкале Мооса", Shine = "Стеклянный", Price = 3000, ImageUrl = "/assets/img/Agat.jpg" },
                new Item { Id = 5, Name = "Флюорит", Color = "purple", Hardness = "4 по шкале Мооса", Shine = "Стеклянный", Price = 8000, ImageUrl = "/assets/img/Fluorit.jpg" },
                new Item { Id = 6, Name = "Лунный камень", Color = "white", Hardness = "6 по шкале Мооса", Shine = "Перламутровый", Price = 3500, ImageUrl = "/assets/img/Luna.jpg" },
                new Item { Id = 7, Name = "Лазурит", Color = "blue", Hardness = "5 по шкале Мооса", Shine = "Молочный", Price = 4000, ImageUrl = "/assets/img/Lazurit.jpg" },
                new Item { Id = 8, Name = "Обсидиан", Color = "black", Hardness = "5 по шкале Мооса", Shine = "Блестящий", Price = 8000, ImageUrl = "/assets/img/Obsidian.jpg" },
                new Item { Id = 9, Name = "Аквамарин", Color = "blue", Hardness = "7 по шкале Мооса", Shine = "Стеклянный", Price = 5000, ImageUrl = "/assets/img/Aqua.jpg" },
                new Item { Id = 10, Name = "Изумруд", Color = "green", Hardness = "7.5 по шкале Мооса", Shine = "Стеклянный", Price = 4000, ImageUrl = "/assets/img/Emerald.jpg" },
                new Item { Id = 11, Name = "Рубин", Color = "red", Hardness = "9 по шкале Мооса", Shine = "Стеклянный", Price = 2500, ImageUrl = "/assets/img/Rybin.jpg" },
                new Item { Id = 12, Name = "Сапфир", Color = "blue", Hardness = "9 по шкале Мооса", Shine = "Стеклянный", Price = 3000, ImageUrl = "/assets/img/Sapphire.jpg" },
                new Item { Id = 13, Name = "Желтый кварц", Color = "yellow", Hardness = "7 по шкале Мооса", Shine = "Стеклянный", Price = 1500, ImageUrl = "/assets/img/YellowQuartz.jpg" }
            );
        }
    }
}
