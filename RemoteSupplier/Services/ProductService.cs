using Arquisoft.Remote;
using Grpc.Core;

namespace RemoteSupplier.Services;

public class ProductService : Arquisoft.Remote.ProductService.ProductServiceBase
{
	private readonly ILogger<ProductService> _logger;
	private readonly IDatabaseService _database;

	public ProductService(ILogger<ProductService> logger, IDatabaseService database)
	{
		_logger = logger;
		_database = database;
	}

	public override Task<Product> GetProductById(Int32Type request, ServerCallContext _)
	{
		var value = _database.GetProductById(request.Value);
		return value != null
			? Task.FromResult(value)
			: Task.FromException<Product>(
				new InvalidOperationException($"Product with id `{request.Value}` could not be found"));
	}

	public override Task<Product> GetProductByName(StringType request, ServerCallContext _)
	{
		var value = _database.GetProductByName(request.Value);
		return value != null
			? Task.FromResult(value)
			: Task.FromException<Product>(
				new InvalidOperationException($"Product with name `{request.Value}` could not be found"));
	}

	public override Task<ProductsResponse> GetProductsByCategory(StringType request, ServerCallContext _)
	{
		var value = _database.GetProductsByCategory(request.Value);
		var response = new ProductsResponse();

		response.Products.AddRange(value);
		return Task.FromResult(response);
	}

	public override Task<ProductsResponse> GetProductsByVendor(StringType request, ServerCallContext _)
	{
		var value = _database.GetProductsByVendor(request.Value);
		var response = new ProductsResponse();

		response.Products.AddRange(value);
		return Task.FromResult(response);
	}

	public override Task<ProductsResponse> GetAllProducts(NoneType _, ServerCallContext __)
	{
		var value = _database.GetAllProducts();
		var response = new ProductsResponse();

		response.Products.AddRange(value);
		return Task.FromResult(response);
	}

	public override Task<BooleanType> BuyProduct(ProductRequest request, ServerCallContext context)
	{
		return Task.FromResult(new BooleanType
		{
			Value = _database.BuyProduct(request.Id, Guid.Parse(request.Supplier))
		});
	}
}
