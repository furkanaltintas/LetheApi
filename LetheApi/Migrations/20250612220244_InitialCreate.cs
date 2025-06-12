using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LetheApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePathName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Copyrights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Copyrights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ctas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ctas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpertiseContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertiseContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListService = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FooterAbouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterAbouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JournalContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InputPlaceholder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageIntros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageIntros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteLinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PathName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestimonialContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestimonialContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "ButtonText", "ButtonUrl", "Description", "DisplayTitle", "ImageUrl", "MainDescription", "MainTitle", "Title" },
                values: new object[] { 1, "More About Me", "/about", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus iste ipsam quod repellat. Hic tempora ullam aperiam ipsum optio magni vel inventore voluptatibus nisi maiores laboriosam fuga iure, velit eligendi ab vero minima? Quae ducimus ab dignissimos iure, eos consequatur est deleniti cum id aliquid neque.\r\n\r\nAutem tenetur commodi maiores. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Est eligendi fugit, facilis velit reiciendis iure laudantium. Praesentium repellat corrupti dolor sit sint obcaecati. Modi aut quo molestiae a explicabo maiores necessitatibus nemo repellendus architecto? Corrupti numquam ullam nostrum, eveniet at doloribus blanditiis aliquid a est porro aspernatur pariatur culpa soluta nesciunt odio quasi maxime debitis illum.\r\n\r\nLorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus iste ipsam quod repellat. Hic tempora ullam aperiam ipsum optio magni vel inventore voluptatibus nisi maiores laboriosam fuga iure, velit eligendi ab vero minima? Quae ducimus ab dignissimos iure, eos consequatur est deleniti cum id aliquid neque.", "An inspiring headline about yourself.", "images/thumbs/about/about-1200.jpg", "Eaque temporibus culpa perferendis expedita assumenda mollitia magnam. Lorem ipsum dolor sit amet consectetur adipisicing elit facilis voluptates voluptatum animi numquam quas ea praesentium quaerat maxime sunt odit inventore itaque est et autem sequi nulla. Distinctio obcaecati nesciunt asperiores dolorum tenetur voluptates, nemo alias doloremque. Quos cumque ipsum laudantium odio vero aut odit nostrum aliquam? Nostrum in facilis, minus fuga quasi voluptas explicabo possimus incidunt, expedita tempora eius rem nobis sequi. Doloribus esse sint suscipit quam nisi blanditiis voluptate explicabo.", "How I Got Here", "About" });

            migrationBuilder.InsertData(
                table: "ClientContents",
                columns: new[] { "Id", "Description", "DisplayTitle", "Title" },
                values: new object[] { 1, "Quibusdam quis autem voluptatibus earum vel ex error ea. Lorem ipsum dolor sit amet consectetur adipisicing elit. Laborum suscipit debitis quam dignissimos veritatis atque pariatur magnam obcaecati fugit reprehenderit vel numquam facere esse est deserunt, perferendis commodi voluptatem similique.\r\n\r\nLorem ipsum dolor sit amet consectetur adipisicing elit. Porro, numquam molestiae vel quaerat quas facilis voluptates rerum aspernatur quam voluptatem ea, vitae illo, omnis minus vero minima maiores quia nihil incidunt provident debitis ab qui quasi. Iure unde numquam in nulla praesentium nesciunt dolore exercitationem, odit expedita minima quisquam ullam ex. Aut perferendis vel consectetur modi esse. Temporibus reprehenderit alias magni atque repellat aspernatur voluptates, accusantium pariatur libero ad nesciunt illum labore facere. Earum iure consequatur cumque omnis maiores optio.", "I have had the privilege of working with these incredible brands.", "Clients" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "ImagePath", "ImagePathName", "PathUrl" },
                values: new object[,]
                {
                    { 1, "images/clients/flash.svg", "flash", "www.flash.com" },
                    { 2, "images/clients/rise.svg", "rise", "www.rise.com" },
                    { 3, "images/clients/cactus.svg", "cactus", "www.cactus.com" },
                    { 4, "images/clients/pinpoint.svg", "pinpoint", "www.pinpoint.com" },
                    { 5, "images/clients/proline.svg", "proline", "www.proline.com" },
                    { 6, "images/clients/vision.svg", "vision", "www.vision.com" },
                    { 7, "images/clients/volume.svg", "volume", "www.volume.com" },
                    { 8, "images/clients/hitech.svg", "hitech", "www.hitech.com" },
                    { 9, "images/clients/terra.svg", "terra", "www.terra.com" },
                    { 10, "images/clients/chain.svg", "chain", "www.chain.com" }
                });

            migrationBuilder.InsertData(
                table: "ContactContents",
                columns: new[] { "Id", "ButtonText", "Description", "EmailAddress", "EmailText", "ImagePath", "PhoneNumber", "PhoneText", "SocialMediaText", "Title" },
                values: new object[] { 1, "Send Me An Email", "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Deserunt quisquam voluptatibus debitis aperiam ratione. Officia, suscipit iure, tenetur eum consequatur, consequuntur omnis accusamus odit quod pariatur excepturi architecto veniam. Soluta modi dignissimos libero blanditiis at saepe doloribus temporibus illo facilis dolorem, aliquam obcaecati accusamus nihil laboriosam, esse vel. Quod, vitae.", "hello@lethe.com", "EMAIL", "images/thumbs/contact/contact-2400.jpg", "+1 (555) 123-4567", "PHONE", "FOLLOW ON SOCIAL", "Let's Work Together" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus iste ipsam quod repellat. Hic tempora ullam aperiam ipsum optio magni vel inventore voluptatibus nisi maiores laboriosam fuga iure, velit eligendi ab vero minima? Quae ducimus ab dignissimos iure, eos consequatur est deleniti cum id aliquid neque.\r\n\r\nAutem tenetur commodi maiores. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Est eligendi fugit, facilis velit reiciendis iure laudantium. Praesentium repellat corrupti dolor sit sint obcaecati. Modi aut quo molestiae a explicabo maiores necessitatibus nemo repellendus architecto? Corrupti numquam ullam nostrum, eveniet at doloribus blanditiis aliquid a est porro aspernatur pariatur culpa soluta nesciunt odio quasi maxime debitis illum." },
                    { 2, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus iste ipsam quod repellat. Hic tempora ullam aperiam ipsum optio magni vel inventore voluptatibus nisi maiores laboriosam fuga iure, velit eligendi ab vero minima? Quae ducimus ab dignissimos iure, eos consequatur est deleniti cum id aliquid neque.\r\n\r\nAutem tenetur commodi maiores. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Est eligendi fugit, facilis velit reiciendis iure laudantium. Praesentium repellat corrupti dolor sit sint obcaecati. Modi aut quo molestiae a explicabo maiores necessitatibus nemo repellendus architecto? Corrupti numquam ullam nostrum, eveniet at doloribus blanditiis aliquid a est porro aspernatur pariatur culpa soluta nesciunt odio quasi maxime debitis illum." }
                });

            migrationBuilder.InsertData(
                table: "Copyrights",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Design by Lethe Studio", "© Copyright Lethe 2025" });

            migrationBuilder.InsertData(
                table: "Ctas",
                columns: new[] { "Id", "ButtonText", "ButtonUrl", "Description", "Title" },
                values: new object[] { 1, "Let's Work Together", "/contact", "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Quis rem, esse doloribus sint eaque at debitis enim vitae minus expedita ratione dignissimos sit nostrum optio sequi. Ipsa at beatae quam.", "Get started with a consultation today." });

            migrationBuilder.InsertData(
                table: "ExpertiseContents",
                columns: new[] { "Id", "ButtonText", "ButtonUrl", "Description", "DisplayTitle", "Title" },
                values: new object[] { 1, "View All Services", "/services", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Laborum suscipit debitis quam dignissimos veritatis atque pariatur magnam obcaecati fugit reprehenderit vel numquam facere esse est deserunt, perferendis commodi voluptatem similique.", "My key areas of expertise.", "Expertise" });

            migrationBuilder.InsertData(
                table: "Expertises",
                columns: new[] { "Id", "Description", "ListService", "Title" },
                values: new object[,]
                {
                    { 1, "Quibusdam quis autem voluptatibus earum vel ex error ea magni. Rerum quam quos. Aut asperiores sit mollitia. Rem neque et voluptatem eos quia sed eligendi et. Eaque velit eligendi ut magnam. Cumque ducimus laborum doloribus facere maxime vel earum quidem enim suscipit.", "[\"Cumque Ducimus\",\"Maxime Vel\",\"Eligendi Et\"]", "Digital Marketing" },
                    { 2, "Rerum quam quos. Aut asperiores sit mollitia. Rem neque et voluptatem eos quia sed eligendi et. Eaque velit eligendi ut magnam. Cumque ducimus laborum doloribus facere maxime vel earum quidem enim suscipit.", "[\"Lorem Ipsum\",\"Voluptatibus Earum\",\"Cumque Ducimus\"]", "Social Media Marketing" }
                });

            migrationBuilder.InsertData(
                table: "FooterAbouts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas illum quasi facere libero, fugiat laboriosam possimus reprehenderit eveniet vero voluptatum fugit ad quis veritatis suscipit beatae incidunt perferendis tempore earum hic repellendus quisquam recusandae ipsa id esse. Nobis, aut deleniti. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Facere ratione dignissimos.", "About Lethe" });

            migrationBuilder.InsertData(
                table: "Intros",
                columns: new[] { "Id", "Description", "ImagePath", "Title" },
                values: new object[] { 1, "I create marketing\r\nstrategies for your\r\nbusiness that get\r\nresults.", "images/intro-bg.jpg", "Hello, I'm Furkan Altıntaş" });

            migrationBuilder.InsertData(
                table: "JournalContents",
                columns: new[] { "Id", "DisplayTitle", "Title" },
                values: new object[] { 1, "Latest articles from my blog.", "Recent Articles" });

            migrationBuilder.InsertData(
                table: "Journals",
                columns: new[] { "Id", "CategoryName", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Sponsored", "Need hosting for your website? We would highly recommend DreamHost. Enjoy 100% in-house support, guaranteed performance and uptime, 1-click installs, and a super-intuitive control panel to make managing your websites and projects easy. Sign up now to get started.", "Need Web Hosting for Your Websites?" },
                    { 2, "Productivity", "Rerum quam quos. Quibusdam quis autem voluptatibus earum vel ex error ea magni. Aut asperiores sit mollitia. Rem neque et voluptatem eos quia sed eligendi et. Eaque velit eligendi ut magnam. Cumque ducimus laborum doloribus facere maxime vel earum quidem enim suscipit.", "5 Marketing Productivity Apps for Your Team" },
                    { 3, "SEO", "Quibusdam quis autem voluptatibus earum vel ex error ea magni. Rerum quam quos. Aut asperiores sit mollitia. Rem neque et voluptatem eos quia sed eligendi et. Eaque velit eligendi ut magnam. Cumque ducimus laborum doloribus facere maxime vel earum quidem enim suscipit.", "7 SEO Factors to Consider for Better Website Ranking" },
                    { 4, "Productivity", "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Rerum ullam et laborum aperiam. Dignissimos quae voluptatibus ullam esse sapiente fugiat, rerum labore cupiditate obcaecati dolore necessitatibus id magni rem officia dolor nam sit laudantium. Quo eaque eveniet quibusdam unde.", "5 Effective Web Design Principles" }
                });

            migrationBuilder.InsertData(
                table: "Newsletters",
                columns: new[] { "Id", "ButtonText", "Description", "InputPlaceholder", "Title" },
                values: new object[] { 1, "Subscribe", "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Facere ratione dignissimos.", "Your Email Address", "Newsletter" });

            migrationBuilder.InsertData(
                table: "PageHeaders",
                columns: new[] { "Id", "PreTitle", "Title" },
                values: new object[,]
                {
                    { 1, "Hi, I'm Furkan", "About" },
                    { 2, "High-Impact Services", "Services" },
                    { 3, "Recent Writings", "My Blog" },
                    { 4, "Get In Touch", "Contact" }
                });

            migrationBuilder.InsertData(
                table: "PageIntros",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Alias eos quas blanditiis, quos sint nostrum fugit aperiam inventore optio itaque molestias corporis, ipsa tenetur eligendi nihil iste porro, natus culpa consequuntur? Maxime, corporis tempore. Sed tenetur veritatis velit recusandae eum, molestiae voluptate ducimus laudantium esse illo doloribus atque eligendi deleniti iusto.", "High-impact services to help your business" });

            migrationBuilder.InsertData(
                table: "SiteLinks",
                columns: new[] { "Id", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "Home", "/" },
                    { 2, "About", "/about" },
                    { 3, "Services", "/services" },
                    { 4, "Journal", "/blog" },
                    { 5, "Contact", "/contact" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Path", "PathName", "PathUrl" },
                values: new object[,]
                {
                    { 1, "M20,3H4C3.447,3,3,3.448,3,4v16c0,0.552,0.447,1,1,1h8.615v-6.96h-2.338v-2.725h2.338v-2c0-2.325,1.42-3.592,3.5-3.592 c0.699-0.002,1.399,0.034,2.095,0.107v2.42h-1.435c-1.128,0-1.348,0.538-1.348,1.325v1.735h2.697l-0.35,2.725h-2.348V21H20 c0.553,0,1-0.448,1-1V4C21,3.448,20.553,3,20,3z", "facebook", "www.facebook.com" },
                    { 2, "M19.633,7.997c0.013,0.175,0.013,0.349,0.013,0.523c0,5.325-4.053,11.461-11.46,11.461c-2.282,0-4.402-0.661-6.186-1.809 c0.324,0.037,0.636,0.05,0.973,0.05c1.883,0,3.616-0.636,5.001-1.721c-1.771-0.037-3.255-1.197-3.767-2.793 c0.249,0.037,0.499,0.062,0.761,0.062c0.361,0,0.724-0.05,1.061-0.137c-1.847-0.374-3.23-1.995-3.23-3.953v-0.05 c0.537,0.299,1.16,0.486,1.82,0.511C3.534,9.419,2.823,8.184,2.823,6.787c0-0.748,0.199-1.434,0.548-2.032 c1.983,2.443,4.964,4.04,8.306,4.215c-0.062-0.3-0.1-0.611-0.1-0.923c0-2.22,1.796-4.028,4.028-4.028 c1.16,0,2.207,0.486,2.943,1.272c0.91-0.175,1.782-0.512,2.556-0.973c-0.299,0.935-0.936,1.721-1.771,2.22 c0.811-0.088,1.597-0.312,2.319-0.624C21.104,6.712,20.419,7.423,19.633,7.997z", "twitter", "www.twitter.com" },
                    { 3, "M20.533,6.111c-0.469-1.209-1.424-2.165-2.633-2.632c-0.699-0.263-1.438-0.404-2.186-0.42 c-0.963-0.042-1.268-0.054-3.71-0.054s-2.755,0-3.71,0.054C7.548,3.074,6.809,3.215,6.11,3.479C4.9,3.946,3.945,4.902,3.477,6.111 c-0.263,0.7-0.404,1.438-0.419,2.186c-0.043,0.962-0.056,1.267-0.056,3.71c0,2.442,0,2.753,0.056,3.71 c0.015,0.748,0.156,1.486,0.419,2.187c0.469,1.208,1.424,2.164,2.634,2.632c0.696,0.272,1.435,0.426,2.185,0.45 c0.963,0.042,1.268,0.055,3.71,0.055s2.755,0,3.71-0.055c0.747-0.015,1.486-0.157,2.186-0.419c1.209-0.469,2.164-1.424,2.633-2.633 c0.263-0.7,0.404-1.438,0.419-2.186c0.043-0.962,0.056-1.267,0.056-3.71s0-2.753-0.056-3.71C20.941,7.57,20.801,6.819,20.533,6.111z M19.315,15.643c-0.007,0.576-0.111,1.147-0.311,1.688c-0.305,0.787-0.926,1.409-1.712,1.711c-0.535,0.199-1.099,0.303-1.67,0.311 c-0.95,0.044-1.218,0.055-3.654,0.055c-2.438,0-2.687,0-3.655-0.055c-0.569-0.007-1.135-0.112-1.669-0.311 c-0.789-0.301-1.414-0.923-1.719-1.711c-0.196-0.534-0.302-1.099-0.311-1.669c-0.043-0.95-0.053-1.218-0.053-3.654 c0-2.437,0-2.686,0.053-3.655c0.007-0.576,0.111-1.146,0.311-1.687c0.305-0.789,0.93-1.41,1.719-1.712 c0.534-0.198,1.1-0.303,1.669-0.311c0.951-0.043,1.218-0.055,3.655-0.055c2.437,0,2.687,0,3.654,0.055 c0.571,0.007,1.135,0.112,1.67,0.311c0.786,0.303,1.407,0.925,1.712,1.712c0.196,0.534,0.302,1.099,0.311,1.669 c0.043,0.951,0.054,1.218,0.054,3.655c0,2.436,0,2.698-0.043,3.654H19.315z", "instagram", "www.instagram.com" },
                    { 4, "M20.66 6.98a9.932 9.932 0 0 0-3.641-3.64C15.486 2.447 13.813 2 12 2s-3.486.447-5.02 1.34c-1.533.893-2.747 2.107-3.64 3.64S2 10.187 2 12s.446 3.487 1.34 5.02a9.924 9.924 0 0 0 3.641 3.64C8.514 21.553 10.187 22 12 22s3.486-.447 5.02-1.34a9.932 9.932 0 0 0 3.641-3.64C21.554 15.487 22 13.813 22 12s-.446-3.487-1.34-5.02zM12 3.66c2 0 3.772.64 5.32 1.919-.92 1.174-2.286 2.14-4.1 2.9-1.002-1.813-2.088-3.327-3.261-4.54A7.715 7.715 0 0 1 12 3.66zM5.51 6.8a8.116 8.116 0 0 1 2.711-2.22c1.212 1.201 2.325 2.7 3.34 4.5-2 .6-4.114.9-6.341.9-.573 0-1.006-.013-1.3-.04A8.549 8.549 0 0 1 5.51 6.8zM3.66 12c0-.054.003-.12.01-.2.007-.08.01-.146.01-.2.254.014.641.02 1.161.02 2.666 0 5.146-.367 7.439-1.1.187.373.381.793.58 1.26-1.32.293-2.674 1.006-4.061 2.14S6.4 16.247 5.76 17.5c-1.4-1.587-2.1-3.42-2.1-5.5zM12 20.34c-1.894 0-3.594-.587-5.101-1.759.601-1.187 1.524-2.322 2.771-3.401 1.246-1.08 2.483-1.753 3.71-2.02a29.441 29.441 0 0 1 1.56 6.62 8.166 8.166 0 0 1-2.94.56zm7.08-3.96a8.351 8.351 0 0 1-2.58 2.621c-.24-2.08-.7-4.107-1.379-6.081.932-.066 1.765-.1 2.5-.1.799 0 1.686.034 2.659.1a8.098 8.098 0 0 1-1.2 3.46zm-1.24-5c-1.16 0-2.233.047-3.22.14a27.053 27.053 0 0 0-.68-1.62c2.066-.906 3.532-2.006 4.399-3.3 1.2 1.414 1.854 3.027 1.96 4.84-.812-.04-1.632-.06-2.459-.06z", "dribble", "www.dribble.com" }
                });

            migrationBuilder.InsertData(
                table: "TestimonialContents",
                columns: new[] { "Id", "DisplayTitle", "Title" },
                values: new object[] { 1, "Reviews From Real Clients", "Testimonials" });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Description", "FullName", "ImagePath", "Profession" },
                values: new object[,]
                {
                    { 1, "Molestiae incidunt consequatur quis ipsa autem nam sit enim magni. Voluptas tempore rem. Explicabo a quaerat sint autem dolore ducimus ut consequatur neque. Nisi dolores quaerat fuga rem nihil nostrum. Laudantium quia consequatur molestias.", "John Rockefeller", "images/avatars/user-01.jpg", "Standard Oil Co." },
                    { 2, "Molestiae incidunt consequatur quis ipsa autem nam sit enim magni. Voluptas tempore rem. Explicabo a quaerat sint autem dolore ducimus ut consequatur neque. Nisi dolores quaerat fuga rem nihil nostrum. Laudantium quia consequatur molestias.", "Andrew Carnegie", "images/avatars/user-04.jpg", "Carnegie Steel Co." },
                    { 3, "Molestiae incidunt consequatur quis ipsa autem nam sit enim magni. Voluptas tempore rem. Explicabo a quaerat sint autem dolore ducimus ut consequatur neque. Nisi dolores quaerat fuga rem nihil nostrum. Laudantium quia consequatur molestias.", "Henry Ford", "images/avatars/user-06.jpg", "Ford Motor Co." },
                    { 4, "Molestiae incidunt consequatur quis ipsa autem nam sit enim magni. Voluptas tempore rem. Explicabo a quaerat sint autem dolore ducimus ut consequatur neque. Nisi dolores quaerat fuga rem nihil nostrum. Laudantium quia consequatur molestias.", "John Morgan", "images/avatars/user-02.jpg", "JP Morgan & Co." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Role", "Username" },
                values: new object[] { 1, "12345A.", "Admin", "furkanaltintas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "ClientContents");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ContactContents");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Copyrights");

            migrationBuilder.DropTable(
                name: "Ctas");

            migrationBuilder.DropTable(
                name: "ExpertiseContents");

            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "FooterAbouts");

            migrationBuilder.DropTable(
                name: "Intros");

            migrationBuilder.DropTable(
                name: "JournalContents");

            migrationBuilder.DropTable(
                name: "Journals");

            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "PageHeaders");

            migrationBuilder.DropTable(
                name: "PageIntros");

            migrationBuilder.DropTable(
                name: "SiteLinks");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "TestimonialContents");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
