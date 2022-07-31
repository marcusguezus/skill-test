using Microsoft.EntityFrameworkCore;
using SkillTest.Models;

namespace SkillTest.Repository
{
    public class SkillTestContext : DbContext
    {
        public SkillTestContext(DbContextOptions<SkillTestContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
