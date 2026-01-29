using ClientServiceRazor.Features.Clients.Models;
using Microsoft.EntityFrameworkCore;
    
namespace ClientServiceRazor.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Client> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Client>()
            .HasIndex(b => b.Email)
            .IsUnique();
    }
}