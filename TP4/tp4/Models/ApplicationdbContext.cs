using Microsoft.EntityFrameworkCore;

namespace tp4.Models
{
    public class ApplicationdbContext: DbContext
    {

        public DbSet<Films> Films { get; set; }
        public DbSet<Role> Roles { get; set; }
        public ApplicationdbContext(DbContextOptions options) :base(options){ }

    }
}
