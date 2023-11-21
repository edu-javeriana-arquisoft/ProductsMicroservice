using Arquisoft.Remote;

namespace ProductsMicroservice.Services;

public interface IDatabaseService
{
	List<Product> GetProductsByCategory(string category);
	List<Product> GetProductsByVendor(string vendor);
	List<Product> GetAllProducts();
	bool BuyProduct(Guid supplier, int id);
}