using CredirService.Domain.Entity;
using CreditService.Application.Common;
using Microsoft.EntityFrameworkCore;

namespace CreditService.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Credit> Credits { get; set; }

        public Task<int> SaveChangedAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
