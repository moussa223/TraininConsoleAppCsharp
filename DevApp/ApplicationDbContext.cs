using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DevApp
{
    public class ApplicationDbContext : DbContext ,IApplicationDbContext
    {
        public ApplicationDbContext()
        {
        
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public DbSet<Langues> Langues { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Langues>().HasKey(k => k.Id);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source=localhost;Initial Catalog=WPF1;Integrated Security=True");
            }
            
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
