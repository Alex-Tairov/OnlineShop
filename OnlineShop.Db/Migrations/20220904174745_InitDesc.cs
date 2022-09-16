using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class InitDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10eceba0-9aa9-4b53-826d-eba4e1cff211"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a0898cd-4bf0-4483-8e8e-836a6fd14bcc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30c86f26-089c-42c2-8e48-bcbe6b364e57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b2ad65d-c275-44a5-82af-248545066186"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77aeb719-8428-4097-9060-4e6bcf733c8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90ba32b3-dde7-4827-ad2f-f2304d0d18a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c02ada35-d016-40fe-bd15-dd422e4e4b5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4bfa10c-f2e6-4bd3-86a8-26f45ef98cff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4fd0f01-c8b3-40c0-aece-0426e887979c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee39275f-6a62-4f51-a7ae-d2ee470da52d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2867383-d88d-4f8a-b920-622e5d2690e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f84f9f97-a043-42b4-8402-bbadf8332b4b"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { new Guid("849d202f-b7bc-4ee4-bb38-166eea5b6e1d"), 640, "Нежный, маслянистый, легкий и одновременно насыщенный. С нотками тропических цветов и свежей зелени. Послевкусие яркое, богатое, цветочное с нотками липового меда", "/images/1.jpg", "Алишань Гао Шань Ча" },
                    { new Guid("3242a40f-b5df-4d26-b768-afe229f8005d"), 604, "Мягкий, нежный, маслянистый, обволакивающий, со сладостью, чуть терпкой ноткой цветочных лепестков и легкой ванильной остринкой", "/images/2.jpg", "Алишань Улун" },
                    { new Guid("166fcfb8-f103-4e51-9b03-f020498b0352"), 550, "Богатый, маслянистый, фруктово-цветочный, чуть пряный. Во вкусе чувствуется яблочная кислинка.", "/images/3.jpg", "Габа «Аметист»" },
                    { new Guid("f740aa98-5728-4f28-b431-5f955f010cdc"), 415, "Нежный и мягкий, обволакивающий, пряно-цветочный. Ярко выделяются нотки цветков ромашки и розы", "/images/4.jpg", "Габа «Янтарь»" },
                    { new Guid("f5db8991-98ba-436f-b699-3e0fc6293411"), 700, "Яркий печеный аромат с орехово-медовым вкусом и сладким цветочным послевкусием.", "/images/5.jpg", "Дун Дин Нун Сян" },
                    { new Guid("8fd5fb30-da59-4b6c-af05-09f19c2c338d"), 631, "Звонкая фруктовая кислинка, ром и пряность во вкусе", "/images/6.jpg", "Дун Фан Мэй Жень" },
                    { new Guid("b76f8ab9-2ea9-4035-9546-ebb7cd574bc9"), 535, "Нежный, насыщенный, маслянисто-обволакивающий, с цветочными нотками и яркой шипучей сладостью, тающей на языке, как у газировки", "/images/7.jpg", "Жень Шень А" },
                    { new Guid("f9b090e0-f4f0-4d9a-a894-82a8cdecd1d8"), 480, "Фейерверк вкусов и ассоциаций, шоколадные, кофейные, коньячные, сигарные ноты перемежаются с вишневыми, карамельными, пряными", "/images/8.jpg", "Лао Ча Ван" },
                    { new Guid("dcbd62d2-18e0-4283-b1a6-decb3aa66588"), 590, "Мягкий и нежный, чуть сладкий, с цветочно-сливочными нотками. Послевкусие с цветочно-медовой сладостью", "/images/9.jpg", "Най Сян Цзинь" },
                    { new Guid("35975aea-a04a-4b10-a008-88eda2a625b5"), 720, "Яркий и богатый, крепкий, но не терпкий, насыщенный с цветочными и медовыми нотками.", "/images/10.jpg", "Те Гуанинь Гандэ" },
                    { new Guid("f87802c7-1e73-41a9-adb1-7af14ecd5031"), 485, "Мягкий, чуть терпкий, с интересной острой ноткой и цветочным оттенком", "/images/11.jpg", "Хуан Мей" },
                    { new Guid("05bb81a6-d4de-4228-932b-2bebd197b7c5"), 515, "Терпкий, фруктовый, с земляничной кислинкой, а также с перчинкой, характерной для всех гуандунских улунов", "/images/12.jpg", "Ми Лань Сян" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05bb81a6-d4de-4228-932b-2bebd197b7c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("166fcfb8-f103-4e51-9b03-f020498b0352"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3242a40f-b5df-4d26-b768-afe229f8005d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35975aea-a04a-4b10-a008-88eda2a625b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("849d202f-b7bc-4ee4-bb38-166eea5b6e1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fd5fb30-da59-4b6c-af05-09f19c2c338d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b76f8ab9-2ea9-4035-9546-ebb7cd574bc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcbd62d2-18e0-4283-b1a6-decb3aa66588"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5db8991-98ba-436f-b699-3e0fc6293411"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f740aa98-5728-4f28-b431-5f955f010cdc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f87802c7-1e73-41a9-adb1-7af14ecd5031"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9b090e0-f4f0-4d9a-a894-82a8cdecd1d8"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { new Guid("10eceba0-9aa9-4b53-826d-eba4e1cff211"), 640, "Desc1", "/images/1.jpg", "Алишань Гао Шань Ча" },
                    { new Guid("d4bfa10c-f2e6-4bd3-86a8-26f45ef98cff"), 604, "Desc2", "/images/2.jpg", "Алишань Улун" },
                    { new Guid("c02ada35-d016-40fe-bd15-dd422e4e4b5c"), 550, "Desc3", "/images/3.jpg", "Габа «Аметист»" },
                    { new Guid("e4fd0f01-c8b3-40c0-aece-0426e887979c"), 415, "Desc4", "/images/4.jpg", "Габа «Янтарь»" },
                    { new Guid("90ba32b3-dde7-4827-ad2f-f2304d0d18a6"), 700, "Desc4", "/images/5.jpg", "Дун Дин Нун Сян" },
                    { new Guid("2a0898cd-4bf0-4483-8e8e-836a6fd14bcc"), 631, "Desc4", "/images/6.jpg", "Дун Фан Мэй Жень" },
                    { new Guid("4b2ad65d-c275-44a5-82af-248545066186"), 535, "Desc4", "/images/7.jpg", "Жень Шень А" },
                    { new Guid("f84f9f97-a043-42b4-8402-bbadf8332b4b"), 480, "Desc4", "/images/8.jpg", "Лао Ча Ван" },
                    { new Guid("77aeb719-8428-4097-9060-4e6bcf733c8b"), 590, "Desc4", "/images/9.jpg", "Най Сян Цзинь " },
                    { new Guid("30c86f26-089c-42c2-8e48-bcbe6b364e57"), 720, "Desc4", "/images/10.jpg", "Те Гуанинь Гандэ" },
                    { new Guid("f2867383-d88d-4f8a-b920-622e5d2690e9"), 485, "Desc4", "/images/11.jpg", "Хуан Мей" },
                    { new Guid("ee39275f-6a62-4f51-a7ae-d2ee470da52d"), 515, "Desc4", "/images/12.jpg", "Ми Лань Сян" }
                });
        }
    }
}
