using LetheApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LetheApi.Data.SeedData;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region About
        modelBuilder.Entity<About>().HasData(
            new About
            {
                Id = 1,
                Title = "About",
                DisplayTitle = "An inspiring headline about yourself.",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus iste ipsam quod repellat. Hic tempora ullam aperiam ipsum optio magni vel inventore voluptatibus nisi maiores laboriosam fuga iure, velit eligendi ab vero minima? Quae ducimus ab dignissimos iure, eos consequatur est deleniti cum id aliquid neque.\r\n\r\nAutem tenetur commodi maiores. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Est eligendi fugit, facilis velit reiciendis iure laudantium. Praesentium repellat corrupti dolor sit sint obcaecati. Modi aut quo molestiae a explicabo maiores necessitatibus nemo repellendus architecto? Corrupti numquam ullam nostrum, eveniet at doloribus blanditiis aliquid a est porro aspernatur pariatur culpa soluta nesciunt odio quasi maxime debitis illum.\r\n\r\nLorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus iste ipsam quod repellat. Hic tempora ullam aperiam ipsum optio magni vel inventore voluptatibus nisi maiores laboriosam fuga iure, velit eligendi ab vero minima? Quae ducimus ab dignissimos iure, eos consequatur est deleniti cum id aliquid neque.",
                ButtonText = "More About Me",
                ButtonUrl = "/about",
                ImageUrl = "images/thumbs/about/about-1200.jpg",
                MainTitle = "How I Got Here",
                MainDescription = "Eaque temporibus culpa perferendis expedita assumenda mollitia magnam. Lorem ipsum dolor sit amet consectetur adipisicing elit facilis voluptates voluptatum animi numquam quas ea praesentium quaerat maxime sunt odit inventore itaque est et autem sequi nulla. Distinctio obcaecati nesciunt asperiores dolorum tenetur voluptates, nemo alias doloremque. Quos cumque ipsum laudantium odio vero aut odit nostrum aliquam? Nostrum in facilis, minus fuga quasi voluptas explicabo possimus incidunt, expedita tempora eius rem nobis sequi. Doloribus esse sint suscipit quam nisi blanditiis voluptate explicabo."
            });
        #endregion

        #region Client
        modelBuilder.Entity<Client>().HasData(
            new Client
            {
                Id = 1,
                ImagePath = "images/clients/flash.svg",
                ImagePathName = "flash",
                PathUrl = "www.flash.com"
            },
            new Client
            {
                Id = 2,
                ImagePath = "images/clients/rise.svg",
                ImagePathName = "rise",
                PathUrl = "www.rise.com"
            },
            new Client
            {
                Id = 3,
                ImagePath = "images/clients/cactus.svg",
                ImagePathName = "cactus",
                PathUrl = "www.cactus.com"
            },
            new Client
            {
                Id = 4,
                ImagePath = "images/clients/pinpoint.svg",
                ImagePathName = "pinpoint",
                PathUrl = "www.pinpoint.com"
            },
            new Client
            {
                Id = 5,
                ImagePath = "images/clients/proline.svg",
                ImagePathName = "proline",
                PathUrl = "www.proline.com"
            },
            new Client
            {
                Id = 6,
                ImagePath = "images/clients/vision.svg",
                ImagePathName = "vision",
                PathUrl = "www.vision.com"
            },
            new Client
            {
                Id = 7,
                ImagePath = "images/clients/volume.svg",
                ImagePathName = "volume",
                PathUrl = "www.volume.com"
            },
            new Client
            {
                Id = 8,
                ImagePath = "images/clients/hitech.svg",
                ImagePathName = "hitech",
                PathUrl = "www.hitech.com"
            },
            new Client
            {
                Id = 9,
                ImagePath = "images/clients/terra.svg",
                ImagePathName = "terra",
                PathUrl = "www.terra.com"
            },
            new Client
            {
                Id = 10,
                ImagePath = "images/clients/chain.svg",
                ImagePathName = "chain",
                PathUrl = "www.chain.com"
            });
        #endregion

        #region ClientContent
        modelBuilder.Entity<ClientContent>().HasData(
            new ClientContent
            {
                Id = 1,
                Title = "Clients",
                DisplayTitle = "I have had the privilege of working with these incredible brands.",
                Description = "Quibusdam quis autem voluptatibus earum vel ex error ea. Lorem ipsum dolor sit amet consectetur adipisicing elit. Laborum suscipit debitis quam dignissimos veritatis atque pariatur magnam obcaecati fugit reprehenderit vel numquam facere esse est deserunt, perferendis commodi voluptatem similique.\r\n\r\nLorem ipsum dolor sit amet consectetur adipisicing elit. Porro, numquam molestiae vel quaerat quas facilis voluptates rerum aspernatur quam voluptatem ea, vitae illo, omnis minus vero minima maiores quia nihil incidunt provident debitis ab qui quasi. Iure unde numquam in nulla praesentium nesciunt dolore exercitationem, odit expedita minima quisquam ullam ex. Aut perferendis vel consectetur modi esse. Temporibus reprehenderit alias magni atque repellat aspernatur voluptates, accusantium pariatur libero ad nesciunt illum labore facere. Earum iure consequatur cumque omnis maiores optio.",

            });
        #endregion

        #region Contact
        modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                Id = 1,
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus iste ipsam quod repellat. Hic tempora ullam aperiam ipsum optio magni vel inventore voluptatibus nisi maiores laboriosam fuga iure, velit eligendi ab vero minima? Quae ducimus ab dignissimos iure, eos consequatur est deleniti cum id aliquid neque.\r\n\r\nAutem tenetur commodi maiores. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Est eligendi fugit, facilis velit reiciendis iure laudantium. Praesentium repellat corrupti dolor sit sint obcaecati. Modi aut quo molestiae a explicabo maiores necessitatibus nemo repellendus architecto? Corrupti numquam ullam nostrum, eveniet at doloribus blanditiis aliquid a est porro aspernatur pariatur culpa soluta nesciunt odio quasi maxime debitis illum.",
            },
            new Contact
            {
                Id = 2,
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus iste ipsam quod repellat. Hic tempora ullam aperiam ipsum optio magni vel inventore voluptatibus nisi maiores laboriosam fuga iure, velit eligendi ab vero minima? Quae ducimus ab dignissimos iure, eos consequatur est deleniti cum id aliquid neque.\r\n\r\nAutem tenetur commodi maiores. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Est eligendi fugit, facilis velit reiciendis iure laudantium. Praesentium repellat corrupti dolor sit sint obcaecati. Modi aut quo molestiae a explicabo maiores necessitatibus nemo repellendus architecto? Corrupti numquam ullam nostrum, eveniet at doloribus blanditiis aliquid a est porro aspernatur pariatur culpa soluta nesciunt odio quasi maxime debitis illum.",
            });
        #endregion

        #region ContactContent
        modelBuilder.Entity<ContactContent>().HasData(
            new ContactContent
            {
                Id = 1,
                ImagePath = "images/thumbs/contact/contact-2400.jpg",
                Title = "Let's Work Together",
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Deserunt quisquam voluptatibus debitis aperiam ratione. Officia, suscipit iure, tenetur eum consequatur, consequuntur omnis accusamus odit quod pariatur excepturi architecto veniam. Soluta modi dignissimos libero blanditiis at saepe doloribus temporibus illo facilis dolorem, aliquam obcaecati accusamus nihil laboriosam, esse vel. Quod, vitae.",
                ButtonText = "Send Me An Email",
                SocialMediaText = "FOLLOW ON SOCIAL",
                EmailText = "EMAIL",
                EmailAddress = "hello@lethe.com",
                PhoneText = "PHONE",
                PhoneNumber = "+1 (555) 123-4567"
            });
        #endregion

        #region Copyright
        modelBuilder.Entity<Copyright>().HasData(
            new Copyright
            {
                Id = 1,
                Title = "© Copyright Lethe 2025",
                Description = "Design by Lethe Studio"
            });
        #endregion

        #region Cta
        modelBuilder.Entity<Cta>().HasData(
            new Cta
            {
                Id = 1,
                Title = "Get started with a consultation today.",
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Quis rem, esse doloribus sint eaque at debitis enim vitae minus expedita ratione dignissimos sit nostrum optio sequi. Ipsa at beatae quam.",
                ButtonText = "Let's Work Together",
                ButtonUrl = "/contact"
            });
        #endregion

        #region Expertise
        modelBuilder.Entity<Expertise>().HasData(
            new Expertise
            {
                Id = 1,
                Title = "Digital Marketing",
                Description = "Quibusdam quis autem voluptatibus earum vel ex error ea magni. Rerum quam quos. Aut asperiores sit mollitia. Rem neque et voluptatem eos quia sed eligendi et. Eaque velit eligendi ut magnam. Cumque ducimus laborum doloribus facere maxime vel earum quidem enim suscipit.",
                ListService = ["Cumque Ducimus", "Maxime Vel", "Eligendi Et"]
            },
            new Expertise
            {
                Id = 2,
                Title = "Social Media Marketing",
                Description = "Rerum quam quos. Aut asperiores sit mollitia. Rem neque et voluptatem eos quia sed eligendi et. Eaque velit eligendi ut magnam. Cumque ducimus laborum doloribus facere maxime vel earum quidem enim suscipit.",
                ListService = ["Lorem Ipsum", "Voluptatibus Earum", "Cumque Ducimus"]
            });
        #endregion

        #region ExpertiseContent
        modelBuilder.Entity<ExpertiseContent>().HasData(
            new ExpertiseContent
            {
                Id = 1,
                Title = "Expertise",
                DisplayTitle = "My key areas of expertise.",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Laborum suscipit debitis quam dignissimos veritatis atque pariatur magnam obcaecati fugit reprehenderit vel numquam facere esse est deserunt, perferendis commodi voluptatem similique.",
                ButtonText = "View All Services",
                ButtonUrl = "/services",
            });
        #endregion

        #region FooterAbout
        modelBuilder.Entity<FooterAbout>().HasData(
            new FooterAbout
            {
                Id = 1,
                Title = "About Lethe",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas illum quasi facere libero, fugiat laboriosam possimus reprehenderit eveniet vero voluptatum fugit ad quis veritatis suscipit beatae incidunt perferendis tempore earum hic repellendus quisquam recusandae ipsa id esse. Nobis, aut deleniti. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Facere ratione dignissimos."
            });
        #endregion

        #region Intro
        modelBuilder.Entity<Intro>().HasData(
            new Intro
            {
                Id = 1,
                Title = "Hello, I'm Furkan Altıntaş",
                Description = "I create marketing\r\nstrategies for your\r\nbusiness that get\r\nresults.",
                ImagePath = "images/intro-bg.jpg"
            });
        #endregion

        #region Journal
        modelBuilder.Entity<Journal>().HasData(
            new Journal
            {
                Id = 1,
                CategoryName = "Sponsored",
                Title = "Need Web Hosting for Your Websites?",
                Description = "Need hosting for your website? We would highly recommend DreamHost. Enjoy 100% in-house support, guaranteed performance and uptime, 1-click installs, and a super-intuitive control panel to make managing your websites and projects easy. Sign up now to get started."
            },
            new Journal
            {
                Id = 2,
                CategoryName = "Productivity",
                Title = "5 Marketing Productivity Apps for Your Team",
                Description = "Rerum quam quos. Quibusdam quis autem voluptatibus earum vel ex error ea magni. Aut asperiores sit mollitia. Rem neque et voluptatem eos quia sed eligendi et. Eaque velit eligendi ut magnam. Cumque ducimus laborum doloribus facere maxime vel earum quidem enim suscipit."
            },
            new Journal
            {
                Id = 3,
                CategoryName = "SEO",
                Title = "7 SEO Factors to Consider for Better Website Ranking",
                Description = "Quibusdam quis autem voluptatibus earum vel ex error ea magni. Rerum quam quos. Aut asperiores sit mollitia. Rem neque et voluptatem eos quia sed eligendi et. Eaque velit eligendi ut magnam. Cumque ducimus laborum doloribus facere maxime vel earum quidem enim suscipit."
            },
            new Journal
            {
                Id = 4,
                CategoryName = "Productivity",
                Title = "5 Effective Web Design Principles",
                Description = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Rerum ullam et laborum aperiam. Dignissimos quae voluptatibus ullam esse sapiente fugiat, rerum labore cupiditate obcaecati dolore necessitatibus id magni rem officia dolor nam sit laudantium. Quo eaque eveniet quibusdam unde."
            });
        #endregion

        #region JournalContent
        modelBuilder.Entity<JournalContent>().HasData(
            new JournalContent
            {
                Id = 1,
                Title = "Recent Articles",
                DisplayTitle = "Latest articles from my blog."
            });
        #endregion

        #region Newsletter
        modelBuilder.Entity<Newsletter>().HasData(
            new Newsletter
            {
                Id = 1,
                Title = "Newsletter",
                Description = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Facere ratione dignissimos.",
                InputPlaceholder = "Your Email Address",
                ButtonText = "Subscribe"
            });
        #endregion

        #region PageHeader
        modelBuilder.Entity<PageHeader>().HasData(
            new PageHeader
            {
                Id = 1,
                Title = "About",
                PreTitle = "Hi, I'm Furkan"
            },
            new PageHeader
            {
                Id = 2,
                Title = "Services",
                PreTitle = "High-Impact Services"
            },
            new PageHeader
            {
                Id = 3,
                Title = "My Blog",
                PreTitle = "Recent Writings"
            },
            new PageHeader
            {
                Id = 4,
                Title = "Contact",
                PreTitle = "Get In Touch"
            });
        #endregion

        #region PageIntro
        modelBuilder.Entity<PageIntro>().HasData(
            new PageIntro
            {
                Id = 1,
                Title = "High-impact services to help your business",
                Description = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Alias eos quas blanditiis, quos sint nostrum fugit aperiam inventore optio itaque molestias corporis, ipsa tenetur eligendi nihil iste porro, natus culpa consequuntur? Maxime, corporis tempore. Sed tenetur veritatis velit recusandae eum, molestiae voluptate ducimus laudantium esse illo doloribus atque eligendi deleniti iusto."
            });
        #endregion

        #region SiteLink
        modelBuilder.Entity<SiteLink>().HasData(
            new SiteLink
            {
                Id = 1,
                Title = "Home",
                Url = "/"
            },
            new SiteLink
            {
                Id = 2,
                Title = "About",
                Url = "/about"
            },
            new SiteLink
            {
                Id = 3,
                Title = "Services",
                Url = "/services"
            },
            new SiteLink
            {
                Id = 4,
                Title = "Journal",
                Url = "/blog"
            },
            new SiteLink
            {
                Id = 5,
                Title = "Contact",
                Url = "/contact"
            });
        #endregion

        #region SocialMedia
        modelBuilder.Entity<SocialMedia>().HasData(
            new SocialMedia
            {
                Id = 1,
                PathName = "facebook",
                Path = "M20,3H4C3.447,3,3,3.448,3,4v16c0,0.552,0.447,1,1,1h8.615v-6.96h-2.338v-2.725h2.338v-2c0-2.325,1.42-3.592,3.5-3.592 c0.699-0.002,1.399,0.034,2.095,0.107v2.42h-1.435c-1.128,0-1.348,0.538-1.348,1.325v1.735h2.697l-0.35,2.725h-2.348V21H20 c0.553,0,1-0.448,1-1V4C21,3.448,20.553,3,20,3z",
                PathUrl = "www.facebook.com"
            },
            new SocialMedia
            {
                Id = 2,
                PathName = "twitter",
                Path = "M19.633,7.997c0.013,0.175,0.013,0.349,0.013,0.523c0,5.325-4.053,11.461-11.46,11.461c-2.282,0-4.402-0.661-6.186-1.809 c0.324,0.037,0.636,0.05,0.973,0.05c1.883,0,3.616-0.636,5.001-1.721c-1.771-0.037-3.255-1.197-3.767-2.793 c0.249,0.037,0.499,0.062,0.761,0.062c0.361,0,0.724-0.05,1.061-0.137c-1.847-0.374-3.23-1.995-3.23-3.953v-0.05 c0.537,0.299,1.16,0.486,1.82,0.511C3.534,9.419,2.823,8.184,2.823,6.787c0-0.748,0.199-1.434,0.548-2.032 c1.983,2.443,4.964,4.04,8.306,4.215c-0.062-0.3-0.1-0.611-0.1-0.923c0-2.22,1.796-4.028,4.028-4.028 c1.16,0,2.207,0.486,2.943,1.272c0.91-0.175,1.782-0.512,2.556-0.973c-0.299,0.935-0.936,1.721-1.771,2.22 c0.811-0.088,1.597-0.312,2.319-0.624C21.104,6.712,20.419,7.423,19.633,7.997z",
                PathUrl = "www.twitter.com"
            },
            new SocialMedia
            {
                Id = 3,
                PathName = "instagram",
                Path = "M20.533,6.111c-0.469-1.209-1.424-2.165-2.633-2.632c-0.699-0.263-1.438-0.404-2.186-0.42 c-0.963-0.042-1.268-0.054-3.71-0.054s-2.755,0-3.71,0.054C7.548,3.074,6.809,3.215,6.11,3.479C4.9,3.946,3.945,4.902,3.477,6.111 c-0.263,0.7-0.404,1.438-0.419,2.186c-0.043,0.962-0.056,1.267-0.056,3.71c0,2.442,0,2.753,0.056,3.71 c0.015,0.748,0.156,1.486,0.419,2.187c0.469,1.208,1.424,2.164,2.634,2.632c0.696,0.272,1.435,0.426,2.185,0.45 c0.963,0.042,1.268,0.055,3.71,0.055s2.755,0,3.71-0.055c0.747-0.015,1.486-0.157,2.186-0.419c1.209-0.469,2.164-1.424,2.633-2.633 c0.263-0.7,0.404-1.438,0.419-2.186c0.043-0.962,0.056-1.267,0.056-3.71s0-2.753-0.056-3.71C20.941,7.57,20.801,6.819,20.533,6.111z M19.315,15.643c-0.007,0.576-0.111,1.147-0.311,1.688c-0.305,0.787-0.926,1.409-1.712,1.711c-0.535,0.199-1.099,0.303-1.67,0.311 c-0.95,0.044-1.218,0.055-3.654,0.055c-2.438,0-2.687,0-3.655-0.055c-0.569-0.007-1.135-0.112-1.669-0.311 c-0.789-0.301-1.414-0.923-1.719-1.711c-0.196-0.534-0.302-1.099-0.311-1.669c-0.043-0.95-0.053-1.218-0.053-3.654 c0-2.437,0-2.686,0.053-3.655c0.007-0.576,0.111-1.146,0.311-1.687c0.305-0.789,0.93-1.41,1.719-1.712 c0.534-0.198,1.1-0.303,1.669-0.311c0.951-0.043,1.218-0.055,3.655-0.055c2.437,0,2.687,0,3.654,0.055 c0.571,0.007,1.135,0.112,1.67,0.311c0.786,0.303,1.407,0.925,1.712,1.712c0.196,0.534,0.302,1.099,0.311,1.669 c0.043,0.951,0.054,1.218,0.054,3.655c0,2.436,0,2.698-0.043,3.654H19.315z",
                PathUrl = "www.instagram.com"
            },
            new SocialMedia
            {
                Id = 4,
                PathName = "dribble",
                Path = "M20.66 6.98a9.932 9.932 0 0 0-3.641-3.64C15.486 2.447 13.813 2 12 2s-3.486.447-5.02 1.34c-1.533.893-2.747 2.107-3.64 3.64S2 10.187 2 12s.446 3.487 1.34 5.02a9.924 9.924 0 0 0 3.641 3.64C8.514 21.553 10.187 22 12 22s3.486-.447 5.02-1.34a9.932 9.932 0 0 0 3.641-3.64C21.554 15.487 22 13.813 22 12s-.446-3.487-1.34-5.02zM12 3.66c2 0 3.772.64 5.32 1.919-.92 1.174-2.286 2.14-4.1 2.9-1.002-1.813-2.088-3.327-3.261-4.54A7.715 7.715 0 0 1 12 3.66zM5.51 6.8a8.116 8.116 0 0 1 2.711-2.22c1.212 1.201 2.325 2.7 3.34 4.5-2 .6-4.114.9-6.341.9-.573 0-1.006-.013-1.3-.04A8.549 8.549 0 0 1 5.51 6.8zM3.66 12c0-.054.003-.12.01-.2.007-.08.01-.146.01-.2.254.014.641.02 1.161.02 2.666 0 5.146-.367 7.439-1.1.187.373.381.793.58 1.26-1.32.293-2.674 1.006-4.061 2.14S6.4 16.247 5.76 17.5c-1.4-1.587-2.1-3.42-2.1-5.5zM12 20.34c-1.894 0-3.594-.587-5.101-1.759.601-1.187 1.524-2.322 2.771-3.401 1.246-1.08 2.483-1.753 3.71-2.02a29.441 29.441 0 0 1 1.56 6.62 8.166 8.166 0 0 1-2.94.56zm7.08-3.96a8.351 8.351 0 0 1-2.58 2.621c-.24-2.08-.7-4.107-1.379-6.081.932-.066 1.765-.1 2.5-.1.799 0 1.686.034 2.659.1a8.098 8.098 0 0 1-1.2 3.46zm-1.24-5c-1.16 0-2.233.047-3.22.14a27.053 27.053 0 0 0-.68-1.62c2.066-.906 3.532-2.006 4.399-3.3 1.2 1.414 1.854 3.027 1.96 4.84-.812-.04-1.632-.06-2.459-.06z",
                PathUrl = "www.dribble.com"
            });
        #endregion

        #region Testimonial
        modelBuilder.Entity<Testimonial>().HasData(
            new Testimonial
            {
                Id = 1,
                Description = "Molestiae incidunt consequatur quis ipsa autem nam sit enim magni. Voluptas tempore rem. Explicabo a quaerat sint autem dolore ducimus ut consequatur neque. Nisi dolores quaerat fuga rem nihil nostrum. Laudantium quia consequatur molestias.",
                ImagePath = "images/avatars/user-01.jpg",
                FullName = "John Rockefeller",
                Profession = "Standard Oil Co."
            },
            new Testimonial
            {
                Id = 2,
                Description = "Molestiae incidunt consequatur quis ipsa autem nam sit enim magni. Voluptas tempore rem. Explicabo a quaerat sint autem dolore ducimus ut consequatur neque. Nisi dolores quaerat fuga rem nihil nostrum. Laudantium quia consequatur molestias.",
                ImagePath = "images/avatars/user-04.jpg",
                FullName = "Andrew Carnegie",
                Profession = "Carnegie Steel Co."
            },
            new Testimonial
            {
                Id = 3,
                Description = "Molestiae incidunt consequatur quis ipsa autem nam sit enim magni. Voluptas tempore rem. Explicabo a quaerat sint autem dolore ducimus ut consequatur neque. Nisi dolores quaerat fuga rem nihil nostrum. Laudantium quia consequatur molestias.",
                ImagePath = "images/avatars/user-06.jpg",
                FullName = "Henry Ford",
                Profession = "Ford Motor Co."
            },
            new Testimonial
            {
                Id = 4,
                Description = "Molestiae incidunt consequatur quis ipsa autem nam sit enim magni. Voluptas tempore rem. Explicabo a quaerat sint autem dolore ducimus ut consequatur neque. Nisi dolores quaerat fuga rem nihil nostrum. Laudantium quia consequatur molestias.",
                ImagePath = "images/avatars/user-02.jpg",
                FullName = "John Morgan",
                Profession = "JP Morgan & Co."
            });
        #endregion

        #region TestimonialContent
        modelBuilder.Entity<TestimonialContent>().HasData(
            new TestimonialContent
            {
                Id = 1,
                Title = "Testimonials",
                DisplayTitle = "Reviews From Real Clients"
            });
        #endregion

        #region User
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Username = "furkanaltintas",
                PasswordHash = "12345A.",
                Role = "Admin",
            });
        #endregion
    }
}