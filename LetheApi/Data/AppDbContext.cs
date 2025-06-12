using LetheApi.Data.SeedData;
using LetheApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LetheApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Seed(); // Seed metodunu çağırarak başlangıç verilerini ekler
    }

    #region DbSets
    public DbSet<About> Abouts => Set<About>();
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<ClientContent> ClientContents => Set<ClientContent>();
    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<ContactContent> ContactContents => Set<ContactContent>();
    public DbSet<Copyright> Copyrights => Set<Copyright>();
    public DbSet<Cta> Ctas => Set<Cta>();
    public DbSet<Expertise> Expertises => Set<Expertise>();
    public DbSet<ExpertiseContent> ExpertiseContents => Set<ExpertiseContent>();
    public DbSet<FooterAbout> FooterAbouts => Set<FooterAbout>();
    public DbSet<Intro> Intros => Set<Intro>();
    public DbSet<Journal> Journals => Set<Journal>();
    public DbSet<JournalContent> JournalContents => Set<JournalContent>();
    public DbSet<Newsletter> Newsletters => Set<Newsletter>();
    public DbSet<PageHeader> PageHeaders => Set<PageHeader>();
    public DbSet<PageIntro> PageIntros => Set<PageIntro>();
    public DbSet<SiteLink> SiteLinks => Set<SiteLink>();
    public DbSet<SocialMedia> SocialMedias => Set<SocialMedia>();
    public DbSet<Testimonial> Testimonials => Set<Testimonial>();
    public DbSet<TestimonialContent> TestimonialContents => Set<TestimonialContent>();
    public DbSet<User> Users => Set<User>();
    #endregion
}
