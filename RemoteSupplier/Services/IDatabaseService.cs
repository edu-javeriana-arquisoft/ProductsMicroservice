using Arquisoft.Remote;

namespace RemoteSupplier.Services;

public interface IDatabaseService
{
	Guid GetSupplierGuid();
	Product? GetProductById(int id);
	Product? GetProductByName(string name);
	List<Product> GetProductsByCategory(string category);
	List<Product> GetProductsByVendor(string vendor);
	List<Product> GetAllProducts();
}