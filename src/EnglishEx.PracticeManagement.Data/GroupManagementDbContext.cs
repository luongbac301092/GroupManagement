using EnglishEx.PracticeManagement.Data.Configurations;
using EnglishEx.PracticeManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnglishEx.PracticeManagement.Data
{
    public class GroupManagementDbContext : DbContext
    {
        public DbSet<GroupEntity> Groups { get; set; }

        public GroupManagementDbContext(DbContextOptions<GroupManagementDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.ApplyConfiguration(new GroupEntityConfiguration());
        }
    }
}