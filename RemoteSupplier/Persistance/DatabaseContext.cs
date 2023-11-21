using Microsoft.EntityFrameworkCore;
using RemoteSupplier.Services;

namespace RemoteSupplier.Persistance;

public class DatabaseContext : DbContext
{
	public DbSet<Arquisoft.Remote.Product> Products { get; set; }

	private readonly IMockService<Arquisoft.Remote.Product> _productMock;

	public DatabaseContext(
		DbContextOptions<DatabaseContext> options,
		IMockService<Arquisoft.Remote.Product> productMock)
		: base(options)
	{
		_productMock = productMock;
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseMySql("name=ConnectionStrings:DatabaseConnection", ServerVersion.Parse("8.1.0-mysql"));

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Build composite primary key
		modelBuilder.Entity<Arquisoft.Remote.Product>().HasKey(e => new { e.Id, e.Supplier });
		// Seed data
		modelBuilder.Entity<Arquisoft.Remote.Product>().HasData(
			Enumerable.Range(0, 20).Select(_ => _productMock.NewMock()).ToArray()
		);
	}
}