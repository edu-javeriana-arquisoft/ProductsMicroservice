using Arquisoft.Remote;
using RemoteSupplier.Services;

namespace RemoteSupplier.Persistance.Implementation;

public class DatabaseService : IDatabaseService
{
	private readonly Guid _supplierGuid;
	private readonly DatabaseContext _dbContext;

	public DatabaseService(IConfiguration configuration, DatabaseContext dbContext)
	{
		_dbContext = dbContext;
		_supplierGuid = Guid.Parse(configuration["SupplierGuid"]!);
	}

	public bool BuyProduct(int id, Guid supplier)
	{
		if (supplier != _supplierGuid)
		{
			return false;
		}

		var product = _dbContext.Products.SingleOrDefault(
			e => e.Id == id && e.Supplier == supplier.ToString());

		if (product is null)
		{
			return false;
		}
		else if (product.Amount <= 0)
		{
			return false;
		}

		product.Amount--;
		_dbContext.SaveChanges();

		return true;
	}

	public List<Product> GetAllProducts() => _dbContext.Products.ToList();

	public Product? GetProductById(int id) => _dbContext.Products.SingleOrDefault(e => e.Id == id);

	public Product? GetProductByName(string name) => _dbContext.Products.FirstOrDefault(e => e.Name == name);

	public List<Product> GetProductsByCategory(string category) => _dbContext.Products.Where(e => e.Category == category).ToList();

	public List<Product> GetProductsByVendor(string vendor) => _dbContext.Products.Where(e => e.Vendor == vendor).ToList();

	public Guid GetSupplierGuid() => _supplierGuid;
}