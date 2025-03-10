﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using minerals.Data;

#nullable disable

namespace minerals.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250308153724_UpdateCart")]
    partial class UpdateCart
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("minerals.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("minerals.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hardness")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Shine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "white",
                            Hardness = "7 по шкале Мооса",
                            ImageUrl = "/assets/img/Quartz.jpg",
                            Name = "Кварц",
                            Price = 2500.0,
                            Shine = "Стеклянный"
                        },
                        new
                        {
                            Id = 2,
                            Color = "purple",
                            Hardness = "7 по шкале Мооса",
                            ImageUrl = "/assets/img/Ametist.jpg",
                            Name = "Аметист",
                            Price = 6000.0,
                            Shine = "Стеклянный"
                        },
                        new
                        {
                            Id = 3,
                            Color = "red",
                            Hardness = "6 по шкале Мооса",
                            ImageUrl = "/assets/img/Yashma.jpg",
                            Name = "Яшма",
                            Price = 12000.0,
                            Shine = "Матовый"
                        },
                        new
                        {
                            Id = 4,
                            Color = "black",
                            Hardness = "6.5 по шкале Мооса",
                            ImageUrl = "/assets/img/Agat.jpg",
                            Name = "Агат",
                            Price = 3000.0,
                            Shine = "Стеклянный"
                        },
                        new
                        {
                            Id = 5,
                            Color = "purple",
                            Hardness = "4 по шкале Мооса",
                            ImageUrl = "/assets/img/Fluorit.jpg",
                            Name = "Флюорит",
                            Price = 8000.0,
                            Shine = "Стеклянный"
                        },
                        new
                        {
                            Id = 6,
                            Color = "white",
                            Hardness = "6 по шкале Мооса",
                            ImageUrl = "/assets/img/Luna.jpg",
                            Name = "Лунный камень",
                            Price = 3500.0,
                            Shine = "Перламутровый"
                        },
                        new
                        {
                            Id = 7,
                            Color = "blue",
                            Hardness = "5 по шкале Мооса",
                            ImageUrl = "/assets/img/Lazurit.jpg",
                            Name = "Лазурит",
                            Price = 4000.0,
                            Shine = "Молочный"
                        },
                        new
                        {
                            Id = 8,
                            Color = "black",
                            Hardness = "5 по шкале Мооса",
                            ImageUrl = "/assets/img/Obsidian.jpg",
                            Name = "Обсидиан",
                            Price = 8000.0,
                            Shine = "Блестящий"
                        },
                        new
                        {
                            Id = 9,
                            Color = "blue",
                            Hardness = "7 по шкале Мооса",
                            ImageUrl = "/assets/img/Aqua.jpg",
                            Name = "Аквамарин",
                            Price = 5000.0,
                            Shine = "Стеклянный"
                        },
                        new
                        {
                            Id = 10,
                            Color = "green",
                            Hardness = "7.5 по шкале Мооса",
                            ImageUrl = "/assets/img/Emerald.jpg",
                            Name = "Изумруд",
                            Price = 4000.0,
                            Shine = "Стеклянный"
                        },
                        new
                        {
                            Id = 11,
                            Color = "red",
                            Hardness = "9 по шкале Мооса",
                            ImageUrl = "/assets/img/Rybin.jpg",
                            Name = "Рубин",
                            Price = 2500.0,
                            Shine = "Стеклянный"
                        },
                        new
                        {
                            Id = 12,
                            Color = "blue",
                            Hardness = "9 по шкале Мооса",
                            ImageUrl = "/assets/img/Sapphire.jpg",
                            Name = "Сапфир",
                            Price = 3000.0,
                            Shine = "Стеклянный"
                        },
                        new
                        {
                            Id = 13,
                            Color = "yellow",
                            Hardness = "7 по шкале Мооса",
                            ImageUrl = "/assets/img/YellowQuartz.jpg",
                            Name = "Желтый кварц",
                            Price = 1500.0,
                            Shine = "Стеклянный"
                        });
                });

            modelBuilder.Entity("minerals.Models.CartItem", b =>
                {
                    b.HasOne("minerals.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
