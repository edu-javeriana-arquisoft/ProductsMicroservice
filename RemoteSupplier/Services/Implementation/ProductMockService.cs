using Arquisoft.Remote;
using Bogus;

namespace RemoteSupplier.Services.Implementation;

public class ProductMockService : IMockService<Product>
{
	private int _count = 0;
	private readonly Faker<Product> _faker;

	private readonly string _supplierGuid;

	private readonly Random _random = new();

	public ProductMockService(IConfiguration configuration)
	{
		_supplierGuid = configuration["SupplierGuid"]!;
		_faker = new Faker<Product>()
			.CustomInstantiator(f => new Product
			{
				Id = _count++,
				Supplier = _supplierGuid,
				Name = f.Commerce.Product(),
				Category = f.Commerce.Categories(1).First(),
				Vendor = f.Company.CompanyName(),
				Image = f.Image.PicsumUrl(),
			})
			.RuleFor(p => p.Amount, (f, p) => p.Amount = _random.Next(0, 256))
			.RuleFor(p => p.Price, (f, p) => p.Price = _random.NextDouble() * 10_000f);
	}

	public Product NewMock() => _faker.Generate();
}