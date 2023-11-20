using Microsoft.EntityFrameworkCore;

namespace ProductsMicroservice.Persistance;

public class DatabaseContext : DbContext
{
	public DbSet<Arquisoft.Remote.Product> Products { get; set; }

	public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseMySql("name=ConnectionStrings:DatabaseConnection", ServerVersion.Parse("8.1.0-mysql"));

	protected override void OnModelCreating(ModelBuilder modelBuilder)
		=> modelBuilder.Entity<Arquisoft.Remote.Product>().HasKey(e => new { e.Id, e.Supplier });
}