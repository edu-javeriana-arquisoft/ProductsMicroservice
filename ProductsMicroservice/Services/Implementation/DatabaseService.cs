using Arquisoft.Remote;

namespace ProductsMicroservice.Services.Implementation;

public class DatabaseService : IDatabaseService
{
	private readonly SuppliersService _suppliers;
	public DatabaseService(SuppliersService suppliers)
	{
		_suppliers = suppliers;
	}

	public bool BuyProduct(Guid supplier, int id) =>
		_suppliers.Suppliers.Any(e => e.Client.BuyProduct(
			new ProductRequest { Id = id, Supplier = supplier.ToString() }
		).Value);

	public List<Product> GetAllProducts() =>
		_suppliers.Suppliers.SelectMany(e =>
			e.Client.GetAllProducts(new NoneType()).Products.ToList()
		).ToList();

	public List<Product> GetProductsByCategory(string category) =>
		_suppliers.Suppliers.SelectMany(e =>
			e.Client.GetProductsByCategory(new StringType { Value = category }).Products.ToList()
		).ToList();

	public List<Product> GetProductsByVendor(string vendor) =>
		_suppliers.Suppliers.SelectMany(e =>
			e.Client.GetProductsByVendor(new StringType { Value = vendor }).Products.ToList()
		).ToList();


}

