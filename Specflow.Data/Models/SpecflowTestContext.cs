using System.Data.Entity;
using Specflow.Data.Models.Mapping;

namespace Specflow.Data.Models
{
    public partial class SpecflowTestContext : DbContext
    {
        static SpecflowTestContext()
        {
            Database.SetInitializer<SpecflowTestContext>(null);
        }

        public SpecflowTestContext()
            : base("Name=DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserProfileMap());
            modelBuilder.Configurations.Add(new webpages_MembershipMap());
            modelBuilder.Configurations.Add(new webpages_OAuthMembershipMap());
            modelBuilder.Configurations.Add(new webpages_RolesMap());
        }
    }
}
