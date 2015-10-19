using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyAwesomeBookStore.Models.DataLibrary;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyAwesomeBookStore.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // TODO change DbSet
        public DbSet<AccessInfo> AccessInfo { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Epub> Epub { get; set; }
        public DbSet<ImageLinks> ImageLinks { get; set; }
        public DbSet<IndustryIdentifier> IndustrialIdentifier { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Pdf> Pdf { get; set; }
        public DbSet<ReadingModes> ReadingModes { get; set; }
        public DbSet<RootObject> RootObject { get; set; }
        public DbSet<SaleInfo> SaleInfo { get; set; }
        public DbSet<SearchInfo> SearchInfo { get; set; }
        public DbSet<VolumeInfo> VolumeInfo { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}