﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Db;

namespace OnlineShop.Db.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220904174745_InitDesc")]
    partial class InitDesc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShop.Db.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Favorite", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("849d202f-b7bc-4ee4-bb38-166eea5b6e1d"),
                            Cost = 640,
                            Description = "Нежный, маслянистый, легкий и одновременно насыщенный. С нотками тропических цветов и свежей зелени. Послевкусие яркое, богатое, цветочное с нотками липового меда",
                            ImagePath = "/images/1.jpg",
                            Name = "Алишань Гао Шань Ча"
                        },
                        new
                        {
                            Id = new Guid("3242a40f-b5df-4d26-b768-afe229f8005d"),
                            Cost = 604,
                            Description = "Мягкий, нежный, маслянистый, обволакивающий, со сладостью, чуть терпкой ноткой цветочных лепестков и легкой ванильной остринкой",
                            ImagePath = "/images/2.jpg",
                            Name = "Алишань Улун"
                        },
                        new
                        {
                            Id = new Guid("166fcfb8-f103-4e51-9b03-f020498b0352"),
                            Cost = 550,
                            Description = "Богатый, маслянистый, фруктово-цветочный, чуть пряный. Во вкусе чувствуется яблочная кислинка.",
                            ImagePath = "/images/3.jpg",
                            Name = "Габа «Аметист»"
                        },
                        new
                        {
                            Id = new Guid("f740aa98-5728-4f28-b431-5f955f010cdc"),
                            Cost = 415,
                            Description = "Нежный и мягкий, обволакивающий, пряно-цветочный. Ярко выделяются нотки цветков ромашки и розы",
                            ImagePath = "/images/4.jpg",
                            Name = "Габа «Янтарь»"
                        },
                        new
                        {
                            Id = new Guid("f5db8991-98ba-436f-b699-3e0fc6293411"),
                            Cost = 700,
                            Description = "Яркий печеный аромат с орехово-медовым вкусом и сладким цветочным послевкусием.",
                            ImagePath = "/images/5.jpg",
                            Name = "Дун Дин Нун Сян"
                        },
                        new
                        {
                            Id = new Guid("8fd5fb30-da59-4b6c-af05-09f19c2c338d"),
                            Cost = 631,
                            Description = "Звонкая фруктовая кислинка, ром и пряность во вкусе",
                            ImagePath = "/images/6.jpg",
                            Name = "Дун Фан Мэй Жень"
                        },
                        new
                        {
                            Id = new Guid("b76f8ab9-2ea9-4035-9546-ebb7cd574bc9"),
                            Cost = 535,
                            Description = "Нежный, насыщенный, маслянисто-обволакивающий, с цветочными нотками и яркой шипучей сладостью, тающей на языке, как у газировки",
                            ImagePath = "/images/7.jpg",
                            Name = "Жень Шень А"
                        },
                        new
                        {
                            Id = new Guid("f9b090e0-f4f0-4d9a-a894-82a8cdecd1d8"),
                            Cost = 480,
                            Description = "Фейерверк вкусов и ассоциаций, шоколадные, кофейные, коньячные, сигарные ноты перемежаются с вишневыми, карамельными, пряными",
                            ImagePath = "/images/8.jpg",
                            Name = "Лао Ча Ван"
                        },
                        new
                        {
                            Id = new Guid("dcbd62d2-18e0-4283-b1a6-decb3aa66588"),
                            Cost = 590,
                            Description = "Мягкий и нежный, чуть сладкий, с цветочно-сливочными нотками. Послевкусие с цветочно-медовой сладостью",
                            ImagePath = "/images/9.jpg",
                            Name = "Най Сян Цзинь"
                        },
                        new
                        {
                            Id = new Guid("35975aea-a04a-4b10-a008-88eda2a625b5"),
                            Cost = 720,
                            Description = "Яркий и богатый, крепкий, но не терпкий, насыщенный с цветочными и медовыми нотками.",
                            ImagePath = "/images/10.jpg",
                            Name = "Те Гуанинь Гандэ"
                        },
                        new
                        {
                            Id = new Guid("f87802c7-1e73-41a9-adb1-7af14ecd5031"),
                            Cost = 485,
                            Description = "Мягкий, чуть терпкий, с интересной острой ноткой и цветочным оттенком",
                            ImagePath = "/images/11.jpg",
                            Name = "Хуан Мей"
                        },
                        new
                        {
                            Id = new Guid("05bb81a6-d4de-4228-932b-2bebd197b7c5"),
                            Cost = 515,
                            Description = "Терпкий, фруктовый, с земляничной кислинкой, а также с перчинкой, характерной для всех гуандунских улунов",
                            ImagePath = "/images/12.jpg",
                            Name = "Ми Лань Сян"
                        });
                });

            modelBuilder.Entity("OnlineShop.Db.Models.UserDeliveryInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserDeliveryInfo");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.CartItem", b =>
                {
                    b.HasOne("OnlineShop.Db.Models.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId");

                    b.HasOne("OnlineShop.Db.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("OnlineShop.Db.Models.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Favorite", b =>
                {
                    b.HasOne("OnlineShop.Db.Models.Product", "Product")
                        .WithMany("Favorite")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Order", b =>
                {
                    b.HasOne("OnlineShop.Db.Models.UserDeliveryInfo", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("Favorite");
                });
#pragma warning restore 612, 618
        }
    }
}
